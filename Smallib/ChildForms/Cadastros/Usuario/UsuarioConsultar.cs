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

namespace Smallib.ChildForms
{
    public partial class UsuarioConsultar : Form
    {
        private Principal _principal;
        public UsuarioConsultar(Principal principal, Cadastro_Usuario c1)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdUsuario.Text = c1.pk_id_usuario.ToString();
            txtBoxNomeUsuario.Text = c1.nome_usuario;
            txtBoxLoginUsuario.Text = c1.login_usuario;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new UsuarioMenu(_principal));
        }
    }
}
   
 
