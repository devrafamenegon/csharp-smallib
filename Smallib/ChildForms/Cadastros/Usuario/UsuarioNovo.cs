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
    public partial class UsuarioNovo : Form
    {
        string nome_usuario, login_usuario, senha_usuario, confirmar_senha_usuario;

        private Principal _principal;
        public UsuarioNovo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;
        }

        private void UsuarioNovo_Load(object sender, EventArgs e)
        {
            txtBoxSenhaUsuario.UseSystemPasswordChar = true;
            txtBoxConfirmarSenhaUsuario.UseSystemPasswordChar = true;

            conectar.Open();

            SqlCommand obterTotalId = new SqlCommand("select ident_current('Usuario')", conectar);
            SqlCommand obterId = new SqlCommand("select pk_id_usuario from Usuario", conectar);
            int numeroTotalId = Convert.ToInt32(obterTotalId.ExecuteScalar());
            int numeroId = Convert.ToInt32(obterId.ExecuteScalar());

            //se caso a quantidade de pk_id_idioma forem maiores do que 0, então soma-se 1 no total de identificadores criados
            if (numeroId > 0)
            {
                txtBoxIdUsuario.Text = " " + (numeroTotalId + 1).ToString();
            }

            //caso o a quantidade de pk_id_usuario for 0,
            //pega-se o valor total de identificadores já criados, pois estes começam sua contagem valendo 1
            else
            {
                txtBoxIdUsuario.Text = " " + numeroTotalId.ToString();
            }

            conectar.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new UsuarioMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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
                    //Verificando se o usuário ja existe no banco
                    conectar.Open();
                    SqlCommand verificar = new SqlCommand("SELECT * FROM Usuario WHERE login_usuario = '" + login_usuario + "'", conectar);
                    bool resultado = verificar.ExecuteReader().HasRows;

                    conectar.Close();

                    if (resultado == true)
                    {
                        MessageBox.Show("Este login de usuário já existe no banco de dados!!");
                    }
                    else
                    {
                        try
                        {
                            //abrindo conexão
                            conectar.Open();

                            //objeto da conexão
                            SqlCommand cadastrar_usuario = new SqlCommand();

                            cadastrar_usuario.CommandText = "INSERT INTO Usuario (nome_usuario, login_usuario, senha_usuario, senha_alterada) VALUES('" + nome_usuario + "','" + login_usuario + "', HASHBYTES('sha2_512', '" + senha_usuario + "'), 0)";

                            //Rodando o comando no banco de dados
                            cadastrar_usuario.Connection = conectar;
                            cadastrar_usuario.ExecuteNonQuery();

                            //MessageBox para informar o usuário que o registro foi bem sucessido
                            if (MessageBox.Show("Usuário criado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                //após fechar o MessageBox, busca-se o novo número para ser mostrado no campo ID
                                SqlCommand obterTotalId = new SqlCommand("select ident_current('Usuario')", conectar);
                                SqlCommand obterId = new SqlCommand("select pk_id_usuario from Usuario", conectar);
                                int numeroTotalId = Convert.ToInt32(obterTotalId.ExecuteScalar());
                                int numeroId = Convert.ToInt32(obterId.ExecuteScalar());

                                //se caso a quantidade de pk_id_usuario forem maiores do que 0, então soma-se 2 no total de identificadores criados
                                if (numeroId > 0)
                                {
                                    txtBoxIdUsuario.Text = " " + (numeroTotalId + 1).ToString();
                                }

                                //caso o a quantidade de usuario for 0,
                                //pega-se o valor total de identificadores já criados + 1
                                else
                                {
                                    txtBoxIdUsuario.Text = " " + numeroTotalId.ToString();
                                }

                                txtBoxNomeUsuario.Clear();
                                txtBoxLoginUsuario.Clear();
                                txtBoxSenhaUsuario.Clear();
                                txtBoxConfirmarSenhaUsuario.Clear();
                            }

                            conectar.Close();
                        }

                        catch (SqlException error)
                        {
                            //SqlException innerException = ex.InnerException as SqlException;
                            if (error != null && error.Number == 2627)
                            {
                                MessageBox.Show("Houve uma falha ao realizar o processo. Usuário " + login_usuario + " já existe!");
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível estabelecer conexão com o banco de dados. Erro n°" + Convert.ToString(error));
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("As senhas não são iguais. Tente Novamente");
                }
            }
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
