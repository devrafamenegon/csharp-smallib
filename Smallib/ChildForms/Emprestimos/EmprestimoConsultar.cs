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

namespace Smallib.ChildForms
{
    public partial class EmprestimoConsultar : Form
    {
        Principal _principal;
        public EmprestimoConsultar(Principal principal, Emprestimo_Livro emprestimo_livro)
        {
            InitializeComponent();
            conectar.Close();

            _principal = principal;

            DateTime emp = emprestimo_livro.dt_emprestimo;
            DateTime devPrev = emprestimo_livro.dt_dev_prev_emprestimo;
            DateTime dev;

            if (emprestimo_livro.dt_devolucao_emprestimo.ToShortDateString().ToString() != "01/01/0001")
            {
                dev = emprestimo_livro.dt_devolucao_emprestimo;
                txtBoxDataDevolucao.Text = dev.ToShortDateString();
            }
            else
            {
                txtBoxDataDevolucao.Text = "N/A";
            }

            txtBoxIdEmprestimo.Text = emprestimo_livro.pk_id_emprestimo.ToString();
            comboBoxNomeLeitor.Text = emprestimo_livro.nome_leitor;
            comboBoxTituloLivro.Text = emprestimo_livro.titulo_livro;
            txtBoxDataEmprestimo.Text = emp.ToShortDateString();
            txtBoxDevolucaoPrevista.Text = devPrev.ToShortDateString();
            txtBoxStatusEmprestimo.Text = emprestimo_livro.status_emprestimo.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new EmprestimoMenu(_principal));
        }
    }
}
