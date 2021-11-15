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
    public partial class UsuarioSenhaMaster : Form
    {
        private Principal _principal;

        public UsuarioSenhaMaster(Principal principal)
        {
            InitializeComponent();
            _principal = principal;
        }

        public void AdicionarTexto()
        {
            if (string.IsNullOrWhiteSpace(txtBoxSenha.Text))
            {
                txtBoxSenha.Text = " Digite sua senha master...";
                txtBoxSenha.ForeColor = Color.FromArgb(197, 197, 197);
                txtBoxSenha.UseSystemPasswordChar = false;
            }
        }

        public void RemoverTexto()
        {
            if (txtBoxSenha.Text == " Digite sua senha master...")
            {
                txtBoxSenha.Text = "";
                txtBoxSenha.ForeColor = Color.FromArgb(46, 81, 116);
                txtBoxSenha.UseSystemPasswordChar = true;
            }
        }

        private void UsuarioSenhaMaster_Load(object sender, EventArgs e)
        {
            AdicionarTexto();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // abrindo a conexão com o banco de dados
                conectar.Open();

                //verifica se a senha digitada é igual à que está no banco de dados e retorna true ou false
                SqlCommand verificarSenha = new SqlCommand("select * from Senha where senha_master = HASHBYTES('sha2_512', '" + txtBoxSenha.Text + "')", conectar);
                bool resultadoSenha = verificarSenha.ExecuteReader().HasRows;

                if (resultadoSenha == true)
                {
                    _principal.OpenChildForm(new UsuarioMenu(_principal));
                }

                else
                {
                    MessageBox.Show("Senha inválida! tente novamente");
                    txtBoxSenha.Clear();
                }
            }

            catch (SqlException error)
            {
                MessageBox.Show("Não foi possivel estabelecer a conexão, verifique o código! " + error);
            }

            conectar.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CadastrosRoot(_principal));
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxSenha.UseSystemPasswordChar == false & txtBoxSenha.Text != " Digite sua senha master")
            {
                txtBoxSenha.UseSystemPasswordChar = true;
            }
            else if (txtBoxSenha.UseSystemPasswordChar == true & txtBoxSenha.Text != " Digite sua senha master")
            {
                txtBoxSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtBoxSenha_Click(object sender, EventArgs e)
        {
            RemoverTexto();
        }
    }
}
