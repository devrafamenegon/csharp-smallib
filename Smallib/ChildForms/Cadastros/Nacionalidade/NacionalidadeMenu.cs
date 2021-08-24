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

namespace Smallib.ChildForms.Cadastros.Nacionalidade
{
    public partial class NacionalidadeMenu : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        string pk_id_nacionalidade, nome_nacionaliadde;
        Cadastro_Nacionalidade Cadastro_Nacionalidade = new Cadastro_Nacionalidade();

        Principal _principal;


        public NacionalidadeMenu(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            dados = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade order by pk_id_nacionalidade", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            dgvNacionalidade.DataSource = datb;
            dgvNacionalidade.Refresh();

            if (dgvNacionalidade.Rows.Count == 0)
            {

                labelDgv.Text = "Nenhum registro encontrado";

            }
        }

        private void radioIdNacionalidade_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioNomeNacionalidade_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            labelDgv.Text = "";

            if (radioIdNacionalidade.Checked)
            {
                SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
                dados = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade where pk_id_nacionalidade Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_nacionalidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvNacionalidade.DataSource = datb;

                if (dgvNacionalidade.Rows.Count == 0)
                {

                    labelDgv.Text = "Nenhum registro encontrado";

                }

            }

            else if (radioNomeNacionalidade.Checked)
            {
                SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
                dados = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade where nome_nacionalidade Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_nacionalidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvNacionalidade.DataSource = datb;

                if (dgvNacionalidade.Rows.Count == 0)
                {

                    labelDgv.Text = "Nenhum registro encontrado";

                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
            dados = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade order by pk_id_nacionalidade", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvNacionalidade.DataSource = datb;

            radioIdNacionalidade.Checked = false;
            radioNomeNacionalidade.Checked = false;
            metroTxtBoxPesquisar.Enabled = false;
            metroTxtBoxPesquisar.Text = "";
            labelDgv.Text = "";
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
    }
}
