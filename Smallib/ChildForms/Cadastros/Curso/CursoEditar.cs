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
    public partial class CursoEditar : Form
    {
        string nome_curso;
        int pk_id_curso;

        Principal _principal;

        public CursoEditar(Principal principal, Cadastro_Curso cadastro_curso_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdCurso.Text = cadastro_curso_01.pk_id_curso.ToString();
            txtBoxNomeCurso.Text = cadastro_curso_01.nome_curso;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CursoMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Passando os valores dos campos para as variáveis
            pk_id_curso = Convert.ToInt32(txtBoxIdCurso.Text);
            nome_curso = txtBoxNomeCurso.Text;

            //Verificando se o curso ja existe no banco
            conectar.Open();
            SqlCommand verificar = new SqlCommand("Select * from Curso where nome_curso = '" + nome_curso + "'", conectar);
            bool resultado = verificar.ExecuteReader().HasRows;

            if (resultado == true)
            {
                //Caso ja exista
                conectar.Close();
                MessageBox.Show("Este curso já existe no banco de dados!!");
            }

            else
            {
                conectar.Close();
                try
                {
                    //Abrindo conexão com o banco
                    conectar.Open();

                    //Nomeando o objeto da conexão
                    SqlCommand update_curso = new SqlCommand();

                    update_curso.CommandText = ("UPDATE Curso set nome_curso = '" + nome_curso + "' WHERE pk_id_curso = " + pk_id_curso);

                    //Rodando o comando no banco de dados
                    update_curso.Connection = conectar;
                    update_curso.ExecuteNonQuery();

                    conectar.Close();

                    //MessageBox para informar que o curso foi editado com sucesso e após ser fechado envia
                    //o usuário para a tela de menu
                    if (MessageBox.Show("Curso editado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        _principal.OpenChildForm(new CursoMenu(_principal));
                    }
                }

                //Caso algo de errado no processo
                catch
                {
                    MessageBox.Show("Não foi possível editar o curso", "Aviso:", MessageBoxButtons.OK);
                }
            }

        }
    }
}
