using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using static Smallib.Program;

namespace Smallib.ChildForms.Relatorios.RelatoriosAdministrativos
{
    public partial class RelHistoricoEmprestimos : Form
    {
        Principal _principal;
        public RelHistoricoEmprestimos(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            conectar.Open();
            SqlDataAdapter Titulo = new SqlDataAdapter("select pk_id_livro, titulo_livro + ' - ' + CONVERT (varchar(4), pk_id_livro) as dpmember from Livro order by pk_id_livro", conectar);
            DataTable dtTitulo = new DataTable();
            Titulo.Fill(dtTitulo);
            comboBoxTituloLivro.DataSource = dtTitulo;
            comboBoxTituloLivro.ValueMember = "pk_id_livro";
            comboBoxTituloLivro.DisplayMember = "dpmember";

            comboBoxTituloLivro.SelectedIndex = -1;

            dgvHistoricoEmprestimos.Refresh();

            if (dgvHistoricoEmprestimos.Rows.Count == 0)
            {

                labelDgv.Text = "Pesquise pelo livro desejado";

            }
            conectar.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelAdministrativosRoot(_principal));
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            comboBoxTituloLivro.SelectedIndex = -1;
            txtBoxDe.Text = "";
            txtBoxAte.Text = "";

            conectar.Open();
            dados = new SqlDataAdapter("select Livro.pk_id_livro, Livro.titulo_livro, Leitor.nome_leitor, Emprestimo.dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo, Emprestimo.dt_devolucao_emprestimo from Emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro inner join Leitor on Emprestimo.fk_id_leitor_emprestimo = Leitor.pk_id_leitor where Livro.pk_id_livro = 0", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvHistoricoEmprestimos.DataSource = datb;
            dgvHistoricoEmprestimos.Refresh();


            if (dgvHistoricoEmprestimos.Rows.Count == 0)
            {

                labelDgv.Text = "Pesquise pelo livro desejado";

            }

            conectar.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            labelDgv.Text = "";

            DateTime de, ate;

            bool validacaoDe = DateTime.TryParseExact(txtBoxDe.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out de);
            bool validacaoAte = DateTime.TryParseExact(txtBoxAte.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ate);

            if (validacaoDe && validacaoAte)
            {
                if (comboBoxTituloLivro.SelectedIndex != -1 && comboBoxTituloLivro.Text != "" && txtBoxDe.Text != " /  / " && txtBoxAte.Text != "  /  /")
                {
                    conectar.Open();
                    dados = new SqlDataAdapter("select Livro.pk_id_livro, Livro.titulo_livro, Leitor.nome_leitor, Emprestimo.dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo, Emprestimo.dt_devolucao_emprestimo from Emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro inner join Leitor on Emprestimo.fk_id_leitor_emprestimo = Leitor.pk_id_leitor where Livro.pk_id_livro Like'%" + comboBoxTituloLivro.SelectedValue + "%' AND (dt_emprestimo >= '" + txtBoxDe.Text + "' AND dt_emprestimo <= '" + txtBoxAte.Text + "') order by Emprestimo.dt_emprestimo", conectar);
                    datb = new DataTable();
                    dados.Fill(datb);
                    dgvHistoricoEmprestimos.DataSource = datb;
                    dgvHistoricoEmprestimos.Refresh();

                    if (dgvHistoricoEmprestimos.Rows.Count == 0)
                    {

                        labelDgv.Text = "Nenhum registro encontrado";
                        conectar.Close();

                    }

                    conectar.Close();

                }

                else
                {
                    MessageBox.Show("Preencha todos os campos para pesquisar");
                    if (dgvHistoricoEmprestimos.Rows.Count == 0)
                    {

                        labelDgv.Text = "Pesquise pelo livro desejado";

                    }
                    conectar.Close();

                }

            }

            else
            {
                MessageBox.Show("Preencha a data em formato correto DD/MM/AAA!");

                if (dgvHistoricoEmprestimos.Rows.Count == 0)
                {

                    labelDgv.Text = "Pesquise pelo livro desejado";

                }
                conectar.Close();


            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            string de = txtBoxDe.Text;
            string ate = txtBoxAte.Text;

            if (dgvHistoricoEmprestimos.SelectedCells.Count == 0)
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
                    string caminho = @"C:\pdf\Livros\" + DateTime.Now.ToString("yyyy-MM-dd") + "_RelatorioLivros_SmallLibrary.pdf ";

                    //Criação do documento
                    Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 30f);

                    //Código pra forçar o fechamento de um arquivo
                    foreach (var process in Process.GetProcesses())
                    {
                        if (process.MainWindowTitle.Contains(DateTime.Now.ToString("yyyy-MM-dd") + "_RelatorioLivros_SmallLibrary.pdf "))
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
                    cabecalho.Add("\n RELAÇÃO DE EMPRÉSTIMOS");

                    //separador de linha
                    Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                    //Classificação
                    Paragraph classificacao = new Paragraph(dados, texto);
                    classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                    classificacao.Add(" Classificação: Identificação de Empréstimos por Intervalo de Data");

                    //Período
                    Paragraph periodo = new Paragraph(dados, texto);
                    periodo.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                    periodo.Add(" Período: De " + de + " até " + ate + "\n\n");

                    //Tabela
                    PdfPTable table = new PdfPTable(6);

                    float[] widths = new float[] { 35f, 170f, 170f, 40f, 40f, 40f }; // Largura das colunas
                    table.SetWidths(widths);
                    table.WidthPercentage = 100;

                    PdfPCell id = new PdfPCell(new Phrase("ID \n ", row));
                    id.Border = 0;
                    table.AddCell(id);

                    PdfPCell titulo = new PdfPCell(new Phrase("Titulo", row));
                    titulo.Border = 0;
                    table.AddCell(titulo);

                    PdfPCell leitor = new PdfPCell(new Phrase("Leitor", row));
                    leitor.Border = 0;
                    table.AddCell(leitor);

                    PdfPCell dtemp = new PdfPCell(new Phrase("Data de Empréstimo", row));
                    dtemp.Border = 0;
                    table.AddCell(dtemp);

                    PdfPCell dvprev = new PdfPCell(new Phrase("Devolução Prevista", row));
                    dvprev.Border = 0;
                    table.AddCell(dvprev);

                    PdfPCell dtdev = new PdfPCell(new Phrase("Data de Devolução", row));
                    dtdev.Border = 0;
                    table.AddCell(dtdev);

                    for (int i = 0; i < (dgvHistoricoEmprestimos.Rows.Count); i++)
                    {
                        PdfPCell cell_id = new PdfPCell(new Phrase(dgvHistoricoEmprestimos[0, i].Value.ToString(), cell));
                        cell_id.MinimumHeight = 25f;
                        cell_id.Border = 0;
                        table.AddCell(cell_id); // id

                        PdfPCell cell_titulo = new PdfPCell(new Phrase(dgvHistoricoEmprestimos[1, i].Value.ToString(), cell));
                        cell_titulo.Border = 0;
                        table.AddCell(cell_titulo); // titulo

                        PdfPCell cell_leitor = new PdfPCell(new Phrase(dgvHistoricoEmprestimos[2, i].Value.ToString(), cell));
                        cell_leitor.Border = 0;
                        table.AddCell(cell_leitor); // leitor

                        PdfPCell cell_dtemp = new PdfPCell(new Phrase(dgvHistoricoEmprestimos[3, i].FormattedValue.ToString(), cell));
                        cell_dtemp.Border = 0;
                        table.AddCell(cell_dtemp); // data de emp

                        PdfPCell cell_dvprev = new PdfPCell(new Phrase(dgvHistoricoEmprestimos[4, i].FormattedValue.ToString(), cell));
                        cell_dvprev.Border = 0;
                        table.AddCell(cell_dvprev); // devolucao prevista

                        PdfPCell cell_dtdev = new PdfPCell(new Phrase(dgvHistoricoEmprestimos[5, i].FormattedValue.ToString(), cell));
                        cell_dtdev.Border = 0;
                        table.AddCell(cell_dtdev); // data de dev
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
    }
}
