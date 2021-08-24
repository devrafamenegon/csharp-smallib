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
using Smallib.ChildForms.Cadastros.Relatorios;

namespace Smallib.ChildForms.Cadastros.Cidade
{
    public partial class CidadeMenu : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        //Criando um objeto da classe cidade
        Cadastro_Cidade cidade = new Cadastro_Cidade();

        Principal _principal;

        void checarLinhasDgv()
        {
            //Verificando se a grade está vazia
            if (dgvCidade.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        void dadosCidade()
        {
            try
            {
                //Consultando as cidades no banco de dados
                dados = new SqlDataAdapter("select pk_id_cidade, nome_cidade, estado_cidade from Cidade", conectar);
                //Mostrando as cidades na grade
                datb = new DataTable();
                dados.Fill(datb);

                //Mostrando os cursos na grade
                dgvCidade.DataSource = datb;
                dgvCidade.Refresh();

                checarLinhasDgv();
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        void armazenarDadosDasCelulas()
        {
            //Armazenando os dados da linha da célula selecionada
            cidade.pk_id_cidade = Convert.ToInt32(dgvCidade[0, dgvCidade.CurrentRow.Index].Value.ToString());
            cidade.nome_cidade = dgvCidade[1, dgvCidade.CurrentRow.Index].Value.ToString();
            cidade.estado_cidade = dgvCidade[2, dgvCidade.CurrentRow.Index].Value.ToString();
        }

        public CidadeMenu(Principal principal)
        {
            InitializeComponent();
            dadosCidade();

            _principal = principal;
        }

        private void radioIdCidade_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioNomeCidade_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioEstadoCidade_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Chamando a função que consulta as cidades no banco de dados e os mostra na grade
            dadosCidade();

            //Limpando o campo de pesquisa e a seleção nos radiobutton
            radioIdCidade.Checked = false;
            radioNomeCidade.Checked = false;
            radioEstadoCidade.Checked = false;
            metroTxtBoxPesquisar.Clear();

            checarLinhasDgv();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Verificando se o campo de pesquisa não está vazio
            if (metroTxtBoxPesquisar.Text != "")
            {
                //Verificando se o radiobutton de id da cidade está selecionado
                if (radioIdCidade.Checked)
                {
                    try
                    {
                        //Consultando as cidades no banco de dados filtrando por ID
                        dados = new SqlDataAdapter("select pk_id_cidade, nome_cidade, estado_cidade from Cidade where pk_id_cidade Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //Verificando se o radiobutton de nome da cidade está selecionado
                else if (radioNomeCidade.Checked)
                {
                    try
                    {
                        //Consultando as cidades no banco de dados filtrando por nome
                        dados = new SqlDataAdapter("select pk_id_cidade, nome_cidade, estado_cidade from Cidade where nome_cidade Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //Verificando se o radiobutton de estado da cidade está selecionado
                else if (radioEstadoCidade.Checked)
                {
                    try
                    {
                        //Consultando as cidades no banco de dados filtrando por nome
                        dados = new SqlDataAdapter("select pk_id_cidade, nome_cidade, estado_cidade from Cidade where estado_cidade Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //Mostrando as cidades na grade
                datb = new DataTable();
                dados.Fill(datb);
                dgvCidade.DataSource = datb;

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
            _principal.OpenChildForm(new CidadeNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvCidade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new CidadeEditar(_principal, cidade));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvCidade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new CidadeExcluir(_principal, cidade));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvCidade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new CidadeConsultar(_principal, cidade));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelatorioCidade(_principal));
        }
    }
}
