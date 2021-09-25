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

namespace Smallib.ChildForms.Cadastros.Editora
{
    public partial class EditoraNovo : Form
    {
        int id;
        string idstring;

        Principal _principal;
        public EditoraNovo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            try
            {
                //Consultando o ultimo auto incremento de editora
                conectar.Open();
                SqlCommand obteridedit = new SqlCommand("select last_value from sys.identity_columns where name = 'pk_id_editora'", conectar);
                idstring = Convert.ToString(obteridedit.ExecuteScalar());
                conectar.Close();

                //Verificando se o valor retornado é nulo
                if (idstring == "")
                {
                    id = 1;
                    txtBoxIdEditora.Text = id.ToString();
                }
                else
                {
                    //Calculando o próximo ID
                    id = Convert.ToInt32(idstring);
                    id = (id + 1);
                    txtBoxIdEditora.Text = id.ToString();
                }

            }
            catch
            {
                conectar.Close();
                MessageBox.Show("Erro ao consultar ID no banco de dados!!");
            }
            txtBoxNomeEditora.Select();

            //Limitando o tamanho dos campos
            txtBoxNomeEditora.MaxLength = 30;
            txtBoxNomeEditora.MaxLength = 50;
            txtBoxSiteEditora.MaxLength = 50;

            try
            {
                //Colocando as cidades cadastradas no banco na combobox de cidade da editora
                SqlDataAdapter cidade = new SqlDataAdapter("select pk_id_cidade, nome_cidade + ' - ' + estado_cidade as 'nome' from Cidade order by nome_cidade", conectar);
                DataTable datb1 = new DataTable();
                cidade.Fill(datb1);
                comboBoxCidadeEditora.DataSource = datb1;
                comboBoxCidadeEditora.ValueMember = "pk_id_cidade";
                comboBoxCidadeEditora.DisplayMember = "nome";
            }
            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
            comboBoxCidadeEditora.SelectedIndex = -1;
        }

        private void comboBoxCidadeEditora_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bloqueando a digitação na combobox de cidade da editora
            e.Handled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new EditoraMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verificando se o campo de nome da editora foi preenchido
            if (txtBoxNomeEditora.Text != "")
            {
                //Verificando se existe algum valor repetido
                conectar.Open();
                SqlCommand verificar = new SqlCommand("Select * from Editora where nome_editora = '" + txtBoxNomeEditora.Text + "' or email_editora = '" + txtBoxEmailEditora.Text + "' or tel_editora = '" + maskedTxtBoxTelefoneEditora.Text + "' or site_editora = '" + txtBoxSiteEditora.Text + "'", conectar);
                bool resultado = verificar.ExecuteReader().HasRows;

                //Caso ja exista
                if (resultado == true)
                {
                    conectar.Close();
                    MessageBox.Show("Existem dados repetidos!!");
                }

                else
                {
                    conectar.Close();

                    //Armazenando as informações digitadas nos campos em variaveis
                    string nomedaeditora;
                    nomedaeditora = txtBoxNomeEditora.Text;

                    string emaildaeditora;
                    emaildaeditora = txtBoxEmailEditora.Text;

                    string telefonedaeditora;
                    telefonedaeditora = maskedTxtBoxTelefoneEditora.Text;

                    string sitedaeditora;
                    sitedaeditora = txtBoxSiteEditora.Text;

                    int cidadedaeditora;
                    if (comboBoxCidadeEditora.Text == "")
                    {
                        cidadedaeditora = 0;
                    }
                    else
                    {
                        cidadedaeditora = Convert.ToInt32(comboBoxCidadeEditora.SelectedValue);
                    }


                    try
                    {
                        //Criando uma nova editora no banco de dados
                        conectar.Open();
                        SqlCommand cadastrareditora = new SqlCommand("insert into Editora(nome_editora, email_editora, tel_editora, site_editora, fk_id_cidade_editora) values (nullif(@nomedaeditora, ''), nullif(@emaildaeditora, ''), nullif(@telefonedaeditora, '(  )     -    '), nullif(@sitedaeditora,''), nullif(@cidadedaeditora, 0))", conectar);
                        cadastrareditora.Parameters.Add(new SqlParameter("@nomedaeditora", nomedaeditora));
                        cadastrareditora.Parameters.Add(new SqlParameter("@emaildaeditora", emaildaeditora));
                        cadastrareditora.Parameters.Add(new SqlParameter("@telefonedaeditora", telefonedaeditora));
                        cadastrareditora.Parameters.Add(new SqlParameter("@sitedaeditora", sitedaeditora));
                        cadastrareditora.Parameters.Add(new SqlParameter("@cidadedaeditora", cidadedaeditora));
                        cadastrareditora.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Editora criada com sucesso!");

                        //Limpando os campos
                        txtBoxNomeEditora.Text = "";
                        txtBoxEmailEditora.Text = "";
                        maskedTxtBoxTelefoneEditora.Text = "";
                        txtBoxSiteEditora.Text = "";
                        comboBoxCidadeEditora.SelectedIndex = -1;

                        //Colocando o foco na textbox de nome da editora
                        txtBoxNomeEditora.Focus();

                        //Calculando o próximo ID
                        id += 1;
                        txtBoxIdEditora.Text = id.ToString();

                    }
                    catch
                    {
                        conectar.Close();
                        MessageBox.Show("Erro ao cadastrar editora no banco de dados!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha ao menos o nome da editora");
            }
        }
    }
}
