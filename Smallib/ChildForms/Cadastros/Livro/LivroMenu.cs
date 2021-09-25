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
using System.IO;
using static Smallib.Program;

namespace Smallib.ChildForms.Cadastros.Livros
{
    public partial class LivroMenu : Form
    {
        //Criando um objeto da classe livro
        Cadastro_Livro livro = new Cadastro_Livro();

        Principal _principal;

        void checarLinhasDgv()
        {
            if (dgvLivro.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        void dadosLivro()
        {
            try
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma order by pk_id_livro", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLivro.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        void armazenarDadosDasCelulas()
        {
            //Armazenando os dados da linha da célula selecionada
            livro.pk_id_livro = Convert.ToInt32(dgvLivro[0, dgvLivro.CurrentRow.Index].Value.ToString());
            livro.titulo_livro = dgvLivro[1, dgvLivro.CurrentRow.Index].Value.ToString();
            livro.tombo_livro = dgvLivro[2, dgvLivro.CurrentRow.Index].Value.ToString();
            livro.editora_livro = dgvLivro[3, dgvLivro.CurrentRow.Index].Value.ToString();
            livro.autor_livro = dgvLivro[4, dgvLivro.CurrentRow.Index].Value.ToString();
            livro.genero_livro = dgvLivro[5, dgvLivro.CurrentRow.Index].Value.ToString();
            livro.idioma_livro = dgvLivro[6, dgvLivro.CurrentRow.Index].Value.ToString();
            livro.ultemprest_livro = dgvLivro[7, dgvLivro.CurrentRow.Index].Value.ToString();
            livro.ultleitor_livro = dgvLivro[8, dgvLivro.CurrentRow.Index].Value.ToString();
            livro.status_livro = Convert.ToInt32(dgvLivro[9, dgvLivro.CurrentRow.Index].Value.ToString());
        }

        public LivroMenu(Principal principal)
        {
            InitializeComponent();
            dadosLivro();

            checarLinhasDgv();

            _principal = principal;
        }

        private void radioIdLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            dadosLivro();
        }

        private void radioTituloLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
            
            try
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma order by titulo_livro", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLivro.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioEditoraLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma order by Editora.nome_editora", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLivro.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioGeneroLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma order by Genero.nome_genero", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLivro.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioAutorLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma order by Autor.nome_autor", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLivro.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioStatusLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma order by status_livro", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvLivro.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dadosLivro();
            checarLinhasDgv();

            metroTxtBoxPesquisar.Text = "";

            radioIdLivro.Checked = true;
            radioTituloLivro.Checked = false;
            radioEditoraLivro.Checked = false;
            radioGeneroLivro.Checked = false;
            radioAutorLivro.Checked = false;
            radioStatusLivro.Checked = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (radioIdLivro.Checked)
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma where pk_id_livro Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_livro", conectar);

                checarLinhasDgv();
            }

            else if (radioTituloLivro.Checked)
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma where titulo_livro Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_livro", conectar);
            }

            else if (radioEditoraLivro.Checked)
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma where Editora.nome_editora Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_livro", conectar);
            }

            else if (radioGeneroLivro.Checked)
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma where Genero.nome_genero Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_livro", conectar);
            }

            else if (radioAutorLivro.Checked)
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma where Autor.nome_autor Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_livro", conectar);
            }

            else if (radioStatusLivro.Checked)
            {
                dados = new SqlDataAdapter("select Livro.pk_id_Livro, Livro.titulo_livro, Livro.tombo_livro, Editora.nome_editora, Autor.nome_autor, Genero.nome_genero, Idioma.nome_idioma, Livro.ultemprest_livro, Livro.ultleitor_livro, Livro.status_livro from Livro inner join Editora on Livro.fk_id_editora_livro = Editora.pk_id_editora inner join Autor on Livro.fk_id_autor_livro = Autor.pk_id_autor inner join Genero on Livro.fk_id_genero_livro = Genero.pk_id_genero inner join idioma on Livro.fk_id_idioma_livro = Idioma.pk_id_idioma where Idioma.nome_idioma Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_livro", conectar);
            }

            datb = new DataTable();
            dados.Fill(datb);
            dgvLivro.DataSource = datb;

            checarLinhasDgv();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LivroNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvLivro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada // Falta dados
                armazenarDadosDasCelulas();

                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new LivroEditar(_principal, livro));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvLivro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada
                armazenarDadosDasCelulas();

                //Abrindo a tela de exclusão passando esses dados 
                _principal.OpenChildForm(new LivroExcluir(_principal, livro));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvLivro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada
                armazenarDadosDasCelulas();

                //Abrindo a tela de consulta passando esses dados 
                _principal.OpenChildForm(new LivroConsultar(_principal, livro));
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
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
                string caminho = @"C:\pdf\Livros\" + DateTime.Now.ToString("yyyy-MM-dd") + "_RelatorioLivros_SmallLibrary.pdf";

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
                cabecalho.Add("\n RELAÇÃO DE LIVROS");

                //separador de linha
                Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                //Classificação
                Paragraph classificacao = new Paragraph(dados, texto);
                classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                classificacao.Add(" Classificação: Identificação dos Livros \n\n");

                //Tabela
                PdfPTable table = new PdfPTable(7);

                float[] widths = new float[] { 35f, 150f, 80f, 150f, 150f, 100f, 100f };// Largura das colunas
                table.SetWidths(widths);
                table.WidthPercentage = 100;

                PdfPCell id = new PdfPCell(new Phrase("ID \n ", row));
                table.AddCell(id);

                PdfPCell titulo = new PdfPCell(new Phrase("Titulo", row));
                table.AddCell(titulo);

                PdfPCell tomb = new PdfPCell(new Phrase("Data de Tombamento", row));
                table.AddCell(tomb);

                PdfPCell edit = new PdfPCell(new Phrase("Editora", row));
                table.AddCell(edit);

                PdfPCell aut = new PdfPCell(new Phrase("Autor", row));
                table.AddCell(aut);

                PdfPCell gen = new PdfPCell(new Phrase("Gênero", row));
                table.AddCell(gen);

                PdfPCell idio = new PdfPCell(new Phrase("Idioma", row));
                table.AddCell(idio);

                for (int i = 0; i < (dgvLivro.Rows.Count); i++)
                {
                    PdfPCell cell_id = new PdfPCell(new Phrase(dgvLivro[0, i].Value.ToString(), cell));
                    cell_id.MinimumHeight = 25f;
                    table.AddCell(cell_id); // id

                    PdfPCell cell_nome = new PdfPCell(new Phrase(dgvLivro[1, i].Value.ToString(), cell));
                    table.AddCell(cell_nome); // nome

                    PdfPCell cell_email = new PdfPCell(new Phrase(dgvLivro[2, i].FormattedValue.ToString(), cell));
                    table.AddCell(cell_email); // email

                    PdfPCell cell_tel = new PdfPCell(new Phrase(dgvLivro[3, i].Value.ToString(), cell));
                    table.AddCell(cell_tel); // telefone

                    PdfPCell cell_rg = new PdfPCell(new Phrase(dgvLivro[4, i].Value.ToString(), cell));
                    table.AddCell(cell_rg); // rg

                    PdfPCell cell_nasc = new PdfPCell(new Phrase(dgvLivro[5, i].Value.ToString(), cell));
                    table.AddCell(cell_nasc); // Data de Nacimento

                    PdfPCell cell_atl = new PdfPCell(new Phrase(dgvLivro[6, i].Value.ToString(), cell));
                    table.AddCell(cell_atl); // data de atulização
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
