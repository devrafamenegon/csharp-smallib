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

namespace Smallib
{
    public partial class Login : Form
    {
        string login_usuario, senha_usuario;

        Cadastro_Usuario cadastro_usuario = new Cadastro_Usuario();

        public Login()
        {
            InitializeComponent();
        }
        public void AdicionarTextoLogin()
        {
            if (string.IsNullOrWhiteSpace(txtBoxLogin.Text))
            {
                txtBoxLogin.Text = " Digite seu login...";
                txtBoxLogin.ForeColor = Color.FromArgb(197, 197, 197);
            }
        }

        public void RemoverTextoLogin()
        {
            if (txtBoxLogin.Text == " Digite seu login...")
            {
                txtBoxLogin.Text = "";
                txtBoxLogin.ForeColor = Color.FromArgb(46, 81, 116);
            }
        }

        public void AdicionarTextoSenha()
        {
            if (string.IsNullOrWhiteSpace(txtBoxSenha.Text))
            {
                txtBoxSenha.Text = " Digite sua senha...";
                txtBoxSenha.ForeColor = Color.FromArgb(197, 197, 197);
                txtBoxSenha.UseSystemPasswordChar = false;
            }
        }

        public void RemoverTextoSenha()
        {
            if (txtBoxSenha.Text == " Digite sua senha...")
            {
                txtBoxSenha.Text = "";
                txtBoxSenha.ForeColor = Color.FromArgb(46, 81, 116);
                txtBoxSenha.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AdicionarTextoLogin();
            AdicionarTextoSenha();
        }

        private void txtBoxLogin_MouseClick(object sender, MouseEventArgs e)
        {
            RemoverTextoLogin();
        }

        private void txtBoxSenha_MouseClick(object sender, MouseEventArgs e)
        {
            RemoverTextoSenha();
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxSenha.UseSystemPasswordChar == false & txtBoxSenha.Text != " Digite sua senha...")
            {
                txtBoxSenha.UseSystemPasswordChar = true;
            }
            else if (txtBoxSenha.UseSystemPasswordChar == true & txtBoxSenha.Text != " Digite sua senha...")
            {
                txtBoxSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo fechar o programa?", "Fechar o programa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            login_usuario = txtBoxLogin.Text;
            senha_usuario = txtBoxSenha.Text;

            if (string.IsNullOrWhiteSpace(txtBoxLogin.Text) || string.IsNullOrWhiteSpace(txtBoxSenha.Text) || txtBoxSenha.Text == " Digite sua senha..." || txtBoxLogin.Text == " Digite seu login...")
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
            else
            {
                try
                {
                    conectar.Close();

                    conectar.Open(); //abrindo a conexão com o banco de dados

                    SqlCommand verificar = new SqlCommand("select * from Usuario where login_usuario = '" + login_usuario + "' AND senha_usuario = HASHBYTES('sha2_512', '" + senha_usuario + "')", conectar);
                    bool resultado = verificar.ExecuteReader().HasRows;

                    conectar.Close();

                    if (resultado == true)
                    {
                        cadastro_usuario.login_usuario = login_usuario;

                        Principal principal = new Principal(cadastro_usuario);
                        this.Hide();
                        principal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!");
                    }

                    conectar.Close(); //fechando a conexão com o banco de dados
                }

                catch (SqlException error)
                {
                    MessageBox.Show("Não foi possivel estabelecer a conexão, verifique o código! " + error);
                }
            }
        }
    }
}
