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

namespace Smallib.ChildForms.Cadastros.Genero
{
    public partial class GeneroMenu : Form
    {
        Principal _principal;

        //instanciando a classe
        Cadastro_Genero cadastro_genero = new Cadastro_Genero();

        void checarLinhasDgv()
        {
            //Verificando se a grade está vazia
            if (dgvGenero.Rows.Count == 0)
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
            //passando os valores da linha selecionada para a instancia da classe
            cadastro_genero.pk_id_genero = Convert.ToInt32(dgvGenero[0, dgvGenero.CurrentRow.Index].Value.ToString());
            cadastro_genero.nome_genero = dgvGenero[1, dgvGenero.CurrentRow.Index].Value.ToString();
        }

        public GeneroMenu(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            dados = new SqlDataAdapter("select pk_id_genero, nome_genero from Genero order by pk_id_genero asc", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            dgvGenero.DataSource = datb;
            dgvGenero.Refresh();

            checarLinhasDgv();
        }

        private void radioIdGenero_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select pk_id_genero, nome_genero from Genero order by pk_id_genero asc", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvGenero.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioNomeGenero_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select pk_id_genero, nome_genero from Genero order by nome_genero", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvGenero.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Filtra utilizando o ID
            if (radioIdGenero.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_genero, nome_genero from Genero where pk_id_genero Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvGenero.DataSource = datb;
            }

            //Filtra utilizando o nome do gênero
            else if (radioNomeGenero.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_genero, nome_genero from Genero where nome_genero Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvGenero.DataSource = datb;
            }

            //Se nenhum radioButton for selecionado
            else
            {
                MessageBox.Show("Nenhuma opção de pesquisa selecionada, tente novamente!");
            }

            checarLinhasDgv();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dados = new SqlDataAdapter("select pk_id_genero, nome_genero from Genero order by pk_id_genero asc", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvGenero.DataSource = datb;

            radioIdGenero.Checked = true;
            radioNomeGenero.Checked = false;
            metroTxtBoxPesquisar.Text = "";

            checarLinhasDgv();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new GeneroNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Se caso nenhuma linha for selecionada
            if (dgvGenero.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição!");
                return;
            }

            //Se apenas uma linha for selecionada
            else
            {
                armazenarDadosDasCelulas();

                //Chama o forms de edição de gênero passando a instancia da classe com os valores da linha selecionada
                _principal.OpenChildForm(new GeneroEditar(_principal, cadastro_genero));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Se caso nenhuma linha for selecionada
            if (dgvGenero.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição!");
                return;
            }

            //Se apenas uma linha for selecionada
            else
            {
                armazenarDadosDasCelulas();

                //Chama o forms de edição de gênero passando a instancia da classe com os valores da linha selecionada
                _principal.OpenChildForm(new GeneroExcluir(_principal, cadastro_genero));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Se caso nenhuma linha for selecionada
            if (dgvGenero.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição!");
                return;
            }

            //Se apenas uma linha for selecionada
            else
            {
                armazenarDadosDasCelulas();

                //Chama o forms de edição de gênero passando a instancia da classe com os valores da linha selecionada
                _principal.OpenChildForm(new GeneroConsultar(_principal, cadastro_genero));
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
                string caminho = @"C:\pdf\" + DateTime.Now.ToString("yyyyMMdd") + "_RelatorioGenero_SmallLibrary.pdf";

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
                cabecalho.Add("\n RELAÇÃO DE GÊNEROS DOS LIVROS");

                //separador de linha
                Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                //Classificação
                Paragraph classificacao = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
                classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                classificacao.Add("Classificação: Identificação do Gênero \n\n");

                //Tabela
                PdfPTable table = new PdfPTable(2);
                table.DefaultCell.FixedHeight = 20;
                table.WidthPercentage = 100;

                table.AddCell("ID do Gênero");
                table.AddCell("Nome do Gênero");

                for (int i = 0; i < (dgvGenero.Rows.Count); i++)
                {
                    table.AddCell(dgvGenero[0, i].Value.ToString());
                    table.AddCell(dgvGenero[1, i].Value.ToString());
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
