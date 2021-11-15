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
    public partial class RelLeitoresEmAtraso : Form
    {
        //Criando um objeto da classe curso
        Cadastro_Leitor leitor = new Cadastro_Leitor();

        Principal _principal;

        void checarLinhasDgv()
        {
            if (dgvLeitor.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        void dadosLeitor()
        {
            try
            {
                dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo where dt_dev_prev_emprestimo < dt_devolucao_emprestimo order by pk_id_leitor", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLeitor.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        public RelLeitoresEmAtraso(Principal principal)
        {
            InitializeComponent();
            dadosLeitor();

            checarLinhasDgv();

            _principal = principal;
        }

        private void radioIdLeitor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dadosLeitor();

                dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo where dt_dev_prev_emprestimo < dt_devolucao_emprestimo order by pk_id_leitor", conectar);

                datb = new DataTable();
                dados.Fill(datb);
                dgvLeitor.DataSource = datb;
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
                dadosLeitor();

                dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo where dt_dev_prev_emprestimo < dt_devolucao_emprestimo order by nome_leitor", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLeitor.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioCidadeLeitor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dadosLeitor();

                dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo where dt_dev_prev_emprestimo < dt_devolucao_emprestimo order by nome_cidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLeitor.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioTipoLeitor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dadosLeitor();

               dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo where dt_dev_prev_emprestimo < dt_devolucao_emprestimo order by nome_tipo", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLeitor.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioStatusLeitor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dadosLeitor();

                dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo where dt_dev_prev_emprestimo < dt_devolucao_emprestimo order by status_leitor", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLeitor.DataSource = datb;
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
                dadosLeitor();

                dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso inner join Emprestimo on pk_id_leitor = fk_id_leitor_emprestimo where dt_dev_prev_emprestimo < dt_devolucao_emprestimo order by nome_curso", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLeitor.DataSource = datb;
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
            try
            {
                //verificando se o caminho para o pdf já existe
                string path = "C:/pdf/Leitores";
                if (Directory.Exists(path) == false)
                {
                    //criando o diretório
                    DirectoryInfo dir = Directory.CreateDirectory(path);
                }

                //lugar onde o relatorio pfd vai ficar
                string caminho = @"C:\pdf\Leitores\" + DateTime.Now.ToString("yyyy-MM-dd") + "_RelatorioLeitores_SmallLibrary.pdf";

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
                cabecalho.Add("\n RELAÇÃO DE LEITORES");

                //separador de linha
                Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                //Classificação
                Paragraph classificacao = new Paragraph(dados, texto);
                classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                classificacao.Add(" Classificação: Identificação dos Leitores em atraso\n\n");
                

                //Tabela
                PdfPTable table = new PdfPTable(8);
                //table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

                float[] widths = new float[] { 35f, 90f, 90f, 70f, 50f, 50f, 100f, 35f};// Largura das colunas
                table.SetWidths(widths);
                table.WidthPercentage = 100;

                PdfPCell id = new PdfPCell(new Phrase("ID \n ", row));
                removeBorderCell(id);
                table.AddCell(id);

                PdfPCell nome = new PdfPCell(new Phrase("Nome", row));
                removeBorderCell(nome);
                table.AddCell(nome);

                PdfPCell email = new PdfPCell(new Phrase("E-mail", row));
                removeBorderCell(email);
                table.AddCell(email);

                PdfPCell tel = new PdfPCell(new Phrase("Telefone", row));
                removeBorderCell(tel);
                table.AddCell(tel);

                PdfPCell rg = new PdfPCell(new Phrase("RG", row));
                removeBorderCell(rg);
                table.AddCell(rg);

                //PdfPCell dataNasc = new PdfPCell(new Phrase("Data de Nacimento", row));
                //table.AddCell(dataNasc);

                //PdfPCell dataAtl = new PdfPCell(new Phrase("Data de Cadastro", row));
                //table.AddCell(dataAtl);

                //PdfPCell cidade = new PdfPCell(new Phrase("Cidade", row));
                //removeBorderCell(cidade);
                //table.AddCell(cidade);

                //PdfPCell uf = new PdfPCell(new Phrase("UF", row));
                //removeBorderCell(uf);
                ///table.AddCell(uf);

                PdfPCell tipo = new PdfPCell(new Phrase("Tipo", row));
                removeBorderCell(tipo);
                table.AddCell(tipo);

                PdfPCell curso = new PdfPCell(new Phrase("Curso", row));
                removeBorderCell(curso);
                table.AddCell(curso);

                PdfPCell classe = new PdfPCell(new Phrase("Classe", row));
                removeBorderCell(classe);
                table.AddCell(classe);

                var rowEven = true;
                BaseColor rowLightGray = new BaseColor(245, 245, 245);

                for (int i = 0; i < (dgvLeitor.Rows.Count); i++)
                {
                    PdfPCell cell_id = new PdfPCell(new Phrase(dgvLeitor[0, i].Value.ToString(), cell));
                    cell_id.MinimumHeight = 15f;
                    removeBorderCell(cell_id);

                    PdfPCell cell_nome = new PdfPCell(new Phrase(dgvLeitor[1, i].Value.ToString(), cell));
                    removeBorderCell(cell_nome);
                    

                    PdfPCell cell_email = new PdfPCell(new Phrase(dgvLeitor[2, i].Value.ToString(), cell));
                    removeBorderCell(cell_email);
                    

                    PdfPCell cell_tel = new PdfPCell(new Phrase(dgvLeitor[3, i].Value.ToString(), cell));
                    removeBorderCell(cell_tel);
                    

                    PdfPCell cell_rg = new PdfPCell(new Phrase(dgvLeitor[4, i].Value.ToString(), cell));
                    removeBorderCell(cell_rg);
                   

                    //PdfPCell cell_nasc = new PdfPCell(new Phrase(dgvLeitor[5, i].FormattedValue.ToString(), cell));
                    //table.AddCell(cell_nasc); // Data de Nacimento

                    //PdfPCell cell_atl = new PdfPCell(new Phrase(dgvLeitor[6, i].FormattedValue.ToString(), cell));
                    //table.AddCell(cell_atl); // data de atulização

                    //PdfPCell cell_cid = new PdfPCell(new Phrase(dgvLeitor[7, i].Value.ToString(), cell));
                    //removeBorderCell(cell_cid);
                    //table.AddCell(cell_cid); // cidade

                    //PdfPCell cell_uf = new PdfPCell(new Phrase(dgvLeitor[8, i].Value.ToString(), cell));
                    //removeBorderCell(cell_uf);
                    //table.AddCell(cell_uf); // estado

                    PdfPCell cell_tipo = new PdfPCell(new Phrase(dgvLeitor[9, i].Value.ToString(), cell));
                    removeBorderCell(cell_tipo);
                    

                    PdfPCell cell_curso = new PdfPCell(new Phrase(dgvLeitor[10, i].Value.ToString(), cell));
                    removeBorderCell(cell_curso);
                    

                    PdfPCell cell_classe = new PdfPCell(new Phrase(dgvLeitor[11, i].Value.ToString(), cell));
                    removeBorderCell(cell_classe);

                    if (rowEven)
                    {
                        cell_id.BackgroundColor = rowLightGray;
                        cell_nome.BackgroundColor = rowLightGray;
                        cell_email.BackgroundColor = rowLightGray;
                        cell_tel.BackgroundColor = rowLightGray;
                        cell_rg.BackgroundColor = rowLightGray;
                        cell_tipo.BackgroundColor = rowLightGray;
                        cell_curso.BackgroundColor = rowLightGray;
                        cell_classe.BackgroundColor = rowLightGray;
                        rowEven = false;
                    }
                    else
                    {
                        cell_id.BackgroundColor = BaseColor.WHITE;
                        cell_nome.BackgroundColor = BaseColor.WHITE;
                        cell_email.BackgroundColor = BaseColor.WHITE;
                        cell_tel.BackgroundColor = BaseColor.WHITE;
                        cell_rg.BackgroundColor = BaseColor.WHITE;
                        cell_tipo.BackgroundColor = BaseColor.WHITE;
                        cell_curso.BackgroundColor = BaseColor.WHITE;
                        cell_classe.BackgroundColor = BaseColor.WHITE;
                        rowEven = true;
                    }

                    table.AddCell(cell_id); // id
                    table.AddCell(cell_nome); // nome
                    table.AddCell(cell_email); // email
                    table.AddCell(cell_tel); // telefone
                    table.AddCell(cell_rg); // rg
                    table.AddCell(cell_tipo); // Tipo
                    table.AddCell(cell_curso); // Curso
                    table.AddCell(cell_classe); // Classe
                }

                //Necessário abrir para poder inserir os elementos
                doc.Open();
                doc.Add(smallibrary);
                doc.Add(cabecalho);
                doc.Add(l);
                doc.Add(classificacao);
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            labelDgv.Text = "";

            if (radioIdLeitor.Checked)
            {
                try
                {
                    //Consultando os leitores no banco de dados filtrando por id
                    dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso where pk_id_leitor Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
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
                    dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso where nome_leitor Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            else if (radioCidadeLeitor.Checked)
            {
                try
                {
                    //Consultando os leitores no banco de dados filtrando por cidade
                    dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso where nome_cidade Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            else if (radioTipoLeitor.Checked)
            {
                try
                {
                    //Consultando os leitores no banco de dados filtrando por tipo
                    dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso where nome_tipo Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            else if (radioStatusLeitor.Checked)
            {
                try
                {
                    //Consultando os leitores no banco de dados filtrando por status
                    dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso where status_leitor Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
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
                    dados = new SqlDataAdapter("select L.pk_id_leitor as pk_id_leitor, L.nome_leitor as nome_leitor, L.email_leitor as email_leitor, L.tel_cel_leitor as tel_cel_leitor, L.rg_leitor as rg_leitor, L.dtnasc_leitor as dtnasc_leitor, L.dtcad_leitor as dtcad_leitor, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade, T.nome_tipo as nome_tipo, N.nome_curso as nome_curso, L.classe_leitor as classe_leitor, L.status_leitor as status_leitor from Leitor as L inner join Cidade as C on L.fk_id_cidade_leitor=C.pk_id_cidade inner join Tipo as T on L.fk_id_tipo_leitor= T.pk_id_tipo left join Curso as N on L.fk_id_curso_leitor = N.pk_id_curso where nome_curso Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            //Mostrando os cursos na grade
            datb = new DataTable();
            dados.Fill(datb);
            dgvLeitor.DataSource = datb;

            //Verificando se a grade está vazia
            checarLinhasDgv();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dadosLeitor();
            radioIdLeitor.Checked = true;
        }
    }
}
