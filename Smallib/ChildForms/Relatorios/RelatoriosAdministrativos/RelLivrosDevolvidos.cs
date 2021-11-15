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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using static Smallib.Program;

namespace Smallib.ChildForms.Relatorios.RelatoriosAdministrativos
{
    public partial class RelLivrosDevolvidos : Form
    {
        Principal _principal;

        public RelLivrosDevolvidos(Principal principal)
        {
            InitializeComponent();
            conectar.Close();

            _principal = principal;
        }
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (dgvLivrosDevolvidos.RowCount == 0)
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

                string de = txtBoxDe.Text;
                string ate = txtBoxAte.Text;
                try
                {
                    //verificando se o caminho para o pdf já existe
                    string path = @"C:/pdf/LivrosPeriodo";
                    if (Directory.Exists(path) == false)
                    {
                        //criando o diretório
                        DirectoryInfo dir = Directory.CreateDirectory(path);
                    }

                    //lugar onde o relatorio pfd vai ficar
                    string caminho = @"C:\pdf\LivrosPeriodo\RelatorioLivrosPeriodo_SmallLibrary.pdf";

                    //Criação do documento
                    Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 100f, 30f);
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                    //Criação das Fontes
                    iTextSharp.text.Font cell = FontFactory.GetFont("Arial", 10, BaseColor.BLACK);// Arial 10
                    iTextSharp.text.Font row = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);//Arial em Negrito 10
                    iTextSharp.text.Font fontBold = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);//Arial em Negrito 14
                    iTextSharp.text.Font texto = FontFactory.GetFont("Arial", 14, BaseColor.BLACK);//Arial em 14

                    //Tabela
                    PdfPTable table = new PdfPTable(6);

                    float[] widths = new float[] { 70f, 140f, 140f, 100f, 130f, 80f };// Largura das colunas
                    table.SetWidths(widths);
                    table.WidthPercentage = 100;

                    PdfPCell idemp = new PdfPCell(new Phrase("ID Empréstimo \n ", row));
                    idemp.Border = 0;
                    table.AddCell(idemp);

                    PdfPCell titulo = new PdfPCell(new Phrase("Titulo do Livro", row));
                    titulo.Border = 0;
                    table.AddCell(titulo);

                    PdfPCell leitor = new PdfPCell(new Phrase("Leitor", row));
                    leitor.Border = 0;
                    table.AddCell(leitor);

                    PdfPCell dtemp = new PdfPCell(new Phrase("Data do Empréstimo", row));
                    dtemp.Border = 0;
                    table.AddCell(dtemp);

                    PdfPCell dtdevprev = new PdfPCell(new Phrase("Data da Devolução Prevista", row));
                    dtdevprev.Border = 0;
                    table.AddCell(dtdevprev);

                    PdfPCell dtdev = new PdfPCell(new Phrase("Data da Devolução", row));
                    dtdev.Border = 0;
                    table.AddCell(dtdev);


                    for (int i = 0; i < (dgvLivrosDevolvidos.Rows.Count); i++)
                    {
                        PdfPCell cell_idemp = new PdfPCell(new Phrase(dgvLivrosDevolvidos[0, i].Value.ToString(), cell));
                        cell_idemp.MinimumHeight = 15f;
                        cell_idemp.Border = 0;
                        table.AddCell(cell_idemp); // id

                        PdfPCell cell_titulo = new PdfPCell(new Phrase(dgvLivrosDevolvidos[1, i].Value.ToString(), cell));
                        cell_titulo.MinimumHeight = 15f;
                        cell_titulo.Border = 0;
                        table.AddCell(cell_titulo); // titulo

                        PdfPCell cell_leitor = new PdfPCell(new Phrase(dgvLivrosDevolvidos[2, i].Value.ToString(), cell));
                        cell_leitor.MinimumHeight = 15f;
                        cell_leitor.Border = 0;
                        table.AddCell(cell_leitor); // leitor

                        PdfPCell cell_dt_emp = new PdfPCell(new Phrase(dgvLivrosDevolvidos[3, i].FormattedValue.ToString(), cell));
                        cell_dt_emp.MinimumHeight = 15f;
                        cell_dt_emp.Border = 0;
                        table.AddCell(cell_dt_emp); // data do emprestimo

                        PdfPCell cell_dt_dev_prev = new PdfPCell(new Phrase(dgvLivrosDevolvidos[4, i].FormattedValue.ToString(), cell));
                        cell_dt_dev_prev.MinimumHeight = 15f;
                        cell_dt_dev_prev.Border = 0;
                        table.AddCell(cell_dt_dev_prev); // data da devolução prevista

                        PdfPCell cell_dt_dev = new PdfPCell(new Phrase(dgvLivrosDevolvidos[5, i].FormattedValue.ToString(), cell));
                        cell_dt_dev.MinimumHeight = 15f;
                        cell_dt_dev.Border = 0;
                        table.AddCell(cell_dt_dev); // data da devolução 
                    }

                    //Necessário abrir para poder inserir os elementos
                    doc.Open();
                    doc.Add(table);
                    doc.Close();

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
                                ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("Classificação: Ordem de data de devolução", texto), 10f, 520f, 0);
                                ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("__________________________________________________________________________________________________________", fontBold), 10f, 540f, 0);
                                ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("SISTEMA SMALL LIBRARY", fontBold), 650f, 570f, 0);
                                ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("RELAÇÃO DE LIVROS DEVOLVIDOS (" + de + " - " + ate + ")", fontBold), 10f, 550f, 0);
                                ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_RIGHT, new Phrase("Página " + i.ToString() + " de " + pages, blackFont), 820f, 15f, 0);
                            }
                        }
                        bytes = stream.ToArray();
                    }
                    File.WriteAllBytes(caminho, bytes);

                    MessageBox.Show("PDF gerado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Abrindo o pdf
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(caminho)
                    {
                        UseShellExecute = true
                    };
                    p.Start();
                }

                catch
                {
                    MessageBox.Show("ERRO ao gerrar PDF", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime time;
            if (txtBoxDe.MaskCompleted && txtBoxAte.MaskCompleted)
            {
                if (DateTime.TryParse(txtBoxDe.Text, out time) && DateTime.TryParse(txtBoxAte.Text, out time))
                {
                    try
                    {
                        dados = new SqlDataAdapter("select E.pk_id_emprestimo as pk_id_emprestimo, L.titulo_livro as titulo_livro, Le.nome_leitor as nome_leitor, E.dt_emprestimo as dt_emprestimo, E.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, E.dt_devolucao_emprestimo as dt_devolucao_emprestimo from Emprestimo as E inner join Livro as L on E.fk_id_livro_emprestimo=L.pk_id_Livro inner join Leitor as Le on E.fk_id_leitor_emprestimo=Le.pk_id_leitor where E.dt_devolucao_emprestimo between '" + txtBoxDe.Text + "' and '" + txtBoxAte.Text + "' and E.status_emprestimo = 1 order by E.dt_devolucao_emprestimo", conectar);
                        datb = new DataTable();
                        dados.Fill(datb);
                        dgvLivrosDevolvidos.DataSource = datb;
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //Verificando se a grade está vazia
                    if (dgvLivrosDevolvidos.RowCount != 0)
                    {
                        labelDgv.Text = "";
                    }
                    else
                    {
                        labelDgv.Text = "Nenhum livro encontrado";
                    }
                }
                else
                {
                    MessageBox.Show("Digite datas válidas", "Datas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Preencha o período", "Período", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dados = new SqlDataAdapter("select E.pk_id_emprestimo as pk_id_emprestimo, L.titulo_livro as titulo_livro, Le.nome_leitor as nome_leitor, E.dt_emprestimo as dt_emprestimo, E.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, E.dt_devolucao_emprestimo as dt_devolucao_emprestimo from Emprestimo as E inner join Livro as L on E.fk_id_livro_emprestimo=L.pk_id_Livro inner join Leitor as Le on E.fk_id_leitor_emprestimo=Le.pk_id_leitor where E.pk_id_emprestimo = 0", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvLivrosDevolvidos.DataSource = datb;

            txtBoxDe.Text = "";
            txtBoxAte.Text = "";
            labelDgv.Text = "Pesquise um período";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelAdministrativosRoot(_principal));
        }

    }
}
