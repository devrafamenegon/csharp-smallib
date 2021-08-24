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

namespace Smallib.ChildForms.Cadastros.Tipo_do_Leitor
{
    public partial class TipoMenu : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        //Criando um objeto da classe tipo
        Cadastro_Tipo_Leitor tipo = new Cadastro_Tipo_Leitor();

        Principal _principal;

        void checarLinhasDgv()
        {
            //Verificando se a grade está vazia
            if (dgvTipo.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        void armazenarDadosDasCelulas()
        {
            //Armazenando os dados da linha da célula selecionada
            tipo.pk_id_tipo = Convert.ToInt32(dgvTipo[0, dgvTipo.CurrentRow.Index].Value.ToString());
            tipo.nome_tipo = dgvTipo[1, dgvTipo.CurrentRow.Index].Value.ToString();
        }

        void dadosTipo()
        {
            try
            {
                dados = new SqlDataAdapter("select pk_id_tipo, nome_tipo from Tipo", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvTipo.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            checarLinhasDgv();
        }

        public TipoMenu(Principal principal)
        {
            InitializeComponent();
            dadosTipo();

            _principal = principal;
        }

        private void radioIdTipo_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioNomeTipo_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dadosTipo();

            //Limpando as radiobutton
            radioIdTipo.Checked = false;
            radioNomeTipo.Checked = false;
            metroTxtBoxPesquisar.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Verificando se foi digitado algo na barra de pesquisa
            if (metroTxtBoxPesquisar.Text != "")
            {
                //Verificando se o radio button de id do tipo está selecionado
                if (radioIdTipo.Checked)
                {
                    try
                    {
                        //Consultando os cursos no banco de dados filtrando por id
                        dados = new SqlDataAdapter("select pk_id_tipo, nome_tipo from Tipo where pk_id_tipo Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //Verificando se o radio button de nome do tipo está selecionado
                else if (radioNomeTipo.Checked)
                {
                    try
                    {
                        //Consultando os cursos no banco de dados filtrando por nome
                        dados = new SqlDataAdapter("select pk_id_tipo, nome_tipo from Tipo where nome_tipo Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //Mostrando os cursos na grade
                datb = new DataTable();
                dados.Fill(datb);
                dgvTipo.DataSource = datb;

                checarLinhasDgv();
            }

            else
            {
                MessageBox.Show("Nenhum dado inserido para pesquisa");
                return;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new TipoNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvTipo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new TipoEditar(_principal, tipo));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvTipo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de exclusão passando esses dados 
                _principal.OpenChildForm(new TipoExcluir(_principal, tipo));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvTipo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de consulta passando esses dados 
                _principal.OpenChildForm(new TipoConsultar(_principal, tipo));
            }
        }
    }
}
