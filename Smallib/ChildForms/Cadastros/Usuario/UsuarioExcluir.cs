using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Smallib.Program;

namespace Smallib.ChildForms
{
    public partial class UsuarioExcluir : Form
    {
        int pk_id_usuario;

        private Principal _principal;
        public UsuarioExcluir(Principal principal, Cadastro_Usuario c1)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdUsuario.Text = c1.pk_id_usuario.ToString();
            txtBoxNomeUsuario.Text = c1.nome_usuario;
            txtBoxLoginUsuario.Text = c1.login_usuario;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Aviso ⚠", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Passando os valores dos campos para as variáveis
                pk_id_usuario = Convert.ToInt32(txtBoxIdUsuario.Text);

                try
                {
                    //abrindo a conexão
                    conectar.Open();

                    //objeto de conexao
                    SqlCommand excluir_usuario = new SqlCommand();

                    //string de comando no sql
                    excluir_usuario.CommandText = ("DELETE FROM Usuario WHERE pk_id_usuario = " + pk_id_usuario);

                    //enviando para o banco
                    excluir_usuario.Connection = conectar;
                    excluir_usuario.ExecuteNonQuery();

                    //fechando a conexão
                    conectar.Close();

                    if (MessageBox.Show("Usuario excluído com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        _principal.OpenChildForm(new UsuarioMenu(_principal));
                    }
                }

                //Caso algo dê errado
                catch
                {
                    MessageBox.Show("Não foi possível estabelecer a conexão com o banco de dados!");
                }
            }         
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new UsuarioMenu(_principal));
        }
    }
}
