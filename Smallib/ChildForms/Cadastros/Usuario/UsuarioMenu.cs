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

namespace Smallib.ChildForms
{
    public partial class UsuarioMenu : Form
    {
        //instanciando a classe
        Cadastro_Usuario cadastro_usuario = new Cadastro_Usuario();

        private Principal _principal;
        void checarLinhasDgv()
        {
            //Verificando se a grade está vazia
            if (dgvUsuario.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        public UsuarioMenu(Principal principal)
        {
            InitializeComponent();
            conectar.Close();

            _principal = principal;

            dados = new SqlDataAdapter("SELECT pk_id_usuario, nome_usuario, login_usuario FROM Usuario ORDER BY pk_id_usuario asc", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            dgvUsuario.DataSource = datb;
            dgvUsuario.Refresh();

            checarLinhasDgv();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Filtra utilizando o ID
            if (radioIdUsuario.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_usuario, nome_usuario, login_usuario from Usuario where pk_id_usuario Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvUsuario.DataSource = datb;
            }

            //Filtra utilizando o nome do usuario
            else if (radioNomeUsuario.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_usuario, nome_usuario, login_usuario from Usuario where nome_usuario Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvUsuario.DataSource = datb;
            }

            //Filtra utilizando o login do usuario
            else if (radioLoginUsuario.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_usuario, nome_usuario, login_usuario from Usuario where login_usuario Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvUsuario.DataSource = datb;
            }

            //Se nenhum radioButton for selecionado
            else
            {
                MessageBox.Show("Nenhuma opção de pesquisa selecionada, tente novamente");
            }

            checarLinhasDgv();
        }

        private void radioIdUsuario_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioNomeUsuario_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioLoginUsuario_CheckedChanged(object sender, EventArgs e)
        {
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dados = new SqlDataAdapter("SELECT pk_id_usuario, nome_usuario, login_usuario FROM Usuario ORDER BY pk_id_usuario asc", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvUsuario.DataSource = datb;

            radioIdUsuario.Checked = true;
            radioNomeUsuario.Checked = false;
            radioLoginUsuario.Checked = false;

            metroTxtBoxPesquisar.Text = "";

            checarLinhasDgv();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new UsuarioNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Se caso nenhuma linha for selecionada
            if (dgvUsuario.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição!");
                return;
            }

            //Se apenas uma linha for selecionada
            else
            {
                //passando os valores da linha selecionada para a instancia da classe
                cadastro_usuario.pk_id_usuario = Convert.ToInt32(dgvUsuario[0, dgvUsuario.CurrentRow.Index].Value.ToString());
                cadastro_usuario.nome_usuario = dgvUsuario[1, dgvUsuario.CurrentRow.Index].Value.ToString();
                cadastro_usuario.login_usuario = dgvUsuario[2, dgvUsuario.CurrentRow.Index].Value.ToString();

                //Chama o forms de edição de usuário passando a instancia da classe com os valores da linha selecionada
                _principal.OpenChildForm(new UsuarioEditar(_principal, cadastro_usuario));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Se caso nenhuma linha for selecionada
            if (dgvUsuario.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão!");
                return;
            }

            //Se apenas uma linha for selecionada
            else
            {
                //passando os valores da linha selecionada para a instancia da classe
                cadastro_usuario.pk_id_usuario = Convert.ToInt32(dgvUsuario[0, dgvUsuario.CurrentRow.Index].Value.ToString());
                cadastro_usuario.nome_usuario = dgvUsuario[1, dgvUsuario.CurrentRow.Index].Value.ToString();
                cadastro_usuario.login_usuario = dgvUsuario[2, dgvUsuario.CurrentRow.Index].Value.ToString();

                //Chama o forms de edição de usuário passando a instancia da classe com os valores da linha selecionada
                _principal.OpenChildForm(new UsuarioExcluir(_principal, cadastro_usuario));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Se caso nenhuma linha for selecionada
            if (dgvUsuario.SelectedCells.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta!");
                return;
            }

            //Se apenas uma linha for selecionada
            else
            {
                //passando os valores da linha selecionada para a instancia da classe
                cadastro_usuario.pk_id_usuario = Convert.ToInt32(dgvUsuario[0, dgvUsuario.CurrentRow.Index].Value.ToString());
                cadastro_usuario.nome_usuario = dgvUsuario[1, dgvUsuario.CurrentRow.Index].Value.ToString();
                cadastro_usuario.login_usuario = dgvUsuario[2, dgvUsuario.CurrentRow.Index].Value.ToString();

                //Chama o forms de edição de usuário passando a instancia da classe com os valores da linha selecionada
                _principal.OpenChildForm(new UsuarioConsultar(_principal, cadastro_usuario));
            }
        }
    }
}
