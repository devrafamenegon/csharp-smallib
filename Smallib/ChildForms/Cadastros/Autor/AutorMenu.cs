using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static Smallib.Program;

namespace Smallib.ChildForms.Cadastros.Autores
{
    public partial class AutorMenu : Form
    {
        //Criando um objeto da classe cidade
        Cadastro_Autor autores = new Cadastro_Autor();

        Principal _principal;

        void checarLinhasDgv()
        {
            if (dgvAutor.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        void dadosAutores()
        {
            try
            {
                dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade order by pk_id_autor", conectar);
                datb = new DataTable();
                dados.Fill(datb);

                dgvAutor.DataSource = datb;
                dgvAutor.Refresh();

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
            autores.pk_id_autor = Convert.ToInt32(dgvAutor[0, dgvAutor.CurrentRow.Index].Value.ToString());
            autores.nome_autor = dgvAutor[1, dgvAutor.CurrentRow.Index].Value.ToString();
            autores.nacionalidade_autor = dgvAutor[2, dgvAutor.CurrentRow.Index].Value.ToString();
        }

        public AutorMenu(Principal principal)
        {
            InitializeComponent();
            conectar.Close();
            dadosAutores();

            _principal = principal;
        }

        private void radioIdAutor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade order by pk_id_autor", conectar);

                datb = new DataTable();
                dados.Fill(datb);
                dgvAutor.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioNomeAutor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade order by nome_autor", conectar);

                datb = new DataTable();
                dados.Fill(datb);
                dgvAutor.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioNacionalidadeAutor_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade order by Nacionalidade.nome_nacionalidade", conectar);

                datb = new DataTable();
                dados.Fill(datb);
                dgvAutor.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new AutorNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvAutor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new AutorEditar(_principal, autores));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvAutor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de exclusão passando esses dados 
                _principal.OpenChildForm(new AutorExcluir(_principal, autores));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvAutor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de consulta passando esses dados 
                _principal.OpenChildForm(new AutorConsultar(_principal, autores));
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            labelDgv.Text = "";

            if (radioIdAutor.Checked)
            {
                dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade where pk_id_autor Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_autor", conectar);

            }

            else if (radioNomeAutor.Checked)
            {
                dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade where nome_autor Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_autor", conectar);
            }

            else if (radioNacionalidadeAutor.Checked)
            {
                dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade where Nacionalidade.nome_nacionalidade Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_autor", conectar);
            }

            //Mostrando os cursos na grade
            datb = new DataTable();
            dados.Fill(datb);
            dgvAutor.DataSource = datb;

            //Verificando se a grade está vazia
            checarLinhasDgv();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Mostrando os cursos cadastrados no banco na grade
            dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade order by pk_id_autor", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            //Mostrando os cursos na grade
            dgvAutor.DataSource = datb;
            dgvAutor.Refresh();

            checarLinhasDgv();

            //Limpando as radiobutton
            radioIdAutor.Checked = true;
            radioNomeAutor.Checked = false;
            radioNacionalidadeAutor.Checked = false;
            metroTxtBoxPesquisar.Clear();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                //verificando se o caminho para o pdf já existe
                string path = "C:/pdf/Autores";
                if (Directory.Exists(path) == false)
                {
                    //criando o diretório
                    DirectoryInfo dir = Directory.CreateDirectory(path);
                }

                //lugar onde o relatorio pfd vai ficar
                string caminho = @"C:\pdf\Autores\" + DateTime.Now.ToString("yyyy-MM-dd") + "_RelatorioAutores_SmallLibrary.pdf";

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
                cabecalho.Add("\n RELAÇÃO DE AUTORES DE LIVROS");

                //separador de linha
                Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                //Classificação
                Paragraph classificacao = new Paragraph(dados, texto);
                classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                classificacao.Add(" Classificação: Identificação dos Autores \n\n");

                //Tabela
                PdfPTable table = new PdfPTable(3);

                float[] widths = new float[] { 35f, 100f, 100f };// Largura das colunas
                table.SetWidths(widths);
                table.WidthPercentage = 100;

                PdfPCell id = new PdfPCell(new Phrase("ID \n ", row));
                table.AddCell(id);

                PdfPCell titulo = new PdfPCell(new Phrase("Nome", row));
                table.AddCell(titulo);

                PdfPCell nacio = new PdfPCell(new Phrase("Nacionalidade", row));
                table.AddCell(nacio);

                for (int i = 0; i < (dgvAutor.Rows.Count); i++)
                {
                    PdfPCell cell_id = new PdfPCell(new Phrase(dgvAutor[0, i].Value.ToString(), cell));
                    cell_id.MinimumHeight = 25f;
                    table.AddCell(cell_id); // id

                    PdfPCell cell_nome = new PdfPCell(new Phrase(dgvAutor[1, i].Value.ToString(), cell));
                    table.AddCell(cell_nome); // nome

                    PdfPCell cell_email = new PdfPCell(new Phrase(dgvAutor[2, i].Value.ToString(), cell));
                    table.AddCell(cell_email); // email
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
