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
    public partial class EditoraEditar : Form
    {
        //Variáveis para armazenar os valores da linha selecionada na tela principal
        string nome_editora, email_editora, tel_editora, site_editora, cidade_editora_global, estado_editora_global;

        int pk_id_editora;

        //Variavel para armazenar a cidade e o estado concatenados
        string cidade_estado_editora;

        Principal _principal;
        public EditoraEditar(Principal principal, Cadastro_Editora cadastro_editora_01)
        {
            InitializeComponent();

            _principal = principal;

            //Recuperando os dados da linha selecionada na tela principal
            pk_id_editora = cadastro_editora_01.pk_id_editora;
            txtBoxIdEditora.Text = pk_id_editora.ToString();

            txtBoxNomeEditora.Text = cadastro_editora_01.nome_editora;
            nome_editora = txtBoxNomeEditora.Text;

            txtBoxEmailEditora.Text = cadastro_editora_01.email_editora;
            email_editora = txtBoxEmailEditora.Text;

            maskedTxtBoxTelefoneEditora.Text = cadastro_editora_01.tel_editora;
            tel_editora = maskedTxtBoxTelefoneEditora.Text;

            txtBoxSiteEditora.Text = cadastro_editora_01.site_editora;
            site_editora = txtBoxSiteEditora.Text;

            cidade_editora_global = cadastro_editora_01.nome_cidade;
            estado_editora_global = cadastro_editora_01.estado_cidade;

            //Limitando o tamanho dos campos
            txtBoxNomeEditora.MaxLength = 30;
            txtBoxEmailEditora.MaxLength = 50;
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

            //Verificando se a cidade não é nula
            if (cidade_editora_global != "")
            {
                cidade_estado_editora = cidade_editora_global + " - " + estado_editora_global;

            }
            //Caso for nula
            else
            {
                cidade_estado_editora = "";
            }
            comboBoxCidadeEditora.Text = cidade_estado_editora;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new EditoraMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verificando se algo foi alterado
            if (txtBoxNomeEditora.Text == nome_editora && maskedTxtBoxTelefoneEditora.Text == tel_editora && txtBoxEmailEditora.Text == email_editora && txtBoxSiteEditora.Text == site_editora && comboBoxCidadeEditora.Text == cidade_estado_editora)
            {
                _principal.OpenChildForm(new EditoraMenu(_principal));
            }
            else
            {
                //Verificando se o campo de nome da editora foi preenchido
                if (txtBoxNomeEditora.Text != "")
                {
                    //Verificando se existem dados repetidos
                    if (txtBoxNomeEditora.Text != nome_editora)
                    {
                        try
                        {
                            conectar.Open();
                            SqlCommand verificar = new SqlCommand("Select * from Editora where nome_editora = '" + txtBoxNomeEditora.Text + "'", conectar);
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
                    if (txtBoxEmailEditora.Text != email_editora)
                    {
                        try
                        {
                            conectar.Open();
                            SqlCommand verificar = new SqlCommand("Select * from Editora where email_editora = '" + txtBoxEmailEditora.Text + "'", conectar);
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
                    if (maskedTxtBoxTelefoneEditora.Text != tel_editora)
                    {
                        try
                        {
                            conectar.Open();
                            SqlCommand verificar = new SqlCommand("Select * from Editora where tel_editora = '" + maskedTxtBoxTelefoneEditora.Text + "'", conectar);
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
                    if (txtBoxSiteEditora.Text != site_editora)
                    {
                        try
                        {
                            conectar.Open();
                            SqlCommand verificar = new SqlCommand("Select * from Editora where site_editora = '" + txtBoxSiteEditora.Text + "'", conectar);
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

                    //Armazenando as informações digitadas nos campos em variaveis
                    nome_editora = txtBoxNomeEditora.Text;
                    email_editora = txtBoxEmailEditora.Text;
                    tel_editora = maskedTxtBoxTelefoneEditora.Text;
                    site_editora = txtBoxSiteEditora.Text;

                    int cidade_editora;
                    if (comboBoxCidadeEditora.Text == "")
                    {
                        cidade_editora = 0;
                    }
                    else
                    {
                        cidade_editora = Convert.ToInt32(comboBoxCidadeEditora.SelectedValue);
                    }

                    try
                    {
                        //Editando uma editora no banco de dados
                        conectar.Open();
                        SqlCommand editareditora = new SqlCommand("update Editora set nome_editora = nullif(@nomedaeditora, ''), email_editora = nullif(@emaildaeditora, ''), tel_editora = nullif(@telefonedaeditora, '(  )     -    '), site_editora = nullif(@sitedaeditora,''), fk_id_cidade_editora = nullif(@cidadedaeditora, '') where pk_id_editora=(@iddaeditora)", conectar);
                        editareditora.Parameters.Add(new SqlParameter("@nomedaeditora", nome_editora));
                        editareditora.Parameters.Add(new SqlParameter("@emaildaeditora", email_editora));
                        editareditora.Parameters.Add(new SqlParameter("@telefonedaeditora", tel_editora));
                        editareditora.Parameters.Add(new SqlParameter("@sitedaeditora", site_editora));
                        editareditora.Parameters.Add(new SqlParameter("@cidadedaeditora", cidade_editora));
                        editareditora.Parameters.Add(new SqlParameter("@iddaeditora", pk_id_editora));
                        editareditora.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Editora editada com sucesso!");
                        
                        //Abrindo a tela principal
                        _principal.OpenChildForm(new EditoraMenu(_principal));
                    }
                    catch (SqlException ex)
                    {
                        conectar.Close();
                        MessageBox.Show("Não foi possivel conectar-se ao banco de dados" + Convert.ToString(ex));
                    }
                }
                else
                {
                    MessageBox.Show("Preencha ao menos o nome da editora");
                }
            }
        }

    }
}
