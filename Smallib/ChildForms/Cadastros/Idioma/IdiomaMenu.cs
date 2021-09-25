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

namespace Smallib.ChildForms.Cadastros.Idioma
{
    public partial class IdiomaMenu : Form
    {
        //instanciando a classe
        Cadastro_Idioma cadastro_idioma = new Cadastro_Idioma();

        Principal _principal;

        void checarLinhasDgv()
        {
            //Verificando se a grade está vazia
            if (dgvIdioma.Rows.Count == 0)
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
            cadastro_idioma.pk_id_idioma = Convert.ToInt32(dgvIdioma[0, dgvIdioma.CurrentRow.Index].Value.ToString());
            cadastro_idioma.nome_idioma = dgvIdioma[1, dgvIdioma.CurrentRow.Index].Value.ToString();
        }

        public IdiomaMenu(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            dados = new SqlDataAdapter("select pk_id_idioma, nome_idioma from Idioma order by pk_id_idioma asc", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            dgvIdioma.DataSource = datb;
            dgvIdioma.Refresh();

            checarLinhasDgv();
        }

        private void radioIdIdioma_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select pk_id_idioma, nome_idioma from Idioma order by pk_id_idioma asc", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvIdioma.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioNomeIdioma_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select pk_id_idioma, nome_idioma from Idioma order by nome_idioma asc", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvIdioma.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Filtra utilizando o ID
            if (radioIdIdioma.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_idioma, nome_idioma from Idioma where pk_id_idioma Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
            }

            //Filtra utilizando o nome do gênero
            else if (radioNomeIdioma.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_idioma, nome_idioma from Idioma where nome_idioma Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
            }

            //Se nenhum radioButton for selecionado
            else
            {
                MessageBox.Show("Nenhuma opção de pesquisa selecionada, tente novamente");
            }

            datb = new DataTable();
            dados.Fill(datb);
            dgvIdioma.DataSource = datb;

            checarLinhasDgv();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dados = new SqlDataAdapter("select pk_id_idioma, nome_idioma from Idioma order by pk_id_idioma asc", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvIdioma.DataSource = datb;

            radioIdIdioma.Checked = true;
            radioNomeIdioma.Checked = false;
            metroTxtBoxPesquisar.Text = "";

            checarLinhasDgv();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new IdiomaNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Se caso nenhuma linha for selecionada
            if (dgvIdioma.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição!");
                return;
            }

            //Se apenas uma linha for selecionada
            else
            {
                armazenarDadosDasCelulas();

                //Chama o forms de edição de idioma passando a instancia da classe com os valores da linha selecionada
                _principal.OpenChildForm(new IdiomaEditar(_principal, cadastro_idioma));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Se caso nenhuma linha for selecionada
            if (dgvIdioma.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão!");
                return;
            }

            //Se apenas uma linha for selecionada
            else
            {
                armazenarDadosDasCelulas();

                //Chama o forms de exclusão do idioma passando a instancia da classe com os valores da linha selecionada
                _principal.OpenChildForm(new IdiomaExcluir(_principal, cadastro_idioma));

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Se caso nenhuma linha for selecionada
            if (dgvIdioma.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta!");
                return;
            }

            //Se apenas uma linha for selecionada
            else
            {
                armazenarDadosDasCelulas();

                //Chama o forms de consulta do idioma passando a instancia da classe com os valores da linha selecionada
                _principal.OpenChildForm(new IdiomaConsultar(_principal, cadastro_idioma));
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
                string caminho = @"C:\pdf\" + DateTime.Now.ToString("yyyyMMdd") + "_RelatorioIdioma_SmallLibrary.pdf";

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
                cabecalho.Add("\n RELAÇÃO DE IDIOMAS DOS LIVROS");

                //separador de linha
                Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                //Classificação
                Paragraph classificacao = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
                classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                classificacao.Add("Classificação: Identificação do Idioma \n\n");

                //Tabela
                PdfPTable table = new PdfPTable(2);
                table.DefaultCell.FixedHeight = 20;
                table.WidthPercentage = 100;

                table.AddCell("ID do Idioma");
                table.AddCell("Nome do Idioma");

                for (int i = 0; i < (dgvIdioma.Rows.Count); i++)
                {
                    table.AddCell(dgvIdioma[0, i].Value.ToString());
                    table.AddCell(dgvIdioma[1, i].Value.ToString());
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
