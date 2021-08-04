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

namespace Smallib.ChildForms
{
    public partial class UsuarioMenu : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True"); //Variável para conexão com o banco
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        //instanciando a classe
        Cadastro_Usuario cadastro_usuario = new Cadastro_Usuario();

        private Principal _principal;

        public UsuarioMenu(Principal principal)
        {
            InitializeComponent();
            _principal = principal;
        }

        //função para remover o placeholder da barra de pesquisa
        public void RemoverTexto()
        {
            if (txtBoxPesquisar.Text == "Pesquisar")
            {
                txtBoxPesquisar.Text = "";
                txtBoxPesquisar.ForeColor = Color.FromArgb(46, 81, 116);
            }
        }

        //função para adicionar o placeholder da barra de pesquisa
        public void AdicionarTexto()
        {
            if (string.IsNullOrWhiteSpace(txtBoxPesquisar.Text))
            {
                txtBoxPesquisar.Text = "Pesquisar";
                txtBoxPesquisar.ForeColor = Color.FromArgb(197, 197, 197);
            }
        }

        private void UsuarioMenu_Load(object sender, EventArgs e)
        {
            dados = new SqlDataAdapter("SELECT pk_id_usuario, nome_usuario, login_usuario FROM Usuario ORDER BY pk_id_usuario asc", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            dgvUsuario.DataSource = datb;
            dgvUsuario.Refresh();

            AdicionarTexto();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Filtra utilizando o ID
            if (radioIdUsuario.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_usuario, nome_usuario, login_usuario from Usuario where pk_id_usuario Like'%" + txtBoxPesquisar.Text + "%'", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvUsuario.DataSource = datb;
            }

            //Filtra utilizando o nome do usuario
            else if (radioNomeUsuario.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_usuario, nome_usuario, login_usuario from Usuario where nome_usuario Like'%" + txtBoxPesquisar.Text + "%'", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvUsuario.DataSource = datb;
            }

            //Filtra utilizando o login do usuario
            else if (radioLoginUsuario.Checked)
            {
                dados = new SqlDataAdapter("select pk_id_usuario, nome_usuario, login_usuario from Usuario where login_usuario Like'%" + txtBoxPesquisar.Text + "%'", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvUsuario.DataSource = datb;
            }

            //Se nenhum radioButton for selecionado
            else
            {
                MessageBox.Show("Nenhuma opção de pesquisa selecionada, tente novamente");
            }

            if (dgvUsuario.Rows.Count == 0)
            {
                labelDtgv.Text = "Nenhum dado encontrado";
            }
        }

        private void radioIdUsuario_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPesquisar.Enabled = true;
        }

        private void radioNomeUsuario_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPesquisar.Enabled = true;
        }

        private void radioLoginUsuario_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPesquisar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dados = new SqlDataAdapter("SELECT pk_id_usuario, nome_usuario, login_usuario FROM Usuario ORDER BY pk_id_usuario asc", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvUsuario.DataSource = datb;

            radioIdUsuario.Checked = false;
            radioNomeUsuario.Checked = false;
            radioLoginUsuario.Checked = false;
            txtBoxPesquisar.Text = "";
            txtBoxPesquisar.Enabled = false;
            AdicionarTexto();
        }

        private void txtBoxPesquisar_Click(object sender, EventArgs e)
        {
            RemoverTexto();
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
