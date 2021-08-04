using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smallib.ChildForms.Relatorios
{
    public partial class RelCadastros : Form
    {
        private Principal _principal;

        public RelCadastros(Principal principal)
        {
            InitializeComponent();
            _principal = principal;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new RelatoriosRoot(_principal));
        }
    }
}
