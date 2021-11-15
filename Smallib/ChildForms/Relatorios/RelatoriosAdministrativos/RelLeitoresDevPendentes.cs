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
using System.Diagnostics;
using static Smallib.Program;

namespace Smallib.ChildForms.Relatorios.RelatoriosAdministrativos
{
    public partial class RelLeitoresDevPendentes : Form
    {
        Principal _principal;

        void checarLinhasDgv()
        {
            if (dgvDevPendentes.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        void dadosLeitoresPendentes()
        {
            try
            {
                dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 order by pk_id_leitor", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvDevPendentes.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }

            checarLinhasDgv();
        }

        public RelLeitoresDevPendentes(Principal principal)
        {
            InitializeComponent();
            dadosLeitoresPendentes();

            _principal = principal;
        }

        private void radioIdEmprestimo_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dadosLeitoresPendentes();

                datb = new DataTable();
                dados.Fill(datb);
                dgvDevPendentes.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioNomeLeitor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 order by nome_leitor", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvDevPendentes.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioTituloLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 order by titulo_livro", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvDevPendentes.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioDataEmprestimo_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 order by dt_emprestimo", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvDevPendentes.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioDataDevPrevista_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 order by dt_dev_prev_emprestimo", conectar);

                datb = new DataTable();
                dados.Fill(datb);
                dgvDevPendentes.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioCursoLeitor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 order by nome_curso", conectar);

                datb = new DataTable();
                dados.Fill(datb);
                dgvDevPendentes.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
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
            if (dgvDevPendentes.RowCount == 0)
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
                    string path = "C:/pdf/RelatoriosAdministrativos";
                    if (Directory.Exists(path) == false)
                    {
                        //criando o diretório
                        DirectoryInfo dir = Directory.CreateDirectory(path);
                    }

                    //lugar onde o relatorio pfd vai ficar
                    string caminho = @"C:\pdf\RelatoriosAdministrativos\" + DateTime.Now.ToString("yyyy-MM-dd") + "_LeitoresDevPendentes_SmallLibrary.pdf";

                    //Criação do documento
                    Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 100f, 30f);
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                    //Criação das Fontes
                    iTextSharp.text.Font cell = FontFactory.GetFont("Arial", 10, BaseColor.BLACK);// Arial 10
                    iTextSharp.text.Font row = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);//Arial em Negrito 10
                    iTextSharp.text.Font fontBold = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);//Arial em Negrito 14
                    iTextSharp.text.Font texto = FontFactory.GetFont("Arial", 14, BaseColor.BLACK);//Arial em 14

                    //Tabela
                    PdfPTable table = new PdfPTable(9);
                    //table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

                    float[] widths = new float[] { 35f, 80f, 80f, 55f, 55f, 55f, 35f, 50f, 35f };// Largura das colunas
                    table.SetWidths(widths);
                    table.WidthPercentage = 100;

                    PdfPCell id = new PdfPCell(new Phrase("ID Empr.\n ", row));
                    removeBorderCell(id);
                    table.AddCell(id);

                    PdfPCell nome = new PdfPCell(new Phrase("Nome Leitor", row));
                    removeBorderCell(nome);
                    table.AddCell(nome);

                    PdfPCell titulo = new PdfPCell(new Phrase("Título Livro", row));
                    removeBorderCell(titulo);
                    table.AddCell(titulo);

                    PdfPCell tel = new PdfPCell(new Phrase("Telefone", row));
                    removeBorderCell(tel);
                    table.AddCell(tel);

                    PdfPCell dataEmpre = new PdfPCell(new Phrase("Data do Empr.", row));
                    removeBorderCell(dataEmpre);
                    table.AddCell(dataEmpre);

                    PdfPCell dataDevPrev = new PdfPCell(new Phrase("Data Dev. Prev.", row));
                    removeBorderCell(dataDevPrev);
                    table.AddCell(dataDevPrev);

                    PdfPCell tipo = new PdfPCell(new Phrase("Tipo L.", row));
                    removeBorderCell(tipo);
                    table.AddCell(tipo);

                    PdfPCell curso = new PdfPCell(new Phrase("Curso L.", row));
                    removeBorderCell(curso);
                    table.AddCell(curso);

                    PdfPCell classe = new PdfPCell(new Phrase("Classe L.", row));
                    removeBorderCell(classe);
                    table.AddCell(classe);

                    var rowEven = true;
                    BaseColor rowLightGray = new BaseColor(245, 245, 245);

                    for (int i = 0; i < (dgvDevPendentes.Rows.Count); i++)
                    {
                        PdfPCell cell_id = new PdfPCell(new Phrase(dgvDevPendentes[0, i].Value.ToString(), cell));
                        cell_id.MinimumHeight = 15f;
                        removeBorderCell(cell_id);

                        PdfPCell cell_nome = new PdfPCell(new Phrase(dgvDevPendentes[3, i].Value.ToString(), cell));
                        removeBorderCell(cell_nome);

                        PdfPCell cell_titulo = new PdfPCell(new Phrase(dgvDevPendentes[8, i].Value.ToString(), cell));
                        removeBorderCell(cell_titulo);

                        PdfPCell cell_tel = new PdfPCell(new Phrase(dgvDevPendentes[4, i].Value.ToString(), cell));
                        removeBorderCell(cell_tel);

                        PdfPCell cell_dt_emprestimo = new PdfPCell(new Phrase(dgvDevPendentes[1, i].FormattedValue.ToString(), cell));
                        removeBorderCell(cell_dt_emprestimo);

                        PdfPCell cell_dev_prevista = new PdfPCell(new Phrase(dgvDevPendentes[2, i].FormattedValue.ToString(), cell));
                        removeBorderCell(cell_dev_prevista);

                        PdfPCell cell_tipo = new PdfPCell(new Phrase(dgvDevPendentes[6, i].Value.ToString(), cell));
                        removeBorderCell(cell_tipo);

                        PdfPCell cell_curso = new PdfPCell(new Phrase(dgvDevPendentes[7, i].Value.ToString(), cell));
                        removeBorderCell(cell_curso);

                        PdfPCell cell_classe = new PdfPCell(new Phrase(dgvDevPendentes[5, i].Value.ToString(), cell));
                        removeBorderCell(cell_classe);

                        if (rowEven)
                        {
                            cell_id.BackgroundColor = rowLightGray;
                            cell_nome.BackgroundColor = rowLightGray;
                            cell_titulo.BackgroundColor = rowLightGray;
                            cell_tel.BackgroundColor = rowLightGray;
                            cell_dt_emprestimo.BackgroundColor = rowLightGray;
                            cell_dev_prevista.BackgroundColor = rowLightGray;
                            cell_tipo.BackgroundColor = rowLightGray;
                            cell_curso.BackgroundColor = rowLightGray;
                            cell_classe.BackgroundColor = rowLightGray;
                            rowEven = false;
                        }
                        else
                        {
                            cell_id.BackgroundColor = BaseColor.WHITE;
                            cell_nome.BackgroundColor = BaseColor.WHITE;
                            cell_titulo.BackgroundColor = BaseColor.WHITE;
                            cell_tel.BackgroundColor = BaseColor.WHITE;
                            cell_dt_emprestimo.BackgroundColor = BaseColor.WHITE;
                            cell_dev_prevista.BackgroundColor = BaseColor.WHITE;
                            cell_tipo.BackgroundColor = BaseColor.WHITE;
                            cell_curso.BackgroundColor = BaseColor.WHITE;
                            cell_classe.BackgroundColor = BaseColor.WHITE;
                            rowEven = true;
                        }

                        table.AddCell(cell_id); // id
                        table.AddCell(cell_nome); // nome
                        table.AddCell(cell_titulo); // titulo
                        table.AddCell(cell_tel); // telefone
                        table.AddCell(cell_dt_emprestimo); // dt emprestimo
                        table.AddCell(cell_dev_prevista); // dt dev prevista
                        table.AddCell(cell_tipo); // Tipo
                        table.AddCell(cell_curso); // Curso
                        table.AddCell(cell_classe); // Classe
                    }

                    //Necessário abrir para poder inserir os elementos
                    doc.Open();
                    doc.Add(table);
                    doc.Close();

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
                                if (radioIdEmprestimo.Checked == true)
                                {
                                    ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("Classificação: Ordem crescente de ID do Empréstimo\n\n", texto), 10f, 520f, 0);
                                }
                                else if (radioNomeLeitor.Checked == true)
                                {
                                    ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("Classificação: Ordem alfabética de Nome do Leitor\n\n", texto), 10f, 520f, 0);
                                }
                                else if (radioTituloLivro.Checked == true)
                                {
                                    ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("Classificação: Ordem alfabética de Título do Livro\n\n", texto), 10f, 520f, 0);
                                }
                                else if (radioDataEmprestimo.Checked == true)
                                {
                                    ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("Classificação: Ordem de Data de Empréstimos mais antigos até os mais recentes\n\n", texto), 10f, 520f, 0);
                                }
                                else if (radioDataDevPrevista.Checked == true)
                                {
                                    ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("Classificação: Ordem de Data de Devoluções Previstas mais antigas até as mais recentes\n\n", texto), 10f, 520f, 0);
                                }
                                else if (radioCursoLeitor.Checked == true)
                                {
                                    ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("Classificação: Ordem alfabética de Nome de Curso\n\n", texto), 10f, 520f, 0);
                                }
                                ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("__________________________________________________________________________________________________________", fontBold), 10f, 540f, 0);
                                ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("SISTEMA SMALL LIBRARY", fontBold), 650f, 570f, 0);
                                ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_LEFT, new Phrase("RELAÇÃO DE DEVOLUÇÕES PENDENTES", fontBold), 10f, 550f, 0);
                                ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_RIGHT, new Phrase("Página " + i.ToString() + " de " + pages, blackFont), 810f, 15f, 0);
                            }
                        }
                        bytes = stream.ToArray();
                    }
                    File.WriteAllBytes(caminho, bytes);

                    MessageBox.Show("PDF gerado com sucesso!.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Abrindo o pdf
                    Process p = new Process();
                    p.StartInfo = new ProcessStartInfo(caminho)
                    {
                        UseShellExecute = true,
                    };
                    p.Start();
                }

                catch
                {
                    MessageBox.Show("ERRO ao gerar PDF", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            labelDgv.Text = "";

            if (radioIdEmprestimo.Checked)
            {
                try
                {
                    //Consultando os leitores no banco de dados filtrando por id
                    dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 AND pk_id_leitor Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_leitor", conectar);

                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }

            }

            else if (radioNomeLeitor.Checked)
            {
                try
                {
                    //Consultando os leitores no banco de dados filtrando por nome
                    dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 AND nome_leitor Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_leitor", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            else if (radioTituloLivro.Checked)
            {
                try
                {
                    //Consultando os leitores no banco de dados filtrando por cidade
                    dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 AND titulo_livro Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_leitor", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            else if (radioDataEmprestimo.Checked)
            {
                try
                {
                    //Consultando os leitores no banco de dados filtrando por tipo
                    dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 AND dt_emprestimo Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_leitor", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            else if (radioDataDevPrevista.Checked)
            {
                try
                {
                    //Consultando os leitores no banco de dados filtrando por status
                    dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 AND dt_dev_prev_emprestimo Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_leitor", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            else if (radioCursoLeitor.Checked)
            {
                try
                {
                    //Consultando os leitores no banco de dados filtrando por status
                    dados = new SqlDataAdapter("select Emprestimo.pk_id_emprestimo as pk_id_emprestimo, Emprestimo.dt_emprestimo as dt_emprestimo, Emprestimo.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo, Leitor.nome_leitor as nome_leitor, Leitor.tel_cel_leitor as tel_cel_leitor, Leitor.classe_leitor as classe_leitor, Tipo.nome_tipo as nome_tipo, Curso.nome_curso as nome_curso, Livro.titulo_livro as titulo_livro from Leitor inner join Tipo on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo left join Curso on Leitor.fk_id_curso_leitor = Curso.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo inner join Livro on Emprestimo.fk_id_livro_emprestimo = Livro.pk_id_livro where Emprestimo.dt_dev_prev_emprestimo < GETDATE() AND Emprestimo.status_emprestimo = 0 AND nome_curso Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_leitor", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            //Mostrando os cursos na grade
            datb = new DataTable();
            dados.Fill(datb);
            dgvDevPendentes.DataSource = datb;

            //Verificando se a grade está vazia
            checarLinhasDgv();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dadosLeitoresPendentes();

            radioIdEmprestimo.Checked = true;
            metroTxtBoxPesquisar.Text = "";
        }
    }
}
