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
using static Smallib.Program;

namespace Smallib.ChildForms
{
    public partial class RelRoot : Form
    {
        private IconButton currentBtn;

        private Principal _principal;

        public RelRoot(Principal principal)
        {
            InitializeComponent();
            _principal = principal;
        }

        private void iconAdministrativos_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelAdministrativosRoot(_principal));
        }

        private void iconEstatiscos_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelEstatisticosRoot(_principal));
        }

        private void iconCadastros_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = RGBColors.branco;
            currentBtn.IconColor = RGBColors.branco;
        }

        private void iconCadastros_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = RGBColors.branco;
            currentBtn.ForeColor = RGBColors.azul;
            currentBtn.IconColor = RGBColors.azul;
        }

        private void iconAdministrativos_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = RGBColors.branco;
            currentBtn.IconColor = RGBColors.branco;
        }

        private void iconAdministrativos_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = RGBColors.branco;
            currentBtn.ForeColor = RGBColors.verde;
            currentBtn.IconColor = RGBColors.verde;
        }

        private void iconEstatiscos_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = RGBColors.branco;
            currentBtn.IconColor = RGBColors.branco;
        }

        private void iconEstatiscos_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = RGBColors.branco;
            currentBtn.ForeColor = RGBColors.laranja;
            currentBtn.IconColor = RGBColors.laranja;
        }
    }
}
