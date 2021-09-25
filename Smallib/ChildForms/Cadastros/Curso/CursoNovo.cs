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

namespace Smallib.ChildForms.Cadastros.Curso
{
    public partial class CursoNovo : Form
    {
        int pk_id_curso, id;
        string nome_curso, idstring;

        Principal _principal;
        public CursoNovo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            try
            {
                //Consultando o ultimo auto incremento de curso
                conectar.Open();
                SqlCommand obteridcurso = new SqlCommand("select last_value from sys.identity_columns where name = 'pk_id_curso'", conectar);
                idstring = Convert.ToString(obteridcurso.ExecuteScalar());

                //Verificando se o valor retornado é nulo
                if (idstring == "")
                {
                    id = 1;
                    txtBoxIdCurso.Text = id.ToString();
                }
                else
                {
                    //Calculando o próximo ID
                    id = Convert.ToInt32(idstring);
                    id = (id + 1);
                    txtBoxIdCurso.Text = id.ToString();
                }
                conectar.Close();
            }
            catch
            {
                conectar.Close();
                MessageBox.Show("Erro ao consultar ID no banco de dados!!");
            }
            txtBoxNomeCurso.Select();

            //Limitando o tamanho do campo nome do curso
            txtBoxNomeCurso.MaxLength = 30;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CursoMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pk_id_curso = Convert.ToInt32(txtBoxIdCurso.Text);
            nome_curso = txtBoxNomeCurso.Text;

            //Verificando se o campo de nome do curso foi preenchido
            if (txtBoxNomeCurso.Text != "")
            {
                //Verificando se valor ja existe
                conectar.Open();
                SqlCommand verificar = new SqlCommand("Select * from Curso where nome_curso = '" + nome_curso + "'", conectar);
                bool resultado = verificar.ExecuteReader().HasRows;
                conectar.Close();

                //Caso ja exista
                if (resultado == true)
                {
                    MessageBox.Show("Este curso já está cadastrado!!");
                }

                else
                {
                    try
                    {
                        //Criando um novo curso no banco de dados
                        conectar.Open();
                        SqlCommand cadastrarcurso = new SqlCommand("insert into Curso(nome_curso) values (@nomedocurso)", conectar);
                        cadastrarcurso.Parameters.Add(new SqlParameter("@nomedocurso", nome_curso));
                        cadastrarcurso.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Curso criado com sucesso!");

                        //Limpando o campo
                        txtBoxNomeCurso.Text = "";

                        //Colocando o foco na textbox de nome do curso
                        txtBoxNomeCurso.Focus();

                        //Calculando o próximo ID
                        id += 1;
                        txtBoxIdCurso.Text = id.ToString();

                    }
                    catch
                    {
                        conectar.Close();
                        MessageBox.Show("Erro ao cadastrar curso no banco de dados!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome do curso");
            }
        }
       
    }
}
