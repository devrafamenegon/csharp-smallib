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

namespace Smallib.ChildForms.Cadastros.Cidade
{
    public partial class CidadeNovo : Form
    {
        //Variável para manusear o id 
        int id;

        //Variável para receber o id do ultimo auto incremento de cidade
        string idstring;

        int pk_id_cidade;
        string nome_cidade, estado_cidade;

        Principal _principal;
        public CidadeNovo(Principal principal)
        {
            InitializeComponent();

            _principal = principal;

            //Limitando o tamanho dos campos
            comboBoxEstadoCidade.MaxLength = 2;
            txtBoxNomeCidade.MaxLength = 25;

            try
            {
                //Consultando o ultimo auto incremento de cidade
                conectar.Open();
                SqlCommand obteridcid = new SqlCommand("select last_value from sys.identity_columns where name = 'pk_id_cidade'", conectar);
                idstring = Convert.ToString(obteridcid.ExecuteScalar());
                conectar.Close();

                //Verificando se o valor retornado é nulo
                if (idstring == "")
                {
                    id = 1;
                    txtBoxIdCidade.Text = id.ToString();
                }
                else
                {
                    id = Convert.ToInt32(idstring);
                    id = (id + 1);
                    txtBoxIdCidade.Text = id.ToString();
                }
            }
            catch
            {
                conectar.Close();
                MessageBox.Show("Erro ao consultar ID no banco de dados!!");
            }
            //Colocando o foco na textbox de nome de cidade
            txtBoxNomeCidade.Select();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CidadeMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Armazenando as informações digitadas nos campos em variaveis
            pk_id_cidade = Convert.ToInt32(txtBoxIdCidade.Text);
            nome_cidade = txtBoxNomeCidade.Text;
            estado_cidade = comboBoxEstadoCidade.Text;

            //Verificando se os campos estão preenchidos
            if (nome_cidade != "" && estado_cidade != "")
            {

                //Verificando se a cidade ja existe no banco
                conectar.Open();
                SqlCommand verificar = new SqlCommand("Select * from Cidade where nome_cidade = '" + nome_cidade + "' and estado_cidade = '" + estado_cidade + "'", conectar);
                bool resultado = verificar.ExecuteReader().HasRows;
                conectar.Close();

                //Caso ja exista
                if (resultado == true)
                {
                    MessageBox.Show("Essa cidade já existe no banco de dados!!");
                }
                //Caso não exista
                else
                {
                    try
                    {
                        //Criando uma nova cidade no banco de dados 
                        conectar.Open();
                        SqlCommand cadastrarcidade = new SqlCommand("insert into Cidade(nome_cidade, estado_cidade) values (@nomecidade, @estadocidade)", conectar);
                        cadastrarcidade.Parameters.Add(new SqlParameter("@nomecidade", nome_cidade));
                        cadastrarcidade.Parameters.Add(new SqlParameter("@estadocidade", estado_cidade));
                        cadastrarcidade.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Cidade criada com sucesso!");
                        //Limpando os campos
                        comboBoxEstadoCidade.Text = "";
                        txtBoxNomeCidade.Text = "";
                        //Colocando o foco na textbox de nome da cidade
                        txtBoxNomeCidade.Focus();
                        //Incrementando o valor do id na tela
                        id += 1;
                        txtBoxIdCidade.Text = id.ToString();

                    }
                    catch
                    {
                        conectar.Close();
                        MessageBox.Show("Erro ao cadastrar cidade no banco de dados!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
                //Colocando o foco na textbox de nome da cidade
                txtBoxNomeCidade.Focus();
            }
        }
    }
}
