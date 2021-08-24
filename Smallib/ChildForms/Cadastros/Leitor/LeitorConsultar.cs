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

namespace Smallib.ChildForms.Cadastros.Leitores
{
    public partial class LeitorConsultar : Form
    {
        Principal _principal;
        public LeitorConsultar(Principal principal, Cadastro_Leitor cadastro_leitor_01)
        {
            InitializeComponent();
            _principal = principal;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LeitorMenu(_principal));
        }
    }
}
