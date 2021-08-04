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


namespace Smallib.ChildForms.Cadastros.Genero
{
    public partial class GeneroMenu : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True"); //Variável para conexão com o banco
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        Principal _principal;

        //instanciando a classe
        Cadastro_Genero cadastro_genero = new Cadastro_Genero();


        public GeneroMenu(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            dados = new SqlDataAdapter("select pk_id_genero, nome_genero from Genero order by pk_id_genero asc", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            dgvGenero.DataSource = datb;
            dgvGenero.Refresh();
        }

        private void radioIdGenero_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioNomeGenero_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;
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
                MessageBox.Show("Nenhuma opção de pesquisa selecionada, tente novamente");
            }

            if (dgvGenero.Rows.Count == 0)
            {
                labelDtgv.Text = "Nenhum dado encontrado";
            }

            else
            {
                labelDtgv.Text = "";
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dados = new SqlDataAdapter("select pk_id_genero, nome_genero from Genero order by pk_id_genero asc", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvGenero.DataSource = datb;

            radioIdGenero.Checked = false;
            radioNomeGenero.Checked = false;
            metroTxtBoxPesquisar.Text = "";
            metroTxtBoxPesquisar.Enabled = false;
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
                //passando os valores da linha selecionada para a instancia da classe
                cadastro_genero.pk_id_genero = Convert.ToInt32(dgvGenero[0, dgvGenero.CurrentRow.Index].Value.ToString());
                cadastro_genero.nome_genero = dgvGenero[1, dgvGenero.CurrentRow.Index].Value.ToString();

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
                //passando os valores da linha selecionada para a instancia da classe
                cadastro_genero.pk_id_genero = Convert.ToInt32(dgvGenero[0, dgvGenero.CurrentRow.Index].Value.ToString());
                cadastro_genero.nome_genero = dgvGenero[1, dgvGenero.CurrentRow.Index].Value.ToString();

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
                //passando os valores da linha selecionada para a instancia da classe
                cadastro_genero.pk_id_genero = Convert.ToInt32(dgvGenero[0, dgvGenero.CurrentRow.Index].Value.ToString());
                cadastro_genero.nome_genero = dgvGenero[1, dgvGenero.CurrentRow.Index].Value.ToString();

                //Chama o forms de edição de gênero passando a instancia da classe com os valores da linha selecionada
                _principal.OpenChildForm(new GeneroConsultar(_principal, cadastro_genero));
            }
        }
    }
}
