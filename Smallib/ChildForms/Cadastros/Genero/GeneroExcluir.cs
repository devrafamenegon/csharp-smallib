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

namespace Smallib.ChildForms.Cadastros.Genero
{
    public partial class GeneroExcluir : Form
    {
        string nome_genero;
        int pk_id_genero;

        Principal _principal;
        public GeneroExcluir(Principal principal, Cadastro_Genero cadastro_genero_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdGenero.Text = cadastro_genero_01.pk_id_genero.ToString();
            txtBoxNomeGenero.Text = cadastro_genero_01.nome_genero;
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new GeneroMenu(_principal));
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Aviso ⚠", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Passando os valores dos campos para as variáveis
                pk_id_genero = Convert.ToInt32(txtBoxIdGenero.Text);
                nome_genero = txtBoxNomeGenero.Text;

                try
                {
                    //abrindo a conexão
                    conectar.Open();

                    //objeto de conexao
                    SqlCommand excluir_genero = new SqlCommand();

                    //string de comando no sql
                    excluir_genero.CommandText = ("DELETE FROM Genero WHERE pk_id_genero = " + pk_id_genero);

                    //enviando para o banco
                    excluir_genero.Connection = conectar;
                    excluir_genero.ExecuteNonQuery();

                    //fechando a conexão
                    conectar.Close();

                    if (MessageBox.Show("Gênero excluído com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                       _principal.OpenChildForm(new GeneroMenu(_principal));
                    }

                }

                //Caso algo dê errado
                catch
                {
                    MessageBox.Show("Não foi possível estabelecer a conexão com o banco de dados!");
                }
            }
        }
    }
}
