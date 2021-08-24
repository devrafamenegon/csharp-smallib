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
    public partial class LeitorMenu : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        //Criando um objeto da classe curso
        Cadastro_Leitor leitor = new Cadastro_Leitor();

        Principal _principal;

        public LeitorMenu(Principal principal)
        {
            InitializeComponent();

            //Consultando os cursos no banco de dados               // Falta por as foreign keys
            dados = new SqlDataAdapter("select pk_id_leitor, nome_leitor, email_leitor, tel_cel_leitor, rg_leitor, dtnasc_leitor, dtcad_leitor, classe_leitor, status_leitor from Leitor order by pk_id_leitor", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            //Mostrando os cursos na grade
            dgvLeitor.DataSource = datb;
            dgvLeitor.Refresh();

            if (dgvLeitor.Rows.Count == 0)
            {

                labelDgv.Text = "Nenhum registro encontrado";

            }

            _principal = principal;
        }

        private void radioIdLeitor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioNomeLeitor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioTipoLeitor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LeitorNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvLeitor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada
                // Falta colocar o resto dos dados
                leitor.pk_id_leitor = Convert.ToInt32(dgvLeitor[0, dgvLeitor.CurrentRow.Index].Value.ToString());
                leitor.nome_leitor = dgvLeitor[1, dgvLeitor.CurrentRow.Index].Value.ToString();

                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new LeitorEditar(_principal, leitor));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvLeitor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada
                // Falta colocar o resto dos dados
                leitor.pk_id_leitor = Convert.ToInt32(dgvLeitor[0, dgvLeitor.CurrentRow.Index].Value.ToString());
                leitor.nome_leitor = dgvLeitor[1, dgvLeitor.CurrentRow.Index].Value.ToString();

                //Abrindo a tela de exclusão passando esses dados 
                _principal.OpenChildForm(new LeitorExcluir(_principal, leitor));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvLeitor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada
                leitor.pk_id_leitor = Convert.ToInt32(dgvLeitor[0, dgvLeitor.CurrentRow.Index].Value.ToString());
                leitor.nome_leitor = dgvLeitor[1, dgvLeitor.CurrentRow.Index].Value.ToString();

                //Abrindo a tela de consulta passando esses dados 
                _principal.OpenChildForm(new LeitorConsultar(_principal, leitor));
            }
        }
    }
}
