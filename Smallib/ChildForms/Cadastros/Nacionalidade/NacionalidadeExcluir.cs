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

namespace Smallib.ChildForms.Cadastros.Nacionalidade
{
    public partial class NacionalidadeExcluir : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        string nome_nacionalidade;
        int pk_id_nacionalidade;

        Principal _principal;

        public NacionalidadeExcluir(Principal principal, Cadastro_Nacionalidade c1)
        {
            InitializeComponent();
            _principal = principal;
            txtBoxIdNacionalidade.Text = c1.pk_id_nacionalidade.ToString();
            txtBoxNomeNacionalidade.Text = c1.nome_nacionalidade;
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new NacionalidadeMenu(_principal));
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            nome_nacionalidade = txtBoxNomeNacionalidade.Text;
            pk_id_nacionalidade = Convert.ToInt32(txtBoxIdNacionalidade.Text);

            try
            {
                //abrindo a conexão
                conectar.Open();
                //objeto de conexao
                SqlCommand Excluir_Nacionalidade = new SqlCommand();

                if (pk_id_nacionalidade != 0)
                {
                    DialogResult resp = MessageBox.Show("Tem certeza de que deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        Excluir_Nacionalidade.CommandText = "delete from Nacionalidade where pk_id_nacionalidade = " + pk_id_nacionalidade;

                        //LOCAL ONDE SERÁ GUARDADO OS DADOS
                        Excluir_Nacionalidade.Connection = conectar;

                        //EXECUTAR QUERY
                        Excluir_Nacionalidade.ExecuteNonQuery();

                        MessageBox.Show("Exclusão efetuada com sucesso");

                        _principal.OpenChildForm(new NacionalidadeMenu(_principal));
                    }
                }

                //FECHAR CONEXÃO
                conectar.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CONECTAR COM O BANCO DE DADOS!!!" + Convert.ToString(ex));
            }
        }
    }
}
