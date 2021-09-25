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

namespace Smallib.ChildForms.Cadastros.Editora
{
    public partial class EditoraMenu : Form
    {
        //Criando um objeto da classe editora
        Cadastro_Editora editora = new Cadastro_Editora();

        Principal _principal;

        void checarLabelDgv()
        {
            //Verificando se a grade está vazia
            if (dgvEditora.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        void dadosEditora()
        {
            try
            {
                dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvEditora.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }

            checarLabelDgv();
        }

        void armazenarDadosDasCelulas()
        {
            //Armazenando os dados da linha selecionada
            editora.pk_id_editora = Convert.ToInt32(dgvEditora[0, dgvEditora.CurrentRow.Index].Value.ToString());
            editora.nome_editora = dgvEditora[1, dgvEditora.CurrentRow.Index].Value.ToString();
            editora.email_editora = dgvEditora[2, dgvEditora.CurrentRow.Index].Value.ToString();
            editora.tel_editora = dgvEditora[3, dgvEditora.CurrentRow.Index].Value.ToString();
            editora.site_editora = dgvEditora[4, dgvEditora.CurrentRow.Index].Value.ToString();
            editora.nome_cidade = dgvEditora[5, dgvEditora.CurrentRow.Index].Value.ToString();
            editora.estado_cidade = dgvEditora[6, dgvEditora.CurrentRow.Index].Value.ToString();
        }

        public EditoraMenu(Principal principal)
        {
            InitializeComponent();
            dadosEditora();

            _principal = principal;
        }

        private void radioIdEditora_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade order by pk_id_editora", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvEditora.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioNomeEditora_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade order by nome_editora", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvEditora.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioEmailEditora_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade order by email_editora", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvEditora.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioTelefoneEditora_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade order by tel_editora", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvEditora.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Mostrando as editoras cadastradas no banco na grade
            dadosEditora();

            //Limpando os radiobuttons
            radioIdEditora.Checked = true;
            radioNomeEditora.Checked = false;
            radioEmailEditora.Checked = false;
            radioTelefoneEditora.Checked = false;

            //Limpando a barra de pesquisa
            metroTxtBoxPesquisar.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Verificando se o radio button de id da editora está selecionado
            if (radioIdEditora.Checked)
            {
                try
                {
                    //Consultando as editoras no banco de dados filtrando por id
                    dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade where pk_id_editora Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            //Verificando se o radio button de nome da editora está selecionado
            else if (radioNomeEditora.Checked)
            {
                try
                {
                    //Consultando as editoras no banco de dados filtrando por nome
                    dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade where nome_editora Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            //Verificando se o radio button de nome da editora está selecionado
            else if (radioEmailEditora.Checked)
            {
                try
                {
                    //Consultando as editoras no banco de dados filtrando por email
                    dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade where email_editora Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            //Verificando se o radio button de nome da editora está selecionado
            else if (radioTelefoneEditora.Checked)
            {
                try
                {
                    //Consultando as editoras no banco de dados filtrando por telefone
                    dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade where tel_editora Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            //se nenhum radioButton for selecionado
            else
            {
                MessageBox.Show("Nenhuma opção de pesquisa selecionada");
                return;
            }

            //Mostrando as editoras na grade
            datb = new DataTable();
            dados.Fill(datb);
            dgvEditora.DataSource = datb;

            checarLabelDgv();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new EditoraNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvEditora.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new EditoraEditar(_principal, editora));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvEditora.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de exclusão passando esses dados 
                _principal.OpenChildForm(new EditoraExcluir(_principal, editora));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvEditora.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de consulta passando esses dados 
                _principal.OpenChildForm(new EditoraConsultar(_principal, editora));
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                //verificando se o caminho para o pdf já existe
                string path = "C:/pdf/Editoras";
                if (Directory.Exists(path) == false)
                {
                    //criando o diretório
                    DirectoryInfo dir = Directory.CreateDirectory(path);
                }

                //lugar onde o relatorio pfd vai ficar
                string caminho = @"C:\pdf\Editoras\" + DateTime.Now.ToString("yyyy-MM-dd") + "_RelatorioEditoras_SmallLibrary.pdf";

                //Criação do documento
                Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
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
                cabecalho.Add("\n RELAÇÃO DE EDITORAS DE LIVROS");

                //separador de linha
                Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                //Classificação
                Paragraph classificacao = new Paragraph(dados, texto);
                classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                classificacao.Add(" Classificação: Identificação das Editoras \n\n");

                //Tabela
                PdfPTable table = new PdfPTable(6);

                float[] widths = new float[] { 35f, 150f, 150f, 80f, 150f, 150f };// Largura das colunas
                table.SetWidths(widths);
                table.WidthPercentage = 100;

                PdfPCell id = new PdfPCell(new Phrase("ID \n ", row));
                table.AddCell(id);

                PdfPCell titulo = new PdfPCell(new Phrase("Nome", row));
                table.AddCell(titulo);

                PdfPCell tomb = new PdfPCell(new Phrase("E-Mail", row));
                table.AddCell(tomb);

                PdfPCell edit = new PdfPCell(new Phrase("Telefone", row));
                table.AddCell(edit);

                PdfPCell aut = new PdfPCell(new Phrase("Site", row));
                table.AddCell(aut);

                PdfPCell gen = new PdfPCell(new Phrase("Cidade", row));
                table.AddCell(gen);

                for (int i = 0; i < (dgvEditora.Rows.Count); i++)
                {
                    PdfPCell cell_id = new PdfPCell(new Phrase(dgvEditora[0, i].Value.ToString(), cell));
                    cell_id.MinimumHeight = 25f;
                    table.AddCell(cell_id); // id

                    PdfPCell cell_nome = new PdfPCell(new Phrase(dgvEditora[1, i].Value.ToString(), cell));
                    table.AddCell(cell_nome); // nome

                    PdfPCell cell_email = new PdfPCell(new Phrase(dgvEditora[2, i].Value.ToString(), cell));
                    table.AddCell(cell_email); // email

                    PdfPCell cell_tel = new PdfPCell(new Phrase(dgvEditora[3, i].Value.ToString(), cell));
                    table.AddCell(cell_tel); // telefone

                    PdfPCell cell_rg = new PdfPCell(new Phrase(dgvEditora[4, i].Value.ToString(), cell));
                    table.AddCell(cell_rg); // rg

                    PdfPCell cell_nasc = new PdfPCell(new Phrase(dgvEditora[5, i].Value.ToString(), cell));
                    table.AddCell(cell_nasc); // Data de Nacimento
                }

                //Necessário abrir para poder inserir os elementos
                doc.Open();
                doc.Add(smallibrary);
                doc.Add(cabecalho);
                doc.Add(l);
                doc.Add(classificacao);
                doc.Add(table);
                doc.Close();

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
}
