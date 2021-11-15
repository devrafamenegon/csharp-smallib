using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Smallib.ChildForms;
using System.Data.SqlClient;
using static Smallib.Program;

namespace Smallib
{
    public partial class Principal : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form currentChildForm;
        public string userLogin;

        public Principal(Cadastro_Usuario usuario)
        {
            InitializeComponent();

            userLogin = usuario.login_usuario.ToString();
            labelNameUser.Text = "Bem vindo, " + userLogin + "!";

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //abrindo a conexão com o banco de dados
            conectar.Open();

            //verifica se a senha já foi alterada alguma vez e retorna true ou false
            SqlCommand verifyUserPasswordAlreadyChanged = new SqlCommand("SELECT senha_alterada FROM Usuario WHERE login_usuario = '"+ userLogin +"' AND senha_alterada = 0", conectar);
            bool result = verifyUserPasswordAlreadyChanged.ExecuteReader().HasRows;

            //fechando a conexão com o banco de dados
            conectar.Close();

            if (result)
            {
                PrimeiraEntrada principal = new PrimeiraEntrada(userLogin);
                principal.ShowDialog();
                this.ShowInTaskbar = false;
                Close();
            }

            OpenChildForm(new Home(this));
            ActivateButton(btnHome, RGBColors.azulEscuro);
        }

       

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn;

                currentBtn.ForeColor = color;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = RGBColors.cinza;
                //currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = RGBColors.azulClaro;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(childForm);
            panelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivateButton(btnHome, RGBColors.azulEscuro);
            OpenChildForm(new Home(this));
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            ActivateButton(btnEmprestimo, RGBColors.azulEscuro);
            OpenChildForm(new EmprestimoMenu(this));
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            ActivateButton(btnDevolucao, RGBColors.azulEscuro);
            OpenChildForm(new Devolucao(this));
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCadastros, RGBColors.azulEscuro);
            OpenChildForm(new CadastrosRoot(this));
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            ActivateButton(btnRelatorios, RGBColors.azulEscuro);
            OpenChildForm(new RelRoot(this));
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            ActivateButton(btnConfiguracoes, RGBColors.azulEscuro);
            OpenChildForm(new ConfiguracoesRoot(this, userLogin));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo fazer logout?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
