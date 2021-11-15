using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using static Smallib.Program;

namespace Smallib.ChildForms.Relatorios.RelatoriosAdministrativos
{
    public partial class RelLivrosEmprestados : Form
    {
        Principal _principal;

        void checarLinhasDgv()
        {
            if (dgvLivrosEmprestados.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        void dadosLivrosEmprestados()
        {
            try
            {
                dados = new SqlDataAdapter("Select Livro.pk_id_livro, Livro.titulo_livro, Leitor.nome_leitor, " +
                                            "dt_emprestimo, dt_dev_prev_emprestimo " +
                                            "from Emprestimo " +
                                            "INNER JOIN Leitor ON Leitor.pk_id_leitor = Emprestimo.fk_id_leitor_emprestimo " +
                                            "INNER JOIN Livro ON Livro.pk_id_livro = Emprestimo.fk_id_livro_emprestimo " +
                                            "ORDER BY Emprestimo.dt_dev_prev_emprestimo", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLivrosEmprestados.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            checarLinhasDgv();
        }

        public RelLivrosEmprestados(Principal principal)
        {
            InitializeComponent();
            conectar.Close();

            dadosLivrosEmprestados();

            _principal = principal;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelAdministrativosRoot(_principal));
        }

        void removeBorderCell(PdfPCell celula)
        {
            celula.Border = 0;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (dgvLivrosEmprestados.RowCount == 0)
            {
                MessageBox.Show("Nenhum dado para gerar relatório. Digite um período e busque.");
            }
            else
            {
                //Código pra forçar o fechamento de um arquivo
                foreach (var process in Process.GetProcesses())
                {
                    if (process.MainWindowTitle.Contains("RelatorioLivrosPeriodo_SmallLibrary.pdf"))
                    {
                        process.Kill();
                    }
                }

                try
                {

                    //verificando se o caminho para o pdf já existe
                    string path = "C:/pdf/ADM/LivrosEmprestados";
                    if (Directory.Exists(path) == false)
                    {
                        //criando o diretório
                        DirectoryInfo dir = Directory.CreateDirectory(path);
                    }

                    //lugar onde o relatorio pfd vai ficar
                    string caminho = @"C:\pdf\ADM\LivrosEmprestados\RelatorioLivrosEmprestados_SmallLibrary.pdf";

                    //Criação do documento
                    Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 30f);
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                    //Criação das Fontes
                    iTextSharp.text.Font cell = FontFactory.GetFont("Arial", 10, BaseColor.BLACK);// Arial 10
                    iTextSharp.text.Font row = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);//Arial em Negrito 10
                    iTextSharp.text.Font fontSmallibrary = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);//Arial em Negrito 14
                    iTextSharp.text.Font texto = FontFactory.GetFont("Arial", 14, BaseColor.BLACK);//Arial em 14

                    //parte do paragrafo
                    string dados = "";

                    //small library
                    Paragraph smallibrary = new Paragraph(dados, fontSmallibrary); //Criação do objeto paragrafo com a fonte criada
                    smallibrary.Alignment = Element.ALIGN_RIGHT; //Alinha o conteudo a direita
                    smallibrary.Add("\n SISTEMA SMALL LIBRARY");

                    //cabeçalho
                    Paragraph cabecalho = new Paragraph(dados, texto);
                    cabecalho.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                    cabecalho.Add("\n RELAÇÃO DE LIVROS EMPRESTADOS");

                    //separador de linha
                    Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                    //Classificação
                    Paragraph classificacao = new Paragraph(dados, texto);
                    classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda

                    if (radioIdLivro.Checked)
                    {
                        classificacao.Add(" Classificação: Ordem por ID dos Livros Emprestados \n\n");
                    }
                    else if (radioTituloLivro.Checked)
                    {
                        classificacao.Add(" Classificação: Ordem Alfabética de Título dos Livros Emprestados \n\n");
                    }
                    else if (radioNomeLeitor.Checked)
                    {
                        classificacao.Add(" Classificação: Ordem Alfabética de Nome de Usuário dos Livros Emprestados \n\n");
                    }
                    else if (radioDataEmprestimo.Checked)
                    {
                        classificacao.Add(" Classificação: Ordem de data de empréstimo dos Livros \n\n");
                    }
                    else if (radioDataDevPrevista.Checked)
                    {
                        classificacao.Add(" Classificação: Ordem de data de devolução Prevista dos Livros Emprestados \n\n");
                    }
                    else
                    {
                        classificacao.Add(" Classificação: Não identificada \n\n");
                    }

                    //Tabela
                    PdfPTable table = new PdfPTable(5);

                    table.HorizontalAlignment = 0;
                    table.TotalWidth = 820;
                    table.LockedWidth = true;
                    float[] widths = new float[] { 15f, 100f, 60f, 35f, 35f };
                    table.SetWidths(widths);
                    table.WidthPercentage = 100;

                    PdfPCell id = new PdfPCell(new Phrase("ID \n ", row));
                    removeBorderCell(id);
                    table.AddCell(id);

                    PdfPCell titulo = new PdfPCell(new Phrase("Titulo do Livro", row));
                    removeBorderCell(titulo);
                    table.AddCell(titulo);

                    PdfPCell tomb = new PdfPCell(new Phrase("Nome do Leitor", row));
                    removeBorderCell(tomb);
                    table.AddCell(tomb);

                    PdfPCell edit = new PdfPCell(new Phrase("Data de Empréstimo", row));
                    removeBorderCell(edit);
                    table.AddCell(edit);

                    PdfPCell aut = new PdfPCell(new Phrase("Devolução Prevista", row));
                    removeBorderCell(aut);
                    table.AddCell(aut);

                    for (int i = 0; i < (dgvLivrosEmprestados.Rows.Count); i++)
                    {

                        PdfPCell cell_id = new PdfPCell(new Phrase(dgvLivrosEmprestados[0, i].Value.ToString(), cell));
                        cell_id.MinimumHeight = 15f;
                        removeBorderCell(cell_id);
                        table.AddCell(cell_id); // id

                        PdfPCell cell_nome = new PdfPCell(new Phrase(dgvLivrosEmprestados[1, i].Value.ToString(), cell));
                        removeBorderCell(cell_nome);
                        table.AddCell(cell_nome); // nome

                        PdfPCell cell_email = new PdfPCell(new Phrase(dgvLivrosEmprestados[2, i].Value.ToString(), cell));
                        removeBorderCell(cell_email);
                        table.AddCell(cell_email); // email

                        PdfPCell cell_tel = new PdfPCell(new Phrase(dgvLivrosEmprestados[3, i].FormattedValue.ToString(), cell));
                        removeBorderCell(cell_tel);
                        table.AddCell(cell_tel); // telefone

                        PdfPCell cell_rg = new PdfPCell(new Phrase(dgvLivrosEmprestados[4, i].FormattedValue.ToString(), cell));
                        removeBorderCell(cell_rg);
                        table.AddCell(cell_rg); // rg
                    }

                    //Necessário abrir para poder inserir os elementos
                    doc.Open();
                    doc.Add(smallibrary);
                    doc.Add(cabecalho);
                    doc.Add(l);
                    doc.Add(classificacao);
                    doc.Add(table);
                    doc.Close();

                    //Colocando número de página 
                    byte[] bytes = File.ReadAllBytes(@"C:\pdf\ADM\LivrosEmprestados\RelatorioLivrosEmprestados_SmallLibrary.pdf");
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
                    File.WriteAllBytes(@"C:\pdf\ADM\LivrosEmprestados\RelatorioLivrosEmprestados_SmallLibrary.pdf", bytes);

                    MessageBox.Show("PDF gerado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //abrindo o pdf
                    System.Diagnostics.Process.Start(caminho);

                }

                catch (Exception erro)
                {
                    MessageBox.Show("ERRO ao gerrar PDF " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioIdLivro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dados = new SqlDataAdapter("Select Livro.pk_id_livro, Livro.titulo_livro, Leitor.nome_leitor, " +
                                            "dt_emprestimo, dt_dev_prev_emprestimo " +
                                            "from Emprestimo " +
                                            "INNER JOIN Leitor ON Leitor.pk_id_leitor = Emprestimo.fk_id_leitor_emprestimo " +
                                            "INNER JOIN Livro ON Livro.pk_id_livro = Emprestimo.fk_id_livro_emprestimo " +
                                            "ORDER BY Livro.pk_id_livro", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLivrosEmprestados.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            checarLinhasDgv();
        }

        private void radioNomeLeitor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dados = new SqlDataAdapter("Select Livro.pk_id_livro, Livro.titulo_livro, Leitor.nome_leitor, " +
                                            "dt_emprestimo, dt_dev_prev_emprestimo " +
                                            "from Emprestimo " +
                                            "INNER JOIN Leitor ON Leitor.pk_id_leitor = Emprestimo.fk_id_leitor_emprestimo " +
                                            "INNER JOIN Livro ON Livro.pk_id_livro = Emprestimo.fk_id_livro_emprestimo " +
                                            "ORDER BY Leitor.nome_leitor", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLivrosEmprestados.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            checarLinhasDgv();
        }

        private void radioTituloLivro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dados = new SqlDataAdapter("Select Livro.pk_id_livro, Livro.titulo_livro, Leitor.nome_leitor, " +
                                            "dt_emprestimo, dt_dev_prev_emprestimo " +
                                            "from Emprestimo " +
                                            "INNER JOIN Leitor ON Leitor.pk_id_leitor = Emprestimo.fk_id_leitor_emprestimo " +
                                            "INNER JOIN Livro ON Livro.pk_id_livro = Emprestimo.fk_id_livro_emprestimo " +
                                            "ORDER BY Livro.titulo_livro", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLivrosEmprestados.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            checarLinhasDgv();
        }

        private void radioDataEmprestimo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dados = new SqlDataAdapter("Select Livro.pk_id_livro, Livro.titulo_livro, Leitor.nome_leitor, " +
                                            "dt_emprestimo, dt_dev_prev_emprestimo " +
                                            "from Emprestimo " +
                                            "INNER JOIN Leitor ON Leitor.pk_id_leitor = Emprestimo.fk_id_leitor_emprestimo " +
                                            "INNER JOIN Livro ON Livro.pk_id_livro = Emprestimo.fk_id_livro_emprestimo " +
                                            "ORDER BY Emprestimo.dt_emprestimo", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLivrosEmprestados.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            checarLinhasDgv();
        }

        private void radioDataDevPrevista_CheckedChanged(object sender, EventArgs e)
        {
            dadosLivrosEmprestados();
        }
    }
}
