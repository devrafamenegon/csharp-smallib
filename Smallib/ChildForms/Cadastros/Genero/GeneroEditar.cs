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
    public partial class GeneroEditar : Form
    {
        string nome_genero;
        int pk_id_genero;

        Principal _principal;

        public GeneroEditar(Principal principal, Cadastro_Genero cadastro_genero_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdGenero.Text = cadastro_genero_01.pk_id_genero.ToString();
            txtBoxNomeGenero.Text = cadastro_genero_01.nome_genero;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new GeneroMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Passando os valores dos campos para as variáveis
            pk_id_genero = Convert.ToInt32(txtBoxIdGenero.Text);
            nome_genero = txtBoxNomeGenero.Text;

            //Verificando se o genero ja existe no banco
            conectar.Open();
            SqlCommand verificar = new SqlCommand("Select * from Genero where nome_genero = '" + txtBoxNomeGenero.Text + "'", conectar);
            bool resultado = verificar.ExecuteReader().HasRows;

            if (resultado == true)
            {
                //Caso ja exista
                conectar.Close();
                MessageBox.Show("Este gênero já existe no banco de dados!!");
            }

            else
            {
                conectar.Close();
                try
                {
                    //Abrindo conexão com o banco
                    conectar.Open();

                    //Nomeando o objeto da conexão
                    SqlCommand update_genero = new SqlCommand();

                    update_genero.CommandText = ("UPDATE Genero set nome_genero = '" + nome_genero + "' WHERE pk_id_genero = " + pk_id_genero);

                    //Rodando o comando no banco de dados
                    update_genero.Connection = conectar;
                    update_genero.ExecuteNonQuery();

                    conectar.Close();

                    //MessageBox para informar que o gênero foi editado com sucesso e após ser fechado envia
                    //o usuário para a tela de menu
                    if (MessageBox.Show("Gênero editado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        _principal.OpenChildForm(new GeneroMenu(_principal));
                    }
                }

                //Caso algo de errado no processo
                catch
                {
                    MessageBox.Show("Não foi possível editar o gênero", "Aviso:", MessageBoxButtons.OK);
                }
            }
        }
    }
}
