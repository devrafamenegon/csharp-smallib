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

namespace Smallib.ChildForms.Cadastros.Idioma
{
    public partial class IdiomaMenu : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True"); //Variável para conexão com o banco
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

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
        }

        private void radioNomeIdioma_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;
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

            radioIdIdioma.Checked = false;
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
    }
}
