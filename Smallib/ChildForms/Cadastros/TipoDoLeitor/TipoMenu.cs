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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static Smallib.Program;

namespace Smallib.ChildForms.Cadastros.Tipo_do_Leitor
{
    public partial class TipoMenu : Form
    {
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

            try
            {
                dados = new SqlDataAdapter("select pk_id_tipo, nome_tipo from Tipo order by pk_id_tipo", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvTipo.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioNomeTipo_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select pk_id_tipo, nome_tipo from Tipo order by nome_tipo", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvTipo.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dadosTipo();

            //Limpando as radiobutton
            radioIdTipo.Checked = true;
            radioNomeTipo.Checked = false;
            metroTxtBoxPesquisar.Clear();

            checarLinhasDgv();
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
                string caminho = @"C:\pdf\" + DateTime.Now.ToString("yyyyMMdd") + "_RelatorioTipo_SmallLibrary.pdf";

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
                cabecalho.Add("\n RELAÇÃO DE TIPOS DE LEITORES");

                //separador de linha
                Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                //Classificação
                Paragraph classificacao = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
                classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                classificacao.Add("Classificação: Identificação do Tipo \n\n");

                //Tabela
                PdfPTable table = new PdfPTable(2);
                table.DefaultCell.FixedHeight = 20;
                table.WidthPercentage = 100;

                table.AddCell("ID do Tipo");
                table.AddCell("Nome do Tipo");

                for (int i = 0; i < (dgvTipo.Rows.Count); i++)
                {
                    table.AddCell(dgvTipo[0, i].Value.ToString());
                    table.AddCell(dgvTipo[1, i].Value.ToString());
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
