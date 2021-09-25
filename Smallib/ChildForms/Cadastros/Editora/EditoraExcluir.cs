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


namespace Smallib.ChildForms.Cadastros.Editora
{
    public partial class EditoraExcluir : Form
    {
        int pk_id_editora;

        Principal _principal;
        public EditoraExcluir(Principal principal, Cadastro_Editora cadastro_editora_01)
        {
            InitializeComponent();

            _principal = principal;

            //Recuperando os dados da linha selecionada na tela principal
            pk_id_editora = cadastro_editora_01.pk_id_editora;
            txtBoxIdEditora.Text = pk_id_editora.ToString();
            txtBoxNomeEditora.Text = cadastro_editora_01.nome_editora;
            txtBoxEmailEditora.Text = cadastro_editora_01.email_editora;
            txtBoxTelefoneEditora.Text = cadastro_editora_01.tel_editora;
            txtBoxSiteEditora.Text = cadastro_editora_01.site_editora;

            //Verificando se a cidade não é nula
            if (cadastro_editora_01.nome_cidade != "")
            {
                txtBoxCidadeEditora.Text = cadastro_editora_01.nome_cidade + " - " + cadastro_editora_01.estado_cidade;

            }

            //Caso for nula
            else
            {
                txtBoxCidadeEditora.Text = "";
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new EditoraMenu(_principal));
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //Messagebox para selecionar se deseja realmente excluir a editora
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir a editora?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    //Excluindo a cidade
                    conectar.Open();
                    SqlCommand excluireditora = new SqlCommand("delete from Editora where pk_id_editora=(@ideditora)", conectar);
                    excluireditora.Parameters.Add(new SqlParameter("@ideditora", pk_id_editora));
                    excluireditora.ExecuteNonQuery();
                    conectar.Close();
                    MessageBox.Show("Editora excluída com sucesso");

                    //Retornando a tela inicial
                    _principal.OpenChildForm(new EditoraMenu(_principal));
                }
                catch
                {
                    conectar.Close();
                    MessageBox.Show("Erro ao excluir editora no banco de dados!!");
                }
            }
        }
    }
}
