using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static Smallib.Program;

namespace Smallib.ChildForms.Cadastros.Cidade
{
    public partial class CidadeMenu : Form
    {
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

            try
            {
                dados = new SqlDataAdapter("select pk_id_cidade, nome_cidade, estado_cidade from Cidade order by pk_id_cidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvCidade.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioNomeCidade_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select pk_id_cidade, nome_cidade, estado_cidade from Cidade order by nome_cidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvCidade.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioEstadoCidade_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select pk_id_cidade, nome_cidade, estado_cidade from Cidade order by estado_cidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvCidade.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Chamando a função que consulta as cidades no banco de dados e os mostra na grade
            dadosCidade();

            //Limpando o campo de pesquisa e a seleção nos radiobutton
            radioIdCidade.Checked = true;
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

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                //verificando se a pasta pdf existe
                string path = @"c:\pdf";
                if (Directory.Exists(path) == false)
                {
                    //criando pasta pdf
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }

                //lugar onde o relatorio pfd vai ficar
                string caminho = @"C:\pdf\" + DateTime.Now.ToString("yyyyMMdd") + "_RelatorioCidade_SmallLibrary.pdf";

                //Criação do documento
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                /*
                string caminho = System.Environment.CurrentDirectory; //cria o caminho com o PATH do diretório atual
                string nomearquivo = caminho + @"\relatoriogenero.pdf"; //nome do documento e caminho (no momento, o PDF é criado dentro de bin\debug)
                FileStream arquivoPDF = new FileStream(nomearquivo, FileMode.Create); //Diz o modo do arquivo
                Document doc = new Document(PageSize.A4); //Criação do documento
                PdfWriter escritorpdf = PdfWriter.GetInstance(doc, arquivoPDF); //Criação do escritor de pdf
                */

                // Parte dos paragrafos
                string dados = "";

                //small library
                Paragraph smallibrary = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold)); //Criação do objeto paragrafo, com fonte normal, 14, em negrito
                smallibrary.Alignment = Element.ALIGN_RIGHT; //Alinha o conteudo a direita
                smallibrary.Add("\n SISTEMA SMALL LIBRARY");

                //cabeçalho
                Paragraph cabecalho = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14));
                cabecalho.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                cabecalho.Add("\n RELAÇÃO DE CIDADES");

                //separador de linha
                Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                //Classificação
                Paragraph classificacao = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
                classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                classificacao.Add("Classificação: Identificação da Cidade \n\n");

                //Tabela
                PdfPTable table = new PdfPTable(3);
                table.DefaultCell.FixedHeight = 20;
                table.WidthPercentage = 100;

                table.AddCell("ID da Cidade");
                table.AddCell("Nome da Cidade");
                table.AddCell("Estado da Cidade");

                for (int i = 0; i < (dgvCidade.Rows.Count); i++)
                {
                    table.AddCell(dgvCidade[0, i].Value.ToString());
                    table.AddCell(dgvCidade[1, i].Value.ToString());
                    table.AddCell(dgvCidade[2, i].Value.ToString());
                }

                //Necessário abrir para poder inserir os elementos
                doc.Open();
                doc.Add(smallibrary);
                doc.Add(cabecalho);
                doc.Add(l);
                doc.Add(classificacao);
                doc.Add(table);
                doc.Close();

                MessageBox.Show("PDF gerado.");

                //abrindo o pdf
                System.Diagnostics.Process.Start(caminho);
            }

            catch
            {
                MessageBox.Show("Não foi possivel gerar o PDF", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
