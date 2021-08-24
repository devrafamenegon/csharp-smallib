using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smallib.ChildForms.Cadastros.Nacionalidade
{
    public partial class NacionalidadeConsultar : Form
    {
        Principal _principal;
        public NacionalidadeConsultar(Principal principal, Cadastro_Nacionalidade c1)
        {
            InitializeComponent();
            _principal = principal;
            txtBoxIdNacionalidade.Text = c1.pk_id_nacionalidade.ToString();
            txtBoxNomeNacionalidade.Text = c1.nome_nacionalidade;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new NacionalidadeMenu(_principal));
        }
    }
}
