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

namespace Smallib.ChildForms.Cadastros.Tipo_do_Leitor
{
    public partial class TipoEditar : Form
    {
        string nome_tipo;
        int pk_id_tipo;

        Principal _principal;
        public TipoEditar(Principal principal, Cadastro_Tipo_Leitor cadastro_tipo_leitor_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdTipo.Text = cadastro_tipo_leitor_01.pk_id_tipo.ToString();
            txtBoxNomeTipo.Text = cadastro_tipo_leitor_01.nome_tipo;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new TipoMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Passando os valores dos campos para as variáveis
            pk_id_tipo = Convert.ToInt32(txtBoxIdTipo.Text);
            nome_tipo = txtBoxNomeTipo.Text;

            //Verificando se o curso ja existe no banco
            conectar.Open();
            SqlCommand verificar = new SqlCommand("Select * from Tipo where nome_tipo = '" + nome_tipo + "'", conectar);
            bool resultado = verificar.ExecuteReader().HasRows;
            conectar.Close();

            if (resultado == true)
            {
                //Caso ja exista
                MessageBox.Show("Este tipo já existe no banco de dados!!");
            }

            else
            {
                try
                {
                    //Abrindo conexão com o banco
                    conectar.Open();

                    //Nomeando o objeto da conexão
                    SqlCommand update_curso = new SqlCommand();

                    update_curso.CommandText = ("UPDATE Tipo set nome_tipo = '" + nome_tipo + "' WHERE pk_id_tipo = " + pk_id_tipo);

                    //Rodando o comando no banco de dados
                    update_curso.Connection = conectar;
                    update_curso.ExecuteNonQuery();

                    conectar.Close();

                    //MessageBox para informar que o tipo de leitor foi editado com sucesso e após ser fechado envia
                    //o usuário para a tela de menu
                    if (MessageBox.Show("Tipo de leitor editado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        _principal.OpenChildForm(new TipoMenu(_principal));
                    }
                }

                //Caso algo de errado no processo
                catch
                {
                    MessageBox.Show("Não foi possível editar o tipo", "Aviso:", MessageBoxButtons.OK);
                }
            }
        }
    }
}
