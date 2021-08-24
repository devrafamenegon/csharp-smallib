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

namespace Smallib.ChildForms.Cadastros.Editora
{
    public partial class EditoraMenu : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        //Criando um objeto da classe editora
        Cadastro_Editora editora = new Cadastro_Editora();

        Principal _principal;

        void checarLabelDgv()
        {
            //Verificando se a grade está vazia
            if (dgvEditora.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        void dadosEditora()
        {
            try
            {
                dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvEditora.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }

            checarLabelDgv();
        }

        void armazenarDadosDasCelulas()
        {
            //Armazenando os dados da linha selecionada
            editora.pk_id_editora = Convert.ToInt32(dgvEditora[0, dgvEditora.CurrentRow.Index].Value.ToString());
            editora.nome_editora = dgvEditora[1, dgvEditora.CurrentRow.Index].Value.ToString();
            editora.email_editora = dgvEditora[2, dgvEditora.CurrentRow.Index].Value.ToString();
            editora.tel_editora = dgvEditora[3, dgvEditora.CurrentRow.Index].Value.ToString();
            editora.site_editora = dgvEditora[4, dgvEditora.CurrentRow.Index].Value.ToString();
            editora.nome_cidade = dgvEditora[5, dgvEditora.CurrentRow.Index].Value.ToString();
            editora.estado_cidade = dgvEditora[6, dgvEditora.CurrentRow.Index].Value.ToString();
        }

        public EditoraMenu(Principal principal)
        {
            InitializeComponent();
            dadosEditora();

            _principal = principal;
        }

        private void radioIdEditora_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioNomeEditora_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Mostrando as editoras cadastradas no banco na grade
            dadosEditora();

            //Limpando os radiobuttons
            radioIdEditora.Checked = false;
            radioNomeEditora.Checked = false;

            //Limpando a barra de pesquisa
            metroTxtBoxPesquisar.Text = "";

            metroTxtBoxPesquisar.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Verificando se o radio button de id da editora está selecionado
            if (radioIdEditora.Checked)
            {
                try
                {
                    //Consultando as editoras no banco de dados filtrando por id
                    dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade where pk_id_editora Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            //Verificando se o radio button de nome da editora está selecionado
            else if (radioNomeEditora.Checked)
            {
                try
                {
                    //Consultando as editoras no banco de dados filtrando por nome
                    dados = new SqlDataAdapter("select E.pk_id_editora as pk_id_editora, nome_editora as nome_editora, E.email_editora as email_editora,E.tel_editora as tel_editora, E.site_editora as site_editora, C.nome_cidade as nome_cidade, C.estado_cidade as estado_cidade from Editora as E left join Cidade as C on e.fk_id_cidade_editora=c.pk_id_cidade where nome_editora Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                }
                catch
                {
                    MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                }
            }

            //se nenhum radioButton for selecionado
            else
            {
                MessageBox.Show("Nenhuma opção de pesquisa selecionada");
                return;
            }

            //Mostrando as editoras na grade
            datb = new DataTable();
            dados.Fill(datb);
            dgvEditora.DataSource = datb;

            checarLabelDgv();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new EditoraNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvEditora.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new EditoraEditar(_principal, editora));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvEditora.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de exclusão passando esses dados 
                _principal.OpenChildForm(new EditoraExcluir(_principal, editora));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvEditora.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }
            else
            {
                armazenarDadosDasCelulas();

                //Abrindo a tela de consulta passando esses dados 
                _principal.OpenChildForm(new EditoraConsultar(_principal, editora));
            }
        }
    }
}
