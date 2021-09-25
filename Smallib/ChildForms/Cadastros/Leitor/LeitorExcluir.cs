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

namespace Smallib.ChildForms.Cadastros.Leitores
{
    public partial class LeitorExcluir : Form
    {
        Principal _principal;

        int idleitor;

        public LeitorExcluir(Principal principal, Cadastro_Leitor cadastro_leitor_01)
        {
            InitializeComponent();
            _principal = principal;

            idleitor = cadastro_leitor_01.pk_id_leitor;
            txtBoxIdLeitor.Text = (cadastro_leitor_01.pk_id_leitor).ToString();
            txtBoxNomeLeitor.Text = cadastro_leitor_01.nome_leitor;
            txtBoxEmailLeitor.Text = cadastro_leitor_01.email_leitor;
            txtBoxTelefoneLeitor.Text = cadastro_leitor_01.tel_cel_leitor;
            txtBoxRgLeitor.Text = cadastro_leitor_01.rg_leitor;
            txtBoxDataNascLeitor.Text = cadastro_leitor_01.dtnasc_leitor.ToShortDateString();
            txtBoxDataAttLeitor.Text = cadastro_leitor_01.dtcad_leitor.ToShortDateString();
            txtBoxTipoLeitor.Text = cadastro_leitor_01.tipo_leitor;
            txtBoxStatusLeitor.Text = cadastro_leitor_01.status_leitor;
            txtBoxCidadeLeitor.Text = cadastro_leitor_01.cidade_leitor;
            txtBoxClasseLeitor.Text = cadastro_leitor_01.classe_leitor;
            txtBoxCursoLeitor.Text = cadastro_leitor_01.curso_leitor;
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LeitorMenu(_principal));
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //Messagebox para selecionar se deseja realmente excluir o leitor
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir o leitor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    //Excluindo a leitor
                    conectar.Open();
                    SqlCommand excluirleitor = new SqlCommand("delete from Leitor where pk_id_leitor=(@idleitor)", conectar);
                    excluirleitor.Parameters.Add(new SqlParameter("@idleitor", idleitor));
                    excluirleitor.ExecuteNonQuery();
                    conectar.Close();
                    MessageBox.Show("Leitor excluído com sucesso");

                    //Retornando a tela inicial
                    _principal.OpenChildForm(new LeitorMenu(_principal));
                }
                catch
                {
                    conectar.Close();
                    MessageBox.Show("Erro ao excluir leitor no banco de dados!!");
                }
            }
        }
    }
}
