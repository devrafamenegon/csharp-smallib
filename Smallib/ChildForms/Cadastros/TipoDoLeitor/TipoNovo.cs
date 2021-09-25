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

namespace Smallib.ChildForms.Cadastros.Tipo_do_Leitor
{
    public partial class TipoNovo : Form
    {
        int pk_id_tipo, id;
        string nome_tipo, idstring;

        Principal _principal;
        public TipoNovo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            try
            {
                //Consultando o ultimo auto incremento de tipo
                conectar.Open();
                SqlCommand obteridcurso = new SqlCommand("select last_value from sys.identity_columns where name = 'pk_id_tipo'", conectar);
                idstring = Convert.ToString(obteridcurso.ExecuteScalar());

                //Verificando se o valor retornado é nulo
                if (idstring == "")
                {
                    id = 1;
                    txtBoxIdTipo.Text = id.ToString();
                }
                else
                {
                    //Calculando o próximo ID
                    id = Convert.ToInt32(idstring);
                    id = (id + 1);
                    txtBoxIdTipo.Text = id.ToString();
                }
                conectar.Close();
            }
            catch
            {
                conectar.Close();
                MessageBox.Show("Erro ao consultar ID no banco de dados!!");
            }
            txtBoxNomeTipo.Select();

            //Limitando o tamanho do campo nome do tipo
            txtBoxNomeTipo.MaxLength = 30;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new TipoMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pk_id_tipo = Convert.ToInt32(txtBoxIdTipo.Text);
            nome_tipo = txtBoxNomeTipo.Text;

            //Verificando se o campo de nome do tipo foi preenchido
            if (txtBoxNomeTipo.Text != "")
            {
                //Verificando se valor ja existe
                conectar.Open();
                SqlCommand verificar = new SqlCommand("Select * from Tipo where nome_tipo = '" + nome_tipo + "'", conectar);
                bool resultado = verificar.ExecuteReader().HasRows;
                conectar.Close();

                //Caso ja exista
                if (resultado == true)
                {
                    MessageBox.Show("Este tipo já está cadastrado!!");
                }

                else
                {
                    try
                    {
                        //Criando um novo tipo no banco de dados
                        conectar.Open();

                        SqlCommand cadastrartipo = new SqlCommand("insert into Tipo(nome_tipo) values (@nomedotipo)", conectar);
                        cadastrartipo.Parameters.Add(new SqlParameter("@nomedotipo", nome_tipo));
                        cadastrartipo.ExecuteNonQuery();
                        conectar.Close();

                        MessageBox.Show("Tipo de leitor criado com sucesso!");

                        //Limpando o campo
                        txtBoxNomeTipo.Text = "";

                        //Colocando o foco na textbox de nome do tipo
                        txtBoxNomeTipo.Focus();

                        //Calculando o próximo ID
                        id += 1;
                        txtBoxIdTipo.Text = id.ToString();
                    }

                    catch
                    {
                        conectar.Close();
                        MessageBox.Show("Erro ao cadastrar tipo de leitor no banco de dados!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome do tipo");
            }
        }
    }
}
