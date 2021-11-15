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
using static Smallib.Program;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Smallib.ChildForms.Cadastros.Curso
{
    public partial class CursoMenu : Form
    {
        //Criando um objeto da classe curso
        Cadastro_Curso curso = new Cadastro_Curso();

        Principal _principal;
        void checarLinhasDgv()
        {
            //Verificando se a grade está vazia
            if (dgvCurso.Rows.Count == 0)
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
            //Armazenando os dados da linha da célula selecionada
            curso.pk_id_curso = Convert.ToInt32(dgvCurso[0, dgvCurso.CurrentRow.Index].Value.ToString());
            curso.nome_curso = dgvCurso[1, dgvCurso.CurrentRow.Index].Value.ToString();
        }

        public CursoMenu(Principal principal)
        {
            InitializeComponent();

            //Consultando os cursos no banco de dados
            dados = new SqlDataAdapter("select pk_id_curso, nome_curso from Curso order by pk_id_curso", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            //Mostrando os cursos na grade
            dgvCurso.DataSource = datb;
            dgvCurso.Refresh();

            checarLinhasDgv();

            _principal = principal;
        }

        private void radioIdCurso_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;


        }

        private void radioNomeCurso_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Mostrando os cursos cadastrados no banco na grade
            dados = new SqlDataAdapter("select pk_id_curso, nome_curso from Curso order by pk_id_curso", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            //Mostrando os cursos na grade
            dgvCurso.DataSource = datb;
            dgvCurso.Refresh();

            checarLinhasDgv();

            //Limpando as radiobutton
            radioIdCurso.Checked = true;
            radioNomeCurso.Checked = false;
            metroTxtBoxPesquisar.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Verificando se foi digitado algo na barra de pesquisa
            if (metroTxtBoxPesquisar.Text != "")
            {
                //Verificando se o radio button de id do curso está selecionado
                if (radioIdCurso.Checked)
                {
                    try
                    {
                        //Consultando os cursos no banco de dados filtrando por id
                        dados = new SqlDataAdapter("select pk_id_curso, nome_curso from Curso where pk_id_curso Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //Verificando se o radio button de nome do curso está selecionado
                else if (radioNomeCurso.Checked)
                {
                    try
                    {
                        //Consultando os cursos no banco de dados filtrando por nome
                        dados = new SqlDataAdapter("select pk_id_curso, nome_curso from Curso where nome_curso Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //Mostrando os cursos na grade
                datb = new DataTable();
                dados.Fill(datb);
                dgvCurso.DataSource = datb;

                checarLinhasDgv();
            }

            else
            {
                MessageBox.Show("Nenhum dado inserido para pesquisa");
                return;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CursoNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvCurso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new CursoEditar(_principal, curso));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvCurso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de exclusão passando esses dados 
                _principal.OpenChildForm(new CursoExcluir(_principal, curso));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvCurso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de consulta passando esses dados 
                _principal.OpenChildForm(new CursoConsultar(_principal, curso));
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
                string caminho = @"C:\pdf\" + DateTime.Now.ToString("yyyyMMdd") + "_RelatorioCurso_SmallLibrary.pdf";

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
                cabecalho.Add("\n RELAÇÃO DE CURSOS");

                //separador de linha
                Paragraph l = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); //Linha separadora

                //Classificação
                Paragraph classificacao = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
                classificacao.Alignment = Element.ALIGN_LEFT; //Alinha o conteudo a esquerda
                classificacao.Add("Classificação: Identificação do Curso \n\n");

                //Tabela
                PdfPTable table = new PdfPTable(2);
                table.DefaultCell.FixedHeight = 20;
                table.WidthPercentage = 100;

                table.AddCell("ID do Curso");
                table.AddCell("Nome do Curso");

                for (int i = 0; i < (dgvCurso.Rows.Count); i++)
                {
                    table.AddCell(dgvCurso[0, i].Value.ToString());
                    table.AddCell(dgvCurso[1, i].Value.ToString());
                }

                //Necessário abrir para poder inserir os elementos
                doc.Open();
                doc.Add(smallibrary);
                doc.Add(cabecalho);
                doc.Add(l);
                doc.Add(classificacao);
                doc.Add(table);
                doc.Close();

                MessageBox.Show("PDF gerado com sucesso.");

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
