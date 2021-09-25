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

namespace Smallib.ChildForms.Cadastros.Idioma
{
    public partial class IdiomaExcluir : Form
    {
        int pk_id_idioma;
        string nome_idioma;

        Principal _principal;
        public IdiomaExcluir(Principal principal, Cadastro_Idioma cadastro_idioma_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdIdioma.Text = cadastro_idioma_01.pk_id_idioma.ToString();
            txtBoxNomeIdioma.Text = cadastro_idioma_01.nome_idioma;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Aviso ⚠", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Passando os valores dos campos para as variáveis
                pk_id_idioma = Convert.ToInt32(txtBoxIdIdioma.Text);
                nome_idioma = txtBoxNomeIdioma.Text;

                try
                {
                    //abrindo a conexão
                    conectar.Open();

                    //objeto de conexao
                    SqlCommand excluir_idioma = new SqlCommand();

                    //string de comando no sql
                    excluir_idioma.CommandText = ("DELETE FROM Idioma WHERE pk_id_idioma = " + pk_id_idioma);

                    //enviando para o banco
                    excluir_idioma.Connection = conectar;
                    excluir_idioma.ExecuteNonQuery();

                    //fechando a conexão
                    conectar.Close();

                    if (MessageBox.Show("Idioma excluído com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        _principal.OpenChildForm(new IdiomaMenu(_principal));
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
            _principal.OpenChildForm(new IdiomaMenu(_principal));
        }
    }
}
