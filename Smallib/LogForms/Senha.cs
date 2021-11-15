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
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
            metroTxtBoxSenha.UseSystemPasswordChar = true;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //abrindo a conexão com o banco de dados
            conectar.Open();

            //verifica se um usuário já foi criado
            SqlCommand verificarUsuario = new SqlCommand("select * from Usuario", conectar);
            bool resultadoUsuario = verificarUsuario.ExecuteReader().HasRows;

            if(resultadoUsuario == true)
            {
                Login login = new Login();
                login.ShowDialog();
                Close();
            }

            //fechando a conexão com o banco de dados
            conectar.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //abrindo a conexão com o banco de dados
                conectar.Open();

                //verifica se a senha digitada é igual à que está no banco de dados e retorna true ou false
                SqlCommand verificarSenha = new SqlCommand("select * from Senha where senha_master = HASHBYTES('sha2_512', '" + metroTxtBoxSenha.Text + "')", conectar);
                bool resultadoSenha = verificarSenha.ExecuteReader().HasRows;

                //fechando a conexão com o banco de dados
                conectar.Close();

                //abrindo a conexão com o banco de dados
                conectar.Open();

                //verifica se a senha já foi alterada alguma vez e retorna true ou false
                SqlCommand verificarAlteracao = new SqlCommand("select alterada from Senha where alterada = 0", conectar);
                bool resultadoAlteracao = verificarAlteracao.ExecuteReader().HasRows;

                //fechando a conexão com o banco de dados
                conectar.Close();

                //abrindo a conexão com o banco de dados
                conectar.Open();

                //verifica se a senha já foi alterada alguma vez e retorna true ou false
                SqlCommand verificarUsuario = new SqlCommand("select * from Usuario", conectar);
                bool resultadoUsuario = verificarUsuario.ExecuteReader().HasRows;

                if (resultadoSenha == true && resultadoAlteracao == true)
                {
                    ModificarSenha modificar = new ModificarSenha();
                    this.Hide();
                    modificar.ShowDialog();
                    this.Close();
                }

                else if (resultadoSenha == true && resultadoUsuario == false)
                {
                    Cadastro cadastro = new Cadastro();
                    this.Hide();
                    cadastro.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Senha inválida! tente novamente");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Não foi possivel estabelecer a conexão, verifique o código! " + error);
            }

            conectar.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo fechar o programa?", "Fechar o programa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (metroTxtBoxSenha.UseSystemPasswordChar == false)
            {
                metroTxtBoxSenha.UseSystemPasswordChar = true;
            }
            else if (metroTxtBoxSenha.UseSystemPasswordChar == true)
            {
                metroTxtBoxSenha.UseSystemPasswordChar = false;
            }
        }
    }
}
