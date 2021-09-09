using FontAwesome.Sharp;
using Smallib.ChildForms.Relatorios;
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
    public partial class RelatoriosRoot : Form
    {
        private IconButton currentBtn;

        private Principal _principal;

        public RelatoriosRoot(Principal principal)
        {
            InitializeComponent();
            _principal = principal;
        }

        private void iconAdministrativos_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelAdministrativos(_principal));
        }

        private void iconEstatiscos_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelEstatisticos(_principal));
        }

        private void iconCadastros_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = Principal.RGBColors.branco;
            currentBtn.IconColor = Principal.RGBColors.branco;
        }

        private void iconCadastros_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = Principal.RGBColors.branco;
            currentBtn.ForeColor = Principal.RGBColors.azul;
            currentBtn.IconColor = Principal.RGBColors.azul;
        }

        private void iconAdministrativos_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = Principal.RGBColors.branco;
            currentBtn.IconColor = Principal.RGBColors.branco;
        }

        private void iconAdministrativos_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = Principal.RGBColors.branco;
            currentBtn.ForeColor = Principal.RGBColors.verde;
            currentBtn.IconColor = Principal.RGBColors.verde;
        }

        private void iconEstatiscos_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = Principal.RGBColors.branco;
            currentBtn.IconColor = Principal.RGBColors.branco;
        }

        private void iconEstatiscos_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = Principal.RGBColors.branco;
            currentBtn.ForeColor = Principal.RGBColors.laranja;
            currentBtn.IconColor = Principal.RGBColors.laranja;
        }
    }
}
