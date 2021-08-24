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

namespace Smallib.ChildForms.Cadastros.Cidade
{
    public partial class CidadeConsultar : Form
    {
        Principal _principal;
        public CidadeConsultar(Principal principal, Cadastro_Cidade cadastro_cidade_01)
        {
            InitializeComponent();
            _principal = principal;

            txtBoxIdCidade.Text = cadastro_cidade_01.pk_id_cidade.ToString();
            txtBoxNomeCidade.Text = cadastro_cidade_01.nome_cidade;
            txtBoxEstadoCidade.Text = cadastro_cidade_01.estado_cidade;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CidadeMenu(_principal));
        }
    }
}
