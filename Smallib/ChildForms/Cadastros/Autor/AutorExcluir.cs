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


namespace Smallib.ChildForms.Cadastros.Autores
{
    public partial class AutorExcluir : Form
    {
        Principal _principal;

        string nome_nacionalidade, pk_id_autor;

        public AutorExcluir(Principal principal, Cadastro_Autor cadastro_autores_01)
        {
            InitializeComponent();
            conectar.Close();
            _principal = principal;

            txtBoxIdAutor.Text = cadastro_autores_01.pk_id_autor.ToString();
            txtBoxNomeAutor.Text = cadastro_autores_01.nome_autor;
            txtBoxNacionalidadeAutor.Text = cadastro_autores_01.nacionalidade_autor;
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new AutorMenu(_principal));
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            nome_nacionalidade = txtBoxNacionalidadeAutor.Text;
            pk_id_autor = txtBoxIdAutor.Text;


            try
            {
                //abrindo a conexão
                conectar.Open();
                //objeto de conexao
                SqlCommand Excluir_Autor = new SqlCommand();

                if (pk_id_autor != "0")
                {
                    DialogResult resp = MessageBox.Show("Tem certeza de que deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {

                        Excluir_Autor.CommandText = "delete from Autor where pk_id_autor = " + pk_id_autor;

                        //LOCAL ONDE SERÁ GUARDADO OS DADOS
                        Excluir_Autor.Connection = conectar;

                        //EXECUTAR QUERY
                        Excluir_Autor.ExecuteNonQuery();

                        MessageBox.Show("Exclusão efetuada com sucesso");


                        _principal.OpenChildForm(new AutorMenu(_principal));

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
