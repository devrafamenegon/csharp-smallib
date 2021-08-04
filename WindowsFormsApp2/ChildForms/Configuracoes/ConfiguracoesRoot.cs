using FontAwesome.Sharp;
using Smallib.ChildForms.Configuracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smallib.ChildForms
{
    public partial class ConfiguracoesRoot : Form
    {
        private Principal _principal;
        private IconButton currentBtn;
        private string _userLogin;

        public ConfiguracoesRoot(Principal principal, string userLogin)
        {
            InitializeComponent();
            _principal = principal;
            _userLogin = userLogin;
        }

        private void iconAlterarSenha_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new AlterarSenha(_principal, _userLogin));
        }
        private void iconAlterarSenha_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = Principal.RGBColors.branco;
            currentBtn.IconColor = Principal.RGBColors.branco;
        }

        private void iconAlterarSenha_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = Principal.RGBColors.branco;
            currentBtn.ForeColor = Principal.RGBColors.azul;
            currentBtn.IconColor = Principal.RGBColors.azul;
        }

        private void iconFazerBackup_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = Principal.RGBColors.branco;
            currentBtn.IconColor = Principal.RGBColors.branco;
        }

        private void iconFazerBackup_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = Principal.RGBColors.branco;
            currentBtn.ForeColor = Principal.RGBColors.verde;
            currentBtn.IconColor = Principal.RGBColors.verde;
        }

        private void iconFazerBackup_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new Backup(_principal, _userLogin));
        }

        private void iconSobre_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new Sobre(_principal, _userLogin));
        }

        private void iconSobre_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = Principal.RGBColors.branco;
            currentBtn.IconColor = Principal.RGBColors.branco;
        }

        private void iconSobre_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = Principal.RGBColors.branco;
            currentBtn.ForeColor = Principal.RGBColors.laranja;
            currentBtn.IconColor = Principal.RGBColors.laranja;
        }
    }
}
