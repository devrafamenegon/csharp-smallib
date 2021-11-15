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

namespace Smallib.ChildForms.Cadastros.Nacionalidade
{
    public partial class NacionalidadeMenu : Form
    {
        string pk_id_nacionalidade, nome_nacionaliadde;
        Cadastro_Nacionalidade Cadastro_Nacionalidade = new Cadastro_Nacionalidade();

        Principal _principal;

        void checarLinhasDgv()
        {
            //Verificando se a grade está vazia
            if (dgvNacionalidade.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        public NacionalidadeMenu(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            dados = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade order by pk_id_nacionalidade", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            dgvNacionalidade.DataSource = datb;
            dgvNacionalidade.Refresh();

            checarLinhasDgv();
        }

        private void radioIdNacionalidade_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade order by pk_id_nacionalidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvNacionalidade.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioNomeNacionalidade_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;

            try
            {
                dados = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade order by nome_nacionalidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvNacionalidade.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (radioIdNacionalidade.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade where pk_id_nacionalidade Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_nacionalidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvNacionalidade.DataSource = datb;

                checarLinhasDgv();
            }

            else if (radioNomeNacionalidade.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade where nome_nacionalidade Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_nacionalidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvNacionalidade.DataSource = datb;

                checarLinhasDgv();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dados = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade order by pk_id_nacionalidade", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvNacionalidade.DataSource = datb;

            radioIdNacionalidade.Checked = true;
            radioNomeNacionalidade.Checked = false;
            metroTxtBoxPesquisar.Text = "";

            checarLinhasDgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvNacionalidade.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }

            else
            {
                Cadastro_Nacionalidade.pk_id_nacionalidade = Convert.ToInt32(dgvNacionalidade[0, dgvNacionalidade.CurrentRow.Index].Value.ToString());
                Cadastro_Nacionalidade.nome_nacionalidade = dgvNacionalidade[1, dgvNacionalidade.CurrentRow.Index].Value.ToString();
                _principal.OpenChildForm(new NacionalidadeEditar(_principal, Cadastro_Nacionalidade));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvNacionalidade.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }

            else
            {
                Cadastro_Nacionalidade.pk_id_nacionalidade = Convert.ToInt32(dgvNacionalidade[0, dgvNacionalidade.CurrentRow.Index].Value.ToString());
                Cadastro_Nacionalidade.nome_nacionalidade = dgvNacionalidade[1, dgvNacionalidade.CurrentRow.Index].Value.ToString();
                _principal.OpenChildForm(new NacionalidadeExcluir(_principal, Cadastro_Nacionalidade));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvNacionalidade.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }

            else
            {
                Cadastro_Nacionalidade.pk_id_nacionalidade = Convert.ToInt32(dgvNacionalidade[0, dgvNacionalidade.CurrentRow.Index].Value.ToString());
                Cadastro_Nacionalidade.nome_nacionalidade = dgvNacionalidade[1, dgvNacionalidade.CurrentRow.Index].Value.ToString();
                _principal.OpenChildForm(new NacionalidadeConsultar(_principal, Cadastro_Nacionalidade));
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new NacionalidadeNovo(_principal));
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
                string caminho = @"C:\pdf\" + DateTime.Now.ToString("yyyyMMdd") + "_RelatorioNacionalidade_SmallLibrary.pdf";

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
                cabecalho.Add("\n RELAÇÃO DE NACIONALIDADES DOS AUTORES");

                //separador de linha
                Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                //Classificação
                Paragraph classificacao = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
                classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                classificacao.Add("Classificação: Identificação do Nacionalidade \n\n");

                //Tabela
                PdfPTable table = new PdfPTable(2);
                table.DefaultCell.FixedHeight = 20;
                table.WidthPercentage = 100;

                table.AddCell("ID da Nacionalidade");
                table.AddCell("Nome do Nacionalidade");

                for (int i = 0; i < (dgvNacionalidade.Rows.Count); i++)
                {
                    table.AddCell(dgvNacionalidade[0, i].Value.ToString());
                    table.AddCell(dgvNacionalidade[1, i].Value.ToString());
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
