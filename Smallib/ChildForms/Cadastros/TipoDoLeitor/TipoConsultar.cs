using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smallib.ChildForms.Cadastros.Tipo_do_Leitor
{
    public partial class TipoConsultar : Form
    {
        Principal _principal;
        public TipoConsultar(Principal principal, Cadastro_Tipo_Leitor cadastro_tipo_leitor_01)
        {
            InitializeComponent();
            _principal = principal;

            txtBoxIdTipo.Text = cadastro_tipo_leitor_01.pk_id_tipo.ToString();
            txtBoxNomeTipo.Text = cadastro_tipo_leitor_01.nome_tipo;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new TipoMenu(_principal));
        }
    }
}
