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

namespace Smallib.ChildForms.Cadastros.Nacionalidade
{
    public partial class NacionalidadeEditar : Form
    {
        int pk_id_nacionalidade; 
        string nome_nacionalidade;

        Principal _principal;
        public NacionalidadeEditar(Principal principal, Cadastro_Nacionalidade c1)
        {
            InitializeComponent();
            _principal = principal;
            txtBoxIdNacionalidade.Text = c1.pk_id_nacionalidade.ToString();
            txtBoxNomeNacionalidade.Text = c1.nome_nacionalidade;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new NacionalidadeMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome_nacionalidade = txtBoxNomeNacionalidade.Text;
            pk_id_nacionalidade = Convert.ToInt32(txtBoxIdNacionalidade.Text);

            try
            {

                //Verificando se o genero ja existe no banco
                conectar.Open();
                SqlCommand verificar = new SqlCommand("Select * from Nacionalidade where nome_nacionalidade = '" + nome_nacionalidade + "'", conectar);
                bool resultado = verificar.ExecuteReader().HasRows;

                if (resultado == true)
                {
                    //Caso ja exista
                    conectar.Close();
                    MessageBox.Show("Este gênero já existe no banco de dados!!");
                }

                else
                {
                    //Caso não exista
                    conectar.Close();

                    //Código do insert ou alteração aqui

                    //abrindo a conexão
                    conectar.Open();
                    //objeto de conexao
                    SqlCommand Editar_Nacionalidade = new SqlCommand();

                    if (txtBoxNomeNacionalidade.Text != null && txtBoxIdNacionalidade.Text != "")
                    {
                        if (pk_id_nacionalidade != 0)
                        {
                            Editar_Nacionalidade.CommandText = "update Nacionalidade set nome_nacionalidade = '" + nome_nacionalidade + "' Where pk_id_nacionalidade = " + pk_id_nacionalidade;
                            //pk_id_genero = 0;
                        }
                        else
                        {
                            MessageBox.Show("Erro ao editar nacionalidade! Preencha todos os campos.");
                        }

                        //LOCAL ONDE SERÁ GUARDADO OS DADOS
                        Editar_Nacionalidade.Connection = conectar;

                        //EXECUTAR QUERY
                        Editar_Nacionalidade.ExecuteNonQuery();

                        MessageBox.Show("Edição efetuada com sucesso");

                        txtBoxIdNacionalidade.Clear();
                        txtBoxNomeNacionalidade.Clear();
                        _principal.OpenChildForm(new NacionalidadeMenu(_principal));
                    }

                    //FECHAR CONEXÃO
                    conectar.Close();

                }

            }
            catch (SqlException ex)
            {
                //SqlException innerException = ex.InnerException as SqlException;
                if (ex != null && ex.Number == 2627)
                {
                    MessageBox.Show("Nacionalidade já existente!");
                    conectar.Close();
                }
                else
                {
                    MessageBox.Show("NÃO FOI POSSIVEL CONECTAR COM O BANCO DE DADOS!!!" + Convert.ToString(ex.Number));
                }
            }
        }
    }
}
