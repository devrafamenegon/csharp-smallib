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

namespace Smallib.ChildForms.Cadastros.Cidade
{
    public partial class CidadeExcluir : Form
    {
        Principal _principal;

        int pk_id_cidade;

        public CidadeExcluir(Principal principal, Cadastro_Cidade cadastro_cidade_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdCidade.Text = cadastro_cidade_01.pk_id_cidade.ToString();
            txtBoxNomeCidade.Text = cadastro_cidade_01.nome_cidade;
            txtEstadoCidade.Text = cadastro_cidade_01.estado_cidade;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            pk_id_cidade = Convert.ToInt32(txtBoxIdCidade.Text);

            //Messagebox para selecionar se deseja realmente excluir a cidade
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir a cidade?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    //Excluindo curso
                    conectar.Open();
                    SqlCommand excluircurso = new SqlCommand("delete from Cidade where pk_id_cidade=(@idcidade)", conectar);
                    excluircurso.Parameters.Add(new SqlParameter("@idcidade", pk_id_cidade));
                    excluircurso.ExecuteNonQuery();
                    conectar.Close();

                    MessageBox.Show("Cidade excluída com sucesso");

                    //Retornando a tela inicial
                    _principal.OpenChildForm(new CidadeMenu(_principal));
                }
                catch (SqlException ex)
                {
                    conectar.Close();
                    if (ex != null && ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível deletar essa cidade, ele está associado a um leitor!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir cidade no banco de dados!!");
                    }
                }
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CidadeMenu(_principal));
        }
    }
}
