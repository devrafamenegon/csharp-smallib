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


namespace Smallib.ChildForms.Cadastros.Idioma
{
    public partial class IdiomaNovo : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True"); //Variável para conexão com o banco
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        Principal _principal;

        string nome_idioma;

        public IdiomaNovo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            conectar.Open();

            SqlCommand obterTotalId = new SqlCommand("select ident_current('Idioma')", conectar);
            SqlCommand obterId = new SqlCommand("select pk_id_idioma from Idioma", conectar);
            int numeroTotalId = Convert.ToInt32(obterTotalId.ExecuteScalar());
            int numeroId = Convert.ToInt32(obterId.ExecuteScalar());

            //se caso a quantidade de pk_id_idioma forem maiores do que 0, então soma-se 1 no total de identificadores criados
            if (numeroId > 0)
            {
                txtBoxIdIdioma.Text = (numeroTotalId + 1).ToString();
            }

            else if (numeroTotalId == 1)
            {
                txtBoxIdIdioma.Text = (numeroTotalId + 1).ToString();
            }

            //caso o a quantidade de pk_id_idioma for 0,
            //pega-se o valor total de identificadores já criados, pois estes começam sua contagem valendo 1
            else
            {
                txtBoxIdIdioma.Text = numeroTotalId.ToString();
            }

            conectar.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new IdiomaMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Passando o valor digitado no campo de nome para a varíavel nome_idioma
            nome_idioma = txtBoxNomeIdioma.Text;

            //Verificando se o idioma ja existe no banco
            conectar.Open();
            SqlCommand verificar = new SqlCommand("Select * from Idioma where nome_idioma = '" + txtBoxNomeIdioma.Text + "'", conectar);
            bool resultado = verificar.ExecuteReader().HasRows;

            if (resultado == true)
            {
                //Caso ja exista
                conectar.Close();
                MessageBox.Show("Este idioma já existe no banco de dados!!");
            }
            else
            {
                conectar.Close();

                try
                {
                    //abrindo conexão
                    conectar.Open();

                    //objeto da conexão
                    SqlCommand cadastrar_idioma = new SqlCommand();

                    //condicional para realizar o cadastro
                    if (txtBoxNomeIdioma.Text != "")
                    {
                        cadastrar_idioma.CommandText = "INSERT INTO Idioma (nome_idioma) VALUES('" + nome_idioma + "')";

                        //Rodando o comando no banco de dados
                        cadastrar_idioma.Connection = conectar;
                        cadastrar_idioma.ExecuteNonQuery();

                        //MessageBox para informar o usuário que o registro foi bem sucessido
                        if (MessageBox.Show("Idioma criado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            //após fechar o MessageBox, busca-se o novo número para ser mostrado no campo ID
                            SqlCommand obterTotalId = new SqlCommand("select ident_current('Idioma')", conectar);
                            SqlCommand obterId = new SqlCommand("select pk_id_idioma from Idioma", conectar);
                            int numeroTotalId = Convert.ToInt32(obterTotalId.ExecuteScalar());
                            int numeroId = Convert.ToInt32(obterId.ExecuteScalar());

                            //se caso a quantidade de pk_id_idioma forem maiores do que 0, então soma-se 2 no total de identificadores criados
                            if (numeroId > 0)
                            {
                                txtBoxIdIdioma.Text = (numeroTotalId + 1).ToString();
                            }

                            //caso o a quantidade de idioma for 0,
                            //pega-se o valor total de identificadores já criados + 1
                            else
                            {
                                txtBoxIdIdioma.Text = numeroTotalId.ToString();
                            }

                            //Limpando o campo de nome
                            txtBoxNomeIdioma.Text = "";
                        }
                    }

                    //Caso o campo nome seja vazío
                    else
                    {
                        MessageBox.Show("Não foi possível criar o idioma, insira valores válidos", "Aviso:", MessageBoxButtons.OK);
                    }
                }

                //Tratamento de erros
                catch (SqlException error)
                {
                    //SqlException innerException = ex.InnerException as SqlException;
                    if (error != null && error.Number == 2627)
                    {
                        MessageBox.Show("Houve uma falha ao realizar o processo. Idioma " + nome_idioma + " já existe!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível estabelecer conexão com o banco de dados. Erro n°" + Convert.ToString(error.Number));
                    }
                }
            }

            conectar.Close();
        }
    }
}
