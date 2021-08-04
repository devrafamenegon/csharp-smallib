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

namespace Smallib.ChildForms.Cadastros.Genero
{
    public partial class GeneroNovo : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True"); //Variável para conexão com o banco
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        string nome_genero;
        int pk_id_genero;

        Principal _principal;
        public GeneroNovo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            conectar.Open();

            SqlCommand obterTotalId = new SqlCommand("select ident_current('Genero')", conectar);
            SqlCommand obterId = new SqlCommand("select pk_id_genero from Genero", conectar);
            int numeroTotalId = Convert.ToInt32(obterTotalId.ExecuteScalar());
            int numeroId = Convert.ToInt32(obterId.ExecuteScalar());

            //se caso a quantidade de pk_id_genero forem maiores do que 0, então soma-se 1 no total de identificadores criados
            if (numeroId > 0)
            {
                txtBoxIdGenero.Text = (numeroTotalId + 1).ToString();
            }

            //caso o a quantidade de pk_id_genero for 0,
            //pega-se o valor total de identificadores já criados, pois estes começam sua contagem valendo 1
            else
            {
                txtBoxIdGenero.Text = numeroTotalId.ToString();
            }

            conectar.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new GeneroMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Passando o valor digitado no campo de nome para a varíavel nome_genero
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
                    conectar.Open();

                    //objeto da conexão
                    SqlCommand cadastrar_genero = new SqlCommand();

                    //condicional para realizar o cadastro
                    if (txtBoxNomeGenero.Text != "")
                    {
                        cadastrar_genero.CommandText = "INSERT INTO Genero (nome_genero) VALUES('" + nome_genero + "')";

                        //MessageBox para informar o usuário que o registro foi bem sucessido
                        if (MessageBox.Show("Gênero criado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            //após fechar o MessageBox, busca-se o novo número para ser mostrado no campo ID
                            SqlCommand obterTotalId = new SqlCommand("select ident_current('Genero')", conectar);
                            SqlCommand obterId = new SqlCommand("select pk_id_genero from Genero", conectar);
                            int numeroTotalId = Convert.ToInt32(obterTotalId.ExecuteScalar());
                            int numeroId = Convert.ToInt32(obterId.ExecuteScalar());

                            //se caso a quantidade de pk_id_genero forem maiores do que 0, então soma-se 2 no total de identificadores criados
                            if (numeroId > 0)
                            {
                                txtBoxIdGenero.Text = (numeroTotalId + 2).ToString();
                            }

                            //caso o a quantidade de pk_id_genero for 0,
                            //pega-se o valor total de identificadores já criados + 1
                            else
                            {
                                txtBoxIdGenero.Text = (numeroTotalId + 1).ToString();
                            }

                            //Limpando o campo de nome
                            txtBoxNomeGenero.Text = "";
                        }
                    }

                    //Caso o campo nome seja vazío
                    else
                    {
                        MessageBox.Show("Não foi possível criar o gênero, insira valores válidos", "Aviso:", MessageBoxButtons.OK);
                    }

                    //Rodando o comando no banco de dados
                    cadastrar_genero.Connection = conectar;
                    cadastrar_genero.ExecuteNonQuery();
                }

                //Tratamento de erros
                catch (SqlException error)
                {
                    //SqlException innerException = ex.InnerException as SqlException;
                    if (error != null && error.Number == 2627)
                    {
                        MessageBox.Show("Houve uma falha ao realizar o processo. Gênero " + nome_genero + " já existe!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível estabelecer conexão com o banco de dados." + Convert.ToString(error.Number));
                    }
                }

                conectar.Close();
            }
        }
    }
}
