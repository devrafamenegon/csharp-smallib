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

namespace Smallib.ChildForms.Cadastros.Tipo_do_Leitor
{
    public partial class TipoExcluir : Form
    {
        int pk_id_tipo;

        Principal _principal;
        public TipoExcluir(Principal principal, Cadastro_Tipo_Leitor cadastro_tipo_leitor_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdTipo.Text = cadastro_tipo_leitor_01.pk_id_tipo.ToString();
            txtBoxNomeTipo.Text = cadastro_tipo_leitor_01.nome_tipo;
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new TipoMenu(_principal));
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            pk_id_tipo = Convert.ToInt32(txtBoxIdTipo.Text);

            //Messagebox para selecionar se deseja realmente excluir o tipo
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir esse tipo de leitor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    //Excluindo tipo
                    conectar.Open();
                    SqlCommand excluirtipo = new SqlCommand("delete from Tipo where pk_id_tipo=(@idtipo)", conectar);
                    excluirtipo.Parameters.Add(new SqlParameter("@idtipo", pk_id_tipo));
                    excluirtipo.ExecuteNonQuery();
                    conectar.Close();

                    MessageBox.Show("Tipo de leitor excluído com sucesso");

                    //Retornando a tela inicial
                    _principal.OpenChildForm(new TipoMenu(_principal));
                }
                catch (SqlException ex)
                {
                    conectar.Close();
                    if (ex != null && ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível deletar esse tipo de leitor, ele está associado a um leitor!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir tipo de leitor no banco de dados!!");
                    }
                }
            }
        }
    }
}
