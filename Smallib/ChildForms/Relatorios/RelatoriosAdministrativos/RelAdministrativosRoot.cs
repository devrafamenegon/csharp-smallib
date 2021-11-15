using Smallib.ChildForms.Relatorios.RelatoriosAdministrativos;
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
using static Smallib.Program;

namespace Smallib.ChildForms.Relatorios
{
    public partial class RelAdministrativosRoot : Form
    {
        private Principal _principal;
        private IconButton currentBtn;

        public RelAdministrativosRoot(Principal principal)
        {
            InitializeComponent();
            _principal = principal;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelRoot(_principal));
        }

        private void iconEmprestados_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelLivrosEmprestados(_principal));
        }

        private void iconLivrosDevolvidos_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelLivrosDevolvidos(_principal));

        }

        private void iconLeitoresAtraso_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelLeitoresDevPendentes(_principal));
        }

        private void iconHistoricoEmprestimos_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelHistoricoEmprestimos(_principal));
        }

        private void iconLeitoresAtraso_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = RGBColors.branco;
            currentBtn.IconColor = RGBColors.branco;
        }

        private void iconLeitoresAtraso_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = RGBColors.branco;
            currentBtn.ForeColor = RGBColors.verde;
            currentBtn.IconColor = RGBColors.verde;
        }

        private void iconEmprestados_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = RGBColors.branco;
            currentBtn.IconColor = RGBColors.branco;
        }

        private void iconEmprestados_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = RGBColors.branco;
            currentBtn.ForeColor = RGBColors.verde;
            currentBtn.IconColor = RGBColors.verde;
        }

        private void iconLivrosDevolvidos_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = RGBColors.branco;
            currentBtn.IconColor = RGBColors.branco;
        }

        private void iconLivrosDevolvidos_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = RGBColors.branco;
            currentBtn.ForeColor = RGBColors.verde;
            currentBtn.IconColor = RGBColors.verde;
        }

        private void iconHistoricoEmprestimos_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = RGBColors.branco;
            currentBtn.IconColor = RGBColors.branco;
        }

        private void iconHistoricoEmprestimos_MouseLeave(object sender, EventArgs e)
        {
            currentBtn.BackColor = RGBColors.branco;
            currentBtn.ForeColor = RGBColors.verde;
            currentBtn.IconColor = RGBColors.verde;
        }
    }
}
