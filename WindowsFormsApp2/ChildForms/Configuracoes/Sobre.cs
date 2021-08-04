using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smallib.ChildForms.Configuracoes
{
    public partial class Sobre : Form
    {
        Principal _principal;
        string _userLogin;
        public Sobre(Principal principal, string userLogin)
        {
            InitializeComponent();
            _principal = principal;
            _userLogin = userLogin;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new ConfiguracoesRoot(_principal, _userLogin));
        }
    }
}
