using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Smallib.Program;

namespace Smallib.ChildForms.Relatorios
{
    public partial class RelLivrosMaisEmprestados : Form
    {
        Principal _principal;

        public RelLivrosMaisEmprestados(Principal principal)
        {
            InitializeComponent();
            
            conectar.Open();
            dgvLivrosMaisEmprestados.Refresh();

            _principal = principal;

            if (dgvLivrosMaisEmprestados.Rows.Count == 0)
            {

                labelDgv.Text = "Insira o Período Desejado";

            }
            conectar.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            string de = txtBoxDe.Text;
            string ate = txtBoxAte.Text;

            if (dgvLivrosMaisEmprestados.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para geração de relatório!");
                return;
            }

            else
            {
                try
                {
                    //verificando se o caminho para o pdf já existe
                    string path = "C:/pdf/Livros";
                    if (Directory.Exists(path) == false)
                    {
                        //criando o diretório
                        DirectoryInfo dir = Directory.CreateDirectory(path);
                    }

                    //lugar onde o relatorio pfd vai ficar
                    string caminho = @"C:\pdf\Livros\" + DateTime.Now.ToString("yyyy-MM-dd") + "_RelatorioLivrosMaisEmprestestados_SmallLibrary.pdf ";

                    //Criação do documento
                    Document doc = new Document(PageSize.A4, 10f, 10f, 10f, 30f);

                    //Código pra forçar o fechamento de um arquivo
                    foreach (var process in Process.GetProcesses())
                    {
                        if (process.MainWindowTitle.Contains(DateTime.Now.ToString("yyyy-MM-dd") + "_RelatorioLivrosMaisEmprestestados_SmallLibrary.pdf "))
                        {
                            process.Kill();
                        }
                    }

                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                    //Criação das Fontes
                    iTextSharp.text.Font cell = FontFactory.GetFont("Arial", 10, BaseColor.BLACK);                                       // Arial 10
                    iTextSharp.text.Font row = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);             //Arial em Negrito 10
                    iTextSharp.text.Font fontSmallibrary = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK); //Arial em Negrito 14
                    iTextSharp.text.Font texto = FontFactory.GetFont("Arial", 14, BaseColor.BLACK);                                      //Arial em 14

                    //parte do paragrafo
                    string dados = "";

                    //small library
                    Paragraph smallibrary = new Paragraph(dados, fontSmallibrary); //Criação do objeto paragrafo com a fonte criada
                    smallibrary.Alignment = Element.ALIGN_RIGHT;                   //Alinha o conteudo a direita
                    smallibrary.Add("\n SISTEMA SMALL LIBRARY");

                    //cabeçalho
                    Paragraph cabecalho = new Paragraph(dados, texto);
                    cabecalho.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                    cabecalho.Add("\n RELAÇÃO DE LIVROS MAIS EMRPESTADOS");

                    //separador de linha
                    Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                    //Classificação
                    Paragraph classificacao = new Paragraph(dados, texto);
                    classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                    classificacao.Add(" Classificação: Livros ordenados segundo o mais emprestado");

                    //Período
                    Paragraph periodo = new Paragraph(dados, texto);
                    periodo.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                    periodo.Add(" Período: De " + de + " até " + ate + "\n\n");

                    //Tabela
                    PdfPTable table = new PdfPTable(3);

                    float[] widths = new float[] { 35f, 170f, 95f }; // Largura das colunas
                    table.SetWidths(widths);
                    table.WidthPercentage = 100;

                    PdfPCell id = new PdfPCell(new Phrase("ID \n ", row));
                    id.Border = 0;
                    table.AddCell(id);

                    PdfPCell titulo = new PdfPCell(new Phrase("Titulo", row));
                    titulo.Border = 0;
                    table.AddCell(titulo);

                    PdfPCell qtdEmp = new PdfPCell(new Phrase("Qtd. de Empréstimos", row));
                    qtdEmp.Border = 0;
                    table.AddCell(qtdEmp);

                    var rowEven = true;
                    BaseColor rowLightGray = new BaseColor(245, 245, 245);

                    for (int i = 0; i < (dgvLivrosMaisEmprestados.Rows.Count); i++)
                    {
                        PdfPCell cell_id = new PdfPCell(new Phrase(dgvLivrosMaisEmprestados[1, i].Value.ToString(), cell));
                        cell_id.MinimumHeight = 15f;
                        cell_id.Border = 0;

                        PdfPCell cell_titulo = new PdfPCell(new Phrase(dgvLivrosMaisEmprestados[2, i].Value.ToString(), cell));
                        cell_titulo.Border = 0;

                        PdfPCell cell_qtdEmp = new PdfPCell(new Phrase(dgvLivrosMaisEmprestados[0, i].Value.ToString(), cell));
                        cell_qtdEmp.Border = 0;

                        if (rowEven)
                        {
                            cell_id.BackgroundColor = rowLightGray;
                            cell_titulo.BackgroundColor = rowLightGray;
                            cell_qtdEmp.BackgroundColor = rowLightGray;
                            rowEven = false;
                        }
                        else
                        {
                            cell_id.BackgroundColor = BaseColor.WHITE;
                            cell_titulo.BackgroundColor = BaseColor.WHITE;
                            cell_qtdEmp.BackgroundColor = BaseColor.WHITE;
                            rowEven = true;
                        }

                        table.AddCell(cell_id); // id
                        table.AddCell(cell_titulo); // titulo
                        table.AddCell(cell_qtdEmp); // quantidade

                    }

                    //Necessário abrir para poder inserir os elementos
                    doc.Open();
                    doc.Add(smallibrary);
                    doc.Add(cabecalho);
                    doc.Add(l);
                    doc.Add(classificacao);
                    doc.Add(periodo);
                    doc.Add(table);
                    doc.Close();

                    MessageBox.Show("PDF gerado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Colocando número de página
                    byte[] bytes = File.ReadAllBytes(caminho);
                    iTextSharp.text.Font blackFont = FontFactory.GetFont("Arial", 12, BaseColor.BLACK);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        PdfReader reader = new PdfReader(bytes);
                        using (PdfStamper stamper = new PdfStamper(reader, stream))
                        {
                            int pages = reader.NumberOfPages;
                            for (int i = 1; i <= pages; i++)
                            {
                                ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_RIGHT, new Phrase("Página " + i.ToString() + " de " + pages, blackFont), 810f, 15f, 0);
                            }
                        }
                        bytes = stream.ToArray();
                    }
                    File.WriteAllBytes(caminho, bytes);

                    //abrindo o pdf
                    System.Diagnostics.Process.Start(caminho);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelEstatisticosRoot(_principal));
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            labelDgv.Text = "";

            DateTime de, ate;

            bool validacaoDe = DateTime.TryParseExact(txtBoxDe.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out de);
            bool validacaoAte = DateTime.TryParseExact(txtBoxAte.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ate);

            if (validacaoDe && validacaoAte)
            {
                if (txtBoxDe.Text != " /  / " && txtBoxAte.Text != "  /  /")
                {
                    conectar.Open();
                    dados = new SqlDataAdapter("select count(fk_id_leitor_emprestimo) as qtdleitor, pk_id_livro, titulo_livro from Emprestimo inner join Livro on fk_id_livro_emprestimo = pk_id_livro where (dt_emprestimo >= '" + txtBoxDe.Text + "' AND dt_emprestimo <= '" + txtBoxAte.Text + "') group by fk_id_livro_emprestimo, pk_id_livro, titulo_livro order by qtdleitor desc", conectar);
                    datb = new DataTable();
                    dados.Fill(datb);
                    dgvLivrosMaisEmprestados.DataSource = datb;
                    dgvLivrosMaisEmprestados.Refresh();

                    if (dgvLivrosMaisEmprestados.Rows.Count == 0)
                    {

                        labelDgv.Text = "Não foram encontrados livros no período";
                        conectar.Close();

                    }

                    conectar.Close();

                }

                else
                {
                    MessageBox.Show("Preencha todos os campos para pesquisar");
                    if (dgvLivrosMaisEmprestados.Rows.Count == 0)
                    {

                        labelDgv.Text = "Insira o Período Desejado";

                    }
                    conectar.Close();

                }

            }

            else
            {
                MessageBox.Show("Preencha a data em formato correto DD/MM/AAA!");

                if (dgvLivrosMaisEmprestados.Rows.Count == 0)
                {

                    labelDgv.Text = "Insira o Período Desejado";

                }
                conectar.Close();


            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtBoxDe.Text = "";
            txtBoxAte.Text = "";

            conectar.Open();
            dados = new SqlDataAdapter("select count(fk_id_leitor_emprestimo) as qtdleitor, pk_id_livro, titulo_livro from Emprestimo inner join Livro on fk_id_livro_emprestimo = pk_id_livro where pk_id_livro = 0 group by fk_id_livro_emprestimo, pk_id_livro, titulo_livro order by qtdleitor desc", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvLivrosMaisEmprestados.DataSource = datb;
            dgvLivrosMaisEmprestados.Refresh();


            if (dgvLivrosMaisEmprestados.Rows.Count == 0)
            {

                labelDgv.Text = "Insira o Período Desejado";

            }

            conectar.Close();
        }
    }
}
