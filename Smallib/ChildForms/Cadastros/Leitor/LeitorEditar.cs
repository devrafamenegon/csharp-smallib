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
    public partial class LeitorEditar : Form
    {
        int pk_id_leitor_global;
        string nome_leitor;
        string email_leitor;
        string tel_leitor;
        string rg_leitor;
        DateTime dtnascleitor;
        DateTime dtcadleitor;
        string cidade_leitor;
        string estado_leitor;
        string tipo_leitor;
        string classe_leitor;
        string status_leitor;
        string curso_leitor;

        //Variavel para armazenar a cidade e o estado concatenados
        string cidade_estado_concat;

        Principal _principal;

        public LeitorEditar(Principal principal, Cadastro_Leitor cadastro_leitor_01)
        {
            InitializeComponent();
            _principal = principal;

            pk_id_leitor_global = cadastro_leitor_01.pk_id_leitor;
            nome_leitor = cadastro_leitor_01.nome_leitor;
            email_leitor = cadastro_leitor_01.email_leitor;
            tel_leitor = cadastro_leitor_01.tel_cel_leitor;
            rg_leitor = cadastro_leitor_01.rg_leitor;
            dtnascleitor = cadastro_leitor_01.dtnasc_leitor;
            dtcadleitor = cadastro_leitor_01.dtcad_leitor;
            cidade_leitor = cadastro_leitor_01.cidade_leitor;
            tipo_leitor = cadastro_leitor_01.tipo_leitor;
            classe_leitor = cadastro_leitor_01.classe_leitor;
            estado_leitor = cadastro_leitor_01.estado_leitor;
            status_leitor = cadastro_leitor_01.status_leitor;
            curso_leitor = cadastro_leitor_01.curso_leitor;
            txtBoxNomeLeitor.Text = nome_leitor;
            txtBoxEmailLeitor.Text = email_leitor;
            txtBoxTelefoneLeitor.Text = tel_leitor;
            txtBoxRgLeitor.Text = rg_leitor;
            txtBoxDataNascLeitor.Text = dtnascleitor.ToShortDateString();
            txtBoxDataAttLeitor.Text = dtcadleitor.ToShortDateString();
            comboBoxTipoLeitor.Text = tipo_leitor;
            txtBoxStatusLeitor.Text = status_leitor;
            txtBoxIdLeitor.Text = pk_id_leitor_global.ToString();

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
            comboBoxCursoLeitor.Text = curso_leitor;
            cidade_estado_concat = cidade_leitor + " - " + estado_leitor;
            comboBoxCidadeLeitor.Text = cidade_estado_concat;
            comboBoxTipoLeitor.Text = tipo_leitor;
            comboBoxClasseLeitor.Text = classe_leitor;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LeitorMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtBoxNomeLeitor.Text == nome_leitor && txtBoxEmailLeitor.Text == email_leitor && txtBoxTelefoneLeitor.Text == tel_leitor && txtBoxRgLeitor.Text == rg_leitor && txtBoxDataNascLeitor.Text == dtnascleitor.ToShortDateString() && txtBoxDataAttLeitor.Text == dtcadleitor.ToShortDateString() && comboBoxCidadeLeitor.Text == cidade_estado_concat && comboBoxTipoLeitor.Text == tipo_leitor && comboBoxClasseLeitor.Text == classe_leitor && comboBoxCursoLeitor.Text == curso_leitor)
            {
                _principal.OpenChildForm(new LeitorMenu(_principal));
            }
            else
            {
                //Verificando se os campos obrigatórios não estão vazios
                if (txtBoxNomeLeitor.Text != "" && txtBoxRgLeitor.Text != "" && txtBoxDataNascLeitor.MaskCompleted && comboBoxCidadeLeitor.Text != "" && comboBoxTipoLeitor.Text != "")
                {
                    //Verificando se existem dados repetidos
                    if (txtBoxNomeLeitor.Text != nome_leitor)
                    {
                        try
                        {
                            conectar.Open();
                            SqlCommand verificar = new SqlCommand("Select * from Leitor where nome_leitor = '" + txtBoxNomeLeitor.Text + "'", conectar);
                            bool resultado = verificar.ExecuteReader().HasRows;
                            conectar.Close();

                            if (resultado == true)
                            {
                                MessageBox.Show("Existem dados repetidos!!");
                                return;
                            }
                        }
                        catch
                        {
                            conectar.Close();
                            MessageBox.Show("Erro realizar verificação!!");
                            return;
                        }
                    }

                    //Verificando se existem dados repetidos
                    if (txtBoxRgLeitor.Text != rg_leitor)
                    {
                        try
                        {
                            conectar.Open();
                            SqlCommand verificar = new SqlCommand("Select * from Leitor where rg_leitor = '" + txtBoxRgLeitor.Text + "'", conectar);
                            bool resultado = verificar.ExecuteReader().HasRows;
                            conectar.Close();

                            if (resultado == true)
                            {
                                MessageBox.Show("Existem dados repetidos!!");
                                return;
                            }
                        }
                        catch
                        {
                            conectar.Close();
                            MessageBox.Show("Erro realizar verificação!!");
                            return;
                        }
                    }


                    int idleitor;
                    string nomedoleitor;
                    string emaildoleitor;
                    string teldoleitor;
                    string rgdoleitor;
                    string dtnascdoleitor;
                    string dtattdoleitor;
                    int cidadedoleitor;
                    int tipodoleitor;
                    string classedoleitor;
                    int cursodoleitor;

                    idleitor = pk_id_leitor_global;
                    nomedoleitor = txtBoxNomeLeitor.Text;
                    emaildoleitor = txtBoxEmailLeitor.Text;
                    teldoleitor = txtBoxTelefoneLeitor.Text;
                    rgdoleitor = txtBoxRgLeitor.Text;
                    dtnascdoleitor = txtBoxDataNascLeitor.Text;
                    DateTime dataHoraAtual = DateTime.Now;
                    dtattdoleitor = dataHoraAtual.ToShortDateString();
                    cidadedoleitor = Convert.ToInt32(comboBoxCidadeLeitor.SelectedValue);
                    tipodoleitor = Convert.ToInt32(comboBoxTipoLeitor.SelectedValue);
                    cursodoleitor = Convert.ToInt32(comboBoxCursoLeitor.SelectedValue);
                    classedoleitor = comboBoxClasseLeitor.Text;

                    try
                    {
                        //Alterando a cidade no banco de dados
                        conectar.Open();
                        SqlCommand editarleitor = new SqlCommand("update Leitor set nome_leitor=(@nomedoleitor), email_leitor= nullif(@emaildoleitor, ''), tel_cel_leitor=nullif(@teldoleitor, '(  )     -    '), rg_leitor=(@rgdoleitor), dtnasc_leitor=(@dtnascdoleitor), dtcad_leitor=(@dtcaddoleitor), fk_id_cidade_leitor=(@cidadedoleitor), fk_id_tipo_leitor=(@tipodoleitor), classe_leitor= nullif(@classedoleitor, ''), fk_id_curso_leitor = nullif(@cursodoleitor, 0) where pk_id_leitor=(@idleitor)", conectar);
                        editarleitor.Parameters.Add(new SqlParameter("@idleitor", idleitor));
                        editarleitor.Parameters.Add(new SqlParameter("@nomedoleitor", nomedoleitor));
                        editarleitor.Parameters.Add(new SqlParameter("@emaildoleitor", emaildoleitor));
                        editarleitor.Parameters.Add(new SqlParameter("@teldoleitor", teldoleitor));
                        editarleitor.Parameters.Add(new SqlParameter("@rgdoleitor", rgdoleitor));
                        editarleitor.Parameters.Add(new SqlParameter("@dtnascdoleitor", dtnascdoleitor));
                        editarleitor.Parameters.Add(new SqlParameter("@dtcaddoleitor", dtattdoleitor));
                        editarleitor.Parameters.Add(new SqlParameter("@cidadedoleitor", cidadedoleitor));
                        editarleitor.Parameters.Add(new SqlParameter("@tipodoleitor", tipodoleitor));
                        editarleitor.Parameters.Add(new SqlParameter("@classedoleitor", classedoleitor));
                        editarleitor.Parameters.Add(new SqlParameter("@cursodoleitor", cursodoleitor));
                        editarleitor.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Leitor alterado com sucesso");

                        _principal.OpenChildForm(new LeitorMenu(_principal));
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
                            MessageBox.Show("Erro ao alterar algum atributo no banco de dados!!");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Existem campos que não podem ser vazios e/ou não podem ser incompletos");
                }
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

        private void comboBoxTipoLeitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bloqueando a digitação na combobox de tipo de leitor
            e.Handled = true;
        }

        private void comboBoxCursoLeitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bloqueando a digitação na combobox de tipo de leitor
            e.Handled = true;
        }

        private void comboBoxClasseLeitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bloqueando a digitação na combobox de tipo de leitor
            e.Handled = true;
        }
    }
}
