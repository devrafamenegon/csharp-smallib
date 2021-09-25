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

namespace Smallib.ChildForms.Cadastros.Leitores
{
    public partial class LeitorNovo : Form
    {
        //Variáveis para manipular o id
        int id;
        string idstring;

        //Variável para manipular a data de atualização
        DateTime dataHoraAtual;
        string dataAtual;

        Principal _principal;

        public LeitorNovo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            try
            {
                //Consultando o ultimo auto incremento de leitor
                conectar.Open();
                SqlCommand obteridleit = new SqlCommand("select last_value from sys.identity_columns where name = 'pk_id_leitor'", conectar);
                idstring = Convert.ToString(obteridleit.ExecuteScalar());
                conectar.Close();

                //Verificando se o valor retornado é nulo
                if (idstring == "")
                {
                    id = 1;
                    txtBoxIdLeitor.Text = id.ToString();
                }
                else
                {
                    //Calculando o próximo ID
                    id = Convert.ToInt32(idstring);
                    id = (id + 1);
                    txtBoxIdLeitor.Text = id.ToString();
                }
            }
            catch
            {
                conectar.Close();
                MessageBox.Show("Erro ao consultar ID no banco de dados!!");
            }

            txtBoxNomeLeitor.Select();

            //Limitando o tamanho dos campos
            txtBoxNomeLeitor.MaxLength = 50;
            txtBoxEmailLeitor.MaxLength = 50;
            txtBoxRgLeitor.MaxLength = 12;
            comboBoxClasseLeitor.MaxLength = 10;

            try
            {
                //Colocando as cidades cadastradas no banco na combobox de cidade do leitor
                SqlDataAdapter cidade = new SqlDataAdapter("select pk_id_cidade, nome_cidade + ' - ' + estado_cidade as 'nome' from Cidade order by nome_cidade", conectar);
                DataTable datb1 = new DataTable();
                cidade.Fill(datb1);
                comboBoxCidadeLeitor.DataSource = datb1;
                comboBoxCidadeLeitor.ValueMember = "pk_id_cidade";
                comboBoxCidadeLeitor.DisplayMember = "nome";
            }
            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
            comboBoxCidadeLeitor.SelectedIndex = -1;

            try
            {
                //Colocando os tipos cadastrados no banco na combobox de tipo do leitor
                SqlDataAdapter tipo = new SqlDataAdapter("select pk_id_tipo, nome_tipo from Tipo order by nome_tipo", conectar);
                DataTable datb1 = new DataTable();
                tipo.Fill(datb1);
                comboBoxTipoLeitor.DataSource = datb1;
                comboBoxTipoLeitor.ValueMember = "pk_id_tipo";
                comboBoxTipoLeitor.DisplayMember = "nome_tipo";
            }
            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
            comboBoxTipoLeitor.SelectedIndex = -1;

            try
            {
                //Colocando os tipos cadastrados no banco na combobox de curso do leitor
                SqlDataAdapter tipo = new SqlDataAdapter("select pk_id_curso, nome_curso from Curso order by nome_curso", conectar);
                DataTable datb1 = new DataTable();
                tipo.Fill(datb1);
                comboBoxCursoLeitor.DataSource = datb1;
                comboBoxCursoLeitor.ValueMember = "pk_id_curso";
                comboBoxCursoLeitor.DisplayMember = "nome_curso";
            }
            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }

            comboBoxCursoLeitor.SelectedIndex = -1;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LeitorMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verificando se os campos obrigatórios não estão vazios
            if (txtBoxNomeLeitor.Text != "" && txtBoxRgLeitor.Text != "" && txtBoxDataNascLeitor.MaskCompleted && comboBoxCidadeLeitor.Text != "" && comboBoxTipoLeitor.Text != "")
            {
                //Verificando se existe algum valor repetido
                conectar.Open();
                SqlCommand verificar = new SqlCommand("Select * from Leitor where nome_leitor = '" + txtBoxNomeLeitor.Text + "' or rg_leitor = '" + txtBoxRgLeitor.Text + "'", conectar);
                bool resultado = verificar.ExecuteReader().HasRows;
                conectar.Close();

                //Caso ja exista
                if (resultado == true)
                {
                    MessageBox.Show("Existem dados repetidos!!");
                }

                else
                {
                    //Armazenando as informações digitadas nos campos em variaveis
                    string nomedoleitor;
                    nomedoleitor = txtBoxNomeLeitor.Text;

                    string emaildoleitor;
                    emaildoleitor = txtBoxEmailLeitor.Text;

                    string telefonedoleitor;
                    telefonedoleitor = txtBoxTelefoneLeitor.Text;

                    string rgdoleitor;
                    rgdoleitor = txtBoxRgLeitor.Text;

                    string datanascleitor;
                    datanascleitor = txtBoxDataNascLeitor.Text; ;


                    string dataattleitor;
                    dataattleitor = dataAtual;

                    int cidadedoleitor;
                    cidadedoleitor = Convert.ToInt32(comboBoxCidadeLeitor.SelectedValue);

                    int tipodoleitor;
                    tipodoleitor = Convert.ToInt32(comboBoxTipoLeitor.SelectedValue);

                    int cursodoleitor;
                    cursodoleitor = Convert.ToInt32(comboBoxCursoLeitor.SelectedValue);

                    string classedoleitor;
                    classedoleitor = comboBoxClasseLeitor.Text;

                    try
                    {
                        //Criando um novo leitor no banco de dados
                        conectar.Open();
                        SqlCommand cadastrarleitor = new SqlCommand("insert into Leitor(nome_leitor, email_leitor, tel_cel_leitor, rg_leitor, dtnasc_leitor, dtcad_leitor, fk_id_cidade_leitor, fk_id_tipo_leitor, classe_leitor, status_leitor, fk_id_curso_leitor) values (@nomedoleitor, nullif(@emaildoleitor, ''), nullif(@telefonedoleitor, '(  )     -    '), @rgdoleitor, @datanascleitor, @datacadleitor, @cidadedoleitor, @tipodoleitor, nullif(@classedoleitor, ''), 0, nullif(@cursodoleitor, ''))", conectar);
                        cadastrarleitor.Parameters.Add(new SqlParameter("@nomedoleitor", nomedoleitor));
                        cadastrarleitor.Parameters.Add(new SqlParameter("@emaildoleitor", emaildoleitor));
                        cadastrarleitor.Parameters.Add(new SqlParameter("@telefonedoleitor", telefonedoleitor));
                        cadastrarleitor.Parameters.Add(new SqlParameter("@rgdoleitor", rgdoleitor));
                        cadastrarleitor.Parameters.Add(new SqlParameter("@datanascleitor", datanascleitor));
                        cadastrarleitor.Parameters.Add(new SqlParameter("@datacadleitor", dataattleitor));
                        cadastrarleitor.Parameters.Add(new SqlParameter("@cidadedoleitor", cidadedoleitor));
                        cadastrarleitor.Parameters.Add(new SqlParameter("@tipodoleitor", tipodoleitor));
                        cadastrarleitor.Parameters.Add(new SqlParameter("@classedoleitor", classedoleitor));
                        cadastrarleitor.Parameters.Add(new SqlParameter("@cursodoleitor", cursodoleitor));
                        cadastrarleitor.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Leitor criado com sucesso!");
                        comboBoxClasseLeitor.Enabled = false;
                        comboBoxCursoLeitor.Enabled = false;
                        //Limpando os campos
                        txtBoxNomeLeitor.Text = "";
                        txtBoxEmailLeitor.Text = "";
                        txtBoxTelefoneLeitor.Text = "";
                        txtBoxDataAttLeitor.Text = dataattleitor;
                        txtBoxDataNascLeitor.Text = "";
                        txtBoxRgLeitor.Text = "";
                        comboBoxCidadeLeitor.Text = "";
                        comboBoxTipoLeitor.Text = "";
                        comboBoxClasseLeitor.Text = "";
                        comboBoxCursoLeitor.SelectedValue = 0;

                        //Colocando o foco na textbox de nome do leitor
                        txtBoxNomeLeitor.Focus();

                        //Calculando o próximo ID
                        id += 1;
                        txtBoxIdLeitor.Text = id.ToString();

                    }

                    catch (SqlException ex)
                    {
                        conectar.Close();
                        if (ex != null && ex.Number == 241)
                        {
                            MessageBox.Show("Digite uma data de nascimento válida!");

                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar leitor no banco de dados!!");
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Existem campos que não podem ser vazios e/ou não podem ser incompletos");
            }
        }

        private void comboBoxTipoLeitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoLeitor.Text == "Aluno")
            {
                comboBoxClasseLeitor.Enabled = true;
                comboBoxCursoLeitor.Enabled = true;
            }
            else
            {
                comboBoxClasseLeitor.Enabled = false;
                comboBoxCursoLeitor.Enabled = false;
                comboBoxCursoLeitor.SelectedValue = 0;
                comboBoxClasseLeitor.Text = "";
            }
        }

        private void timerToDate_Tick(object sender, EventArgs e)
        {
            dataHoraAtual = DateTime.Now;
            dataAtual = dataHoraAtual.ToShortDateString();
            txtBoxDataAttLeitor.Text = dataAtual;
        }
    }
}
