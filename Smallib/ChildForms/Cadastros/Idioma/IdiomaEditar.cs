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
    public partial class IdiomaEditar : Form
    {
        int pk_id_idioma;
        string nome_idioma;

        Principal _principal;
        public IdiomaEditar(Principal principal, Cadastro_Idioma cadastro_idioma_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdIdioma.Text = cadastro_idioma_01.pk_id_idioma.ToString();
            txtBoxNomeIdioma.Text = cadastro_idioma_01.nome_idioma;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new IdiomaMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Passando os valores dos campos para as variáveis
            pk_id_idioma = Convert.ToInt32(txtBoxIdIdioma.Text);
            nome_idioma = txtBoxNomeIdioma.Text;

            try
            {
                //Abrindo conexão com o banco
                conectar.Open();

                //Nomeando o objeto da conexão
                SqlCommand update_idioma = new SqlCommand();

                update_idioma.CommandText = ("UPDATE Idioma set nome_idioma = '" + nome_idioma + "' WHERE pk_id_idioma = " + pk_id_idioma);

                //Rodando o comando no banco de dados
                update_idioma.Connection = conectar;
                update_idioma.ExecuteNonQuery();

                conectar.Close();

                //MessageBox para informar que o idioma foi editado com sucesso e após ser fechado envia
                //o usuário para a tela de menu
                if (MessageBox.Show("Idioma editado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    _principal.OpenChildForm(new IdiomaMenu(_principal));
                }
            }

            //Caso algo de errado no processo
            catch
            {
                MessageBox.Show("Não foi possível editar o idioma", "Aviso:", MessageBoxButtons.OK);
            }
        }
    }
}
