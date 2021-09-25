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
using static Smallib.Program;

namespace Smallib.ChildForms.Cadastros.Curso
{
    public partial class CursoExcluir : Form
    {
        Principal _principal;

        int pk_id_curso;

        public CursoExcluir(Principal principal, Cadastro_Curso cadastro_curso_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdCurso.Text = cadastro_curso_01.pk_id_curso.ToString();
            txtBoxNomeCurso.Text = cadastro_curso_01.nome_curso;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            pk_id_curso = Convert.ToInt32(txtBoxIdCurso.Text);

            //Messagebox para selecionar se deseja realmente excluir o curso
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir o curso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    //Excluindo curso
                    conectar.Open();
                    SqlCommand excluircurso = new SqlCommand("delete from Curso where pk_id_curso=(@idcurso)", conectar);
                    excluircurso.Parameters.Add(new SqlParameter("@idcurso", pk_id_curso));
                    excluircurso.ExecuteNonQuery();
                    conectar.Close();

                    MessageBox.Show("Curso excluído com sucesso");

                    //Retornando a tela inicial
                    _principal.OpenChildForm(new CursoMenu(_principal));
                }
                catch (SqlException ex)
                {
                    conectar.Close();
                    if (ex != null && ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível deletar esse curso, ele está associado a um leitor!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir curso no banco de dados!!");
                    }
                }
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CursoMenu(_principal));
        }
    }
}
