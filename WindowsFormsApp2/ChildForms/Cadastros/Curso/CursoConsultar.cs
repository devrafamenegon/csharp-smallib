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

namespace Smallib.ChildForms.Cadastros.Curso
{
    public partial class CursoConsultar : Form
    {
        Principal _principal;
        public CursoConsultar(Principal principal, Cadastro_Curso cadastro_curso_01)
        {
            InitializeComponent();
            _principal = principal;

            txtBoxIdCurso.Text = cadastro_curso_01.pk_id_curso.ToString();
            txtBoxNomeCurso.Text = cadastro_curso_01.nome_curso;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CursoMenu(_principal));
        }
    }
}
