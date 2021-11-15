using FontAwesome.Sharp;
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

namespace Smallib.ChildForms.Relatorios
{
    public partial class RelEstatisticosRoot : Form
    {
        private Principal _principal;
        private IconButton currentBtn;

        public RelEstatisticosRoot(Principal principal)
        {
            InitializeComponent();
            _principal = principal;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelAdministrativosRoot(_principal));
        }

        private void iconGenerosMaisEmprestados_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelGenerosMaisEmprestados(_principal));
        }

        private void iconLivrosMaisEmprestados_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelLivrosMaisEmprestados(_principal));
        }

        private void iconGenerosMaisEmprestados_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = RGBColors.branco;
            currentBtn.IconColor = RGBColors.branco;
        }

        private void iconGenerosMaisEmprestados_MouseLeave(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = RGBColors.laranja;
            currentBtn.IconColor = RGBColors.laranja;
        }

        private void iconLivrosMaisEmprestados_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = RGBColors.branco;
            currentBtn.IconColor = RGBColors.branco;
        }

        private void iconLivrosMaisEmprestados_MouseLeave(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.ForeColor = RGBColors.laranja;
            currentBtn.IconColor = RGBColors.laranja;
        }
    }
}
