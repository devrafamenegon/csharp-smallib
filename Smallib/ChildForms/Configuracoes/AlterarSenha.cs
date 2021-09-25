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

namespace Smallib.ChildForms.Configuracoes
{
    public partial class AlterarSenha : Form
    {
        private string _userLogin, senhaAtual, senhaNova, confirmarSenhaNova;
        private Principal _principal;

        public AlterarSenha(Principal principal, string userLogin)
        {
            InitializeComponent();
            _principal = principal;
            _userLogin = userLogin;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar a operação?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                _principal.OpenChildForm(new ConfiguracoesRoot(_principal, _userLogin));
                this.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            senhaAtual = txtBoxSenhaAtual.Text;
            senhaNova = txtBoxNovaSenha.Text;
            confirmarSenhaNova = txtBoxConfirmarSenha.Text;

            if (senhaAtual == "" || senhaNova == "" || confirmarSenhaNova == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            else
            {
                //Abrindo conexão com o banco
                conectar.Open();

                //Nomeando o objeto da conexão
                SqlCommand login = new SqlCommand("SELECT * FROM Usuario WHERE login_usuario = '" + _userLogin + "' AND senha_usuario = HASHBYTES('sha2_512', '" + senhaAtual + "')", conectar);
                bool result = login.ExecuteReader().HasRows;

                //Fechando conexão
                conectar.Close();

                if (result)
                {
                    if (senhaNova == confirmarSenhaNova)
                    {
                        try
                        {
                            //Abrindo conexão com o banco
                            conectar.Open();

                            //Nomeando o objeto da conexão
                            SqlCommand update_password = new SqlCommand();

                            update_password.CommandText = ("UPDATE Usuario SET senha_usuario = HASHBYTES('sha2_512', '" + senhaNova + "') WHERE login_usuario = '" + _userLogin + "'");

                            //Rodando o comando no banco de dados
                            update_password.Connection = conectar;
                            update_password.ExecuteNonQuery();

                            conectar.Close();

                            //MessageBox para informar que a senha foi alterada com sucesso
                            if (MessageBox.Show("Senha modificada com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                _principal.OpenChildForm(new ConfiguracoesRoot(_principal, _userLogin));
                            }
                        }

                        //Caso algo de errado no processo
                        catch
                        {
                            MessageBox.Show("Não foi possível alterar sua senha.", "Aviso:", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("As senhas são diferentes, tente novamente", "Aviso:", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Senha de usuário incorreta, tente novamente", "Aviso:", MessageBoxButtons.OK);
                }
            }
        }

        private void checkBoxSenhaAtual_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxSenhaAtual.UseSystemPasswordChar == false)
            {
                txtBoxSenhaAtual.UseSystemPasswordChar = true;
            }
            else if (txtBoxSenhaAtual.UseSystemPasswordChar == true)
            {
                txtBoxSenhaAtual.UseSystemPasswordChar = false;
            }
        }

        private void checkBoxNovaSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxNovaSenha.UseSystemPasswordChar == false)
            {
                txtBoxNovaSenha.UseSystemPasswordChar = true;

                if (txtBoxConfirmarSenha.UseSystemPasswordChar == false)
                {
                    txtBoxConfirmarSenha.UseSystemPasswordChar = true;
                }
            }
            else if (txtBoxNovaSenha.UseSystemPasswordChar == true)
            {
                txtBoxNovaSenha.UseSystemPasswordChar = false;

                if (txtBoxConfirmarSenha.UseSystemPasswordChar == true)
                {
                    txtBoxConfirmarSenha.UseSystemPasswordChar = false;
                }
            }
        }
    }
}