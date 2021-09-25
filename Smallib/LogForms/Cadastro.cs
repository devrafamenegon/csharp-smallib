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
    public partial class Cadastro : Form
    {
        string nome_usuario, login_usuario, senha_usuario;
        public Cadastro()
        {
            InitializeComponent();
            txtBoxSenhaUsuario.UseSystemPasswordChar = true;
            txtBoxConfirmarSenhaUsuario.UseSystemPasswordChar = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtBoxSenhaUsuario.Text == txtBoxConfirmarSenhaUsuario.Text)
            {
                //Passando o valor digitado no campo de nome para a varíavel nome_idioma
                nome_usuario = txtBoxNomeUsuario.Text;
                login_usuario = txtBoxLoginUsuario.Text;
                senha_usuario = txtBoxSenhaUsuario.Text;

                conectar.Close();

                try
                {
                    //abrindo conexão
                    conectar.Open();

                    //objeto da conexão
                    SqlCommand cadastrar_usuario = new SqlCommand();

                    //condicional para realizar o cadastro
                    if (txtBoxNomeUsuario.Text != "" && txtBoxLoginUsuario.Text != "" && txtBoxSenhaUsuario.Text != "" && txtBoxConfirmarSenhaUsuario.Text != "")
                    {
                        cadastrar_usuario.CommandText = "INSERT INTO Usuario (nome_usuario, login_usuario, senha_usuario, senha_alterada) VALUES('" + nome_usuario + "', '" + login_usuario + "', HASHBYTES('sha2_512', '" + senha_usuario + "'), 1)";

                        //Rodando o comando no banco de dados
                        cadastrar_usuario.Connection = conectar;
                        cadastrar_usuario.ExecuteNonQuery();

                        //MessageBox para informar o usuário que o registro foi bem sucessido
                        if (MessageBox.Show("Usuário criado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            Login login = new Login();
                            Hide();
                            login.ShowDialog();
                        }
                    }

                    //Caso o campo nome seja vazío
                    else
                    {
                        MessageBox.Show("Não foi possível criar o usuário, insira valores válidos", "Aviso:", MessageBoxButtons.OK);
                    }
                }

                //Tratamento de erros
                catch (SqlException error)
                {
                    MessageBox.Show("Não foi possível estabelecer conexão com o banco de dados. Erro n°" + Convert.ToString(error.Number));
                }
            }

            else
            {
                MessageBox.Show("As senhas não são iguais. Tente Novamente");
            }

            conectar.Close();
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxSenhaUsuario.UseSystemPasswordChar == false)
            {
                txtBoxSenhaUsuario.UseSystemPasswordChar = true;

                if (txtBoxConfirmarSenhaUsuario.UseSystemPasswordChar == false)
                {
                    txtBoxConfirmarSenhaUsuario.UseSystemPasswordChar = true;
                }
            }
            else if (txtBoxSenhaUsuario.UseSystemPasswordChar == true)
            {
                txtBoxSenhaUsuario.UseSystemPasswordChar = false;

                if (txtBoxConfirmarSenhaUsuario.UseSystemPasswordChar == true)
                {
                    txtBoxConfirmarSenhaUsuario.UseSystemPasswordChar = false;
                }
            }
        }
    }
}
