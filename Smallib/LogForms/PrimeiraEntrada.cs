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
using FontAwesome.Sharp;
using static Smallib.Program;

namespace Smallib
{
    public partial class PrimeiraEntrada : Form
    {
        string _userLogin, novaSenha, confirmarNovaSenha;

        Cadastro_Usuario cadastro_usuario = new Cadastro_Usuario();

        public PrimeiraEntrada(string userLogin)
        {
            InitializeComponent();
            _userLogin = userLogin;
            metroTxtBoxNovaSenha.UseSystemPasswordChar = true;
            metroTxtBoxConfirmarNovaSenha.UseSystemPasswordChar = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            novaSenha = metroTxtBoxNovaSenha.Text;
            confirmarNovaSenha = metroTxtBoxConfirmarNovaSenha.Text;

            if (novaSenha == "" || confirmarNovaSenha == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            else
            {
                if (novaSenha == confirmarNovaSenha)
                {
                    try
                    {
                        //Abrindo conexão com o banco
                        conectar.Open();

                        //Nomeando o objeto da conexão
                        SqlCommand update_password = new SqlCommand();

                        update_password.CommandText = ("UPDATE Usuario SET senha_usuario = HASHBYTES('sha2_512', '" + novaSenha + "'), senha_alterada = 1 WHERE login_usuario = '" + _userLogin + "'");

                        //Rodando o comando no banco de dados
                        update_password.Connection = conectar;
                        update_password.ExecuteNonQuery();

                        conectar.Close();

                        //MessageBox para informar que a senha foi alterada com sucesso
                        if (MessageBox.Show("Senha modificada com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            cadastro_usuario.login_usuario = _userLogin;

                            Principal principal = new Principal(cadastro_usuario);
                            principal.ShowDialog();
                            this.ShowInTaskbar = false;
                            Close();

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
        }

        private void timerAviso_Tick(object sender, EventArgs e)
        {
            timerAviso.Enabled = false;
            MessageBox.Show("Altere sua senha de usuário, este processo será realizado apenas uma vez.  \n\nCaso queira alterar sua senha novamente, encontrará esta opção em: Configurações > Alterar senha.", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void iconBtnAlerta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Altere sua senha de usuário, este processo será realizado apenas uma vez.  \n\nCaso queira alterar sua senha novamente, encontrará esta opção em: Configurações > Alterar senha.", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void iconBtnAlerta_MouseEnter(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;

            currentBtn.IconColor = Color.FromArgb(122, 201, 245);
        }

        private void iconBtnAlerta_MouseLeave(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;

            currentBtn.IconColor = Color.FromArgb(46, 81, 116);
        }

        private void checkBoxNovaSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (metroTxtBoxNovaSenha.UseSystemPasswordChar == false)
            {
                metroTxtBoxNovaSenha.UseSystemPasswordChar = true;

                if (metroTxtBoxConfirmarNovaSenha.UseSystemPasswordChar == false)
                {
                    metroTxtBoxConfirmarNovaSenha.UseSystemPasswordChar = true;
                }
            }
            else if (metroTxtBoxNovaSenha.UseSystemPasswordChar == true)
            {
                metroTxtBoxNovaSenha.UseSystemPasswordChar = false;

                if (metroTxtBoxConfirmarNovaSenha.UseSystemPasswordChar == true)
                {
                    metroTxtBoxConfirmarNovaSenha.UseSystemPasswordChar = false;
                }
            }
        }
    }
}
