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
    public partial class UsuarioEditar : Form
    {
        int pk_id_usuario;
        string nome_usuario, login_usuario, login_usuario_anterior, senha_usuario, confirmar_senha_usuario;

        private Principal _principal;
        public UsuarioEditar(Principal principal, Cadastro_Usuario c1)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdUsuario.Text = c1.pk_id_usuario.ToString();
            txtBoxNomeUsuario.Text = c1.nome_usuario;
            txtBoxLoginUsuario.Text = c1.login_usuario;
            login_usuario_anterior = c1.login_usuario;
            txtBoxSenhaUsuario.Text = c1.senha_usuario;
            txtBoxConfirmarSenhaUsuario.Text = c1.senha_usuario;

            txtBoxSenhaUsuario.UseSystemPasswordChar = true;
            txtBoxConfirmarSenhaUsuario.UseSystemPasswordChar = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Passando os valores dos campos para as variáveis
            pk_id_usuario = Convert.ToInt32(txtBoxIdUsuario.Text);
            nome_usuario = txtBoxNomeUsuario.Text;
            login_usuario = txtBoxLoginUsuario.Text;
            senha_usuario = txtBoxSenhaUsuario.Text;
            confirmar_senha_usuario = txtBoxConfirmarSenhaUsuario.Text;

            if (nome_usuario == "" || login_usuario == "" || senha_usuario == "" || confirmar_senha_usuario == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            else
            {
                if (senha_usuario == confirmar_senha_usuario)
                {
                    if(login_usuario != login_usuario_anterior)
                    {
                        //Verificando se o login do usuario ja existe no banco
                        conectar.Open();
                        SqlCommand verificar = new SqlCommand("SELECT * FROM Usuario WHERE login_usuario = '" + txtBoxLoginUsuario.Text + "'", conectar);
                        bool resultado = verificar.ExecuteReader().HasRows;
                        conectar.Close();

                        if (resultado == true)
                        {
                            //Caso ja exista
                            MessageBox.Show("Este login do usuario já existe no banco de dados!!");
                        }

                        else
                        {
                            try
                            {
                                //Abrindo conexão com o banco
                                conectar.Open();

                                //Nomeando o objeto da conexão
                                SqlCommand update_usuario = new SqlCommand();

                                update_usuario.CommandText = ("UPDATE Usuario SET nome_usuario = '" + nome_usuario + "', login_usuario = '" + login_usuario + "', senha_usuario = HASHBYTES('sha2_512', '" + senha_usuario + "') WHERE pk_id_usuario = " + pk_id_usuario);

                                //Rodando o comando no banco de dados
                                update_usuario.Connection = conectar;
                                update_usuario.ExecuteNonQuery();

                                conectar.Close();

                                //MessageBox para informar que o usuario foi editado com sucesso e após ser fechado envia
                                //o usuário para a tela de menu
                                if (MessageBox.Show("Usuário editado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    _principal.OpenChildForm(new UsuarioMenu(_principal));
                                }
                            }

                            //Caso algo de errado no processo
                            catch
                            {
                                MessageBox.Show("Não foi possível editar o usuário", "Aviso:", MessageBoxButtons.OK);
                            }
                        }
                    }

                    else
                    {
                        try
                        {
                            //Abrindo conexão com o banco
                            conectar.Open();

                            //Nomeando o objeto da conexão
                            SqlCommand update_usuario = new SqlCommand();

                            update_usuario.CommandText = ("UPDATE Usuario SET nome_usuario = '" + nome_usuario + "', login_usuario = '" + login_usuario + "', senha_usuario = HASHBYTES('sha2_512', '" + senha_usuario + "') WHERE pk_id_usuario = " + pk_id_usuario);

                            //Rodando o comando no banco de dados
                            update_usuario.Connection = conectar;
                            update_usuario.ExecuteNonQuery();

                            conectar.Close();

                            //MessageBox para informar que o usuario foi editado com sucesso e após ser fechado envia
                            //o usuário para a tela de menu
                            if (MessageBox.Show("Usuário editado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                _principal.OpenChildForm(new UsuarioMenu(_principal));
                            }
                        }

                        //Caso algo de errado no processo
                        catch
                        {
                            MessageBox.Show("Não foi possível editar o usuário", "Aviso:", MessageBoxButtons.OK);
                        }
                    }
                   
                }

                else
                {
                    MessageBox.Show("As senhas não são iguais. Tente Novamente");
                }
            }   
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new UsuarioMenu(_principal));
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
