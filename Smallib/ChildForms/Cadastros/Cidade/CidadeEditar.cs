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
    public partial class CidadeEditar : Form
    {
        string nome_cidade, estado_cidade, nome_cidade_global, estado_cidade_global;
        int pk_id_cidade;

        Principal _principal;

        public CidadeEditar(Principal principal, Cadastro_Cidade cadastro_cidade_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdCidade.Text = cadastro_cidade_01.pk_id_cidade.ToString();
            txtBoxNomeCidade.Text = cadastro_cidade_01.nome_cidade;
            comboBoxEstadoCidade.Text = cadastro_cidade_01.estado_cidade;

            nome_cidade_global = cadastro_cidade_01.nome_cidade;
            estado_cidade_global = cadastro_cidade_01.estado_cidade;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CidadeMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        { 
            //Passando os valores dos campos para as variáveis
            pk_id_cidade = Convert.ToInt32(txtBoxIdCidade.Text);
            nome_cidade = txtBoxNomeCidade.Text;
            estado_cidade = comboBoxEstadoCidade.Text;

            if (nome_cidade == nome_cidade_global && estado_cidade == estado_cidade_global)
            {
                _principal.OpenChildForm(new CidadeMenu(_principal));
            }

            else
            {
                if(nome_cidade != "" && estado_cidade != "")
                {
                    //Verificando se a cidade ja existe no banco
                    conectar.Open();
                    SqlCommand verificar = new SqlCommand("Select * from Cidade where nome_cidade = '" + nome_cidade + "' and estado_cidade = '" + estado_cidade + "'", conectar);
                    bool resultado = verificar.ExecuteReader().HasRows;
                    conectar.Close();

                    if (resultado == true)
                    {
                        MessageBox.Show("Esta cidade já existe no banco de dados!!");
                    }

                    else
                    {
                        try
                        {
                            //Alterando a cidade no banco de dados
                            conectar.Open();
                            SqlCommand editarcidade = new SqlCommand("update Cidade set nome_cidade=(@nomedacidade), estado_cidade=(@estadocidade) where pk_id_cidade=(@idcidade)", conectar);
                            editarcidade.Parameters.Add(new SqlParameter("@nomedacidade", nome_cidade));
                            editarcidade.Parameters.Add(new SqlParameter("@idcidade", pk_id_cidade));
                            editarcidade.Parameters.Add(new SqlParameter("@estadocidade", estado_cidade));
                            editarcidade.ExecuteNonQuery();
                            conectar.Close();

                            //MessageBox para informar que a cidade foi editado com sucesso e após ser fechado envia
                            //o usuário para a tela de menu
                            if (MessageBox.Show("Cidade editada com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                _principal.OpenChildForm(new CidadeMenu(_principal));
                            }
                        }

                        //Caso algo de errado no processo
                        catch
                        {
                            MessageBox.Show("Não foi possível editar a cidade", "Aviso:", MessageBoxButtons.OK);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Preencha todos os campos!");

                    //Colocando o foco na textbox de nome da cidade
                    txtBoxNomeCidade.Focus();
                }
            }
        }
    }
}
