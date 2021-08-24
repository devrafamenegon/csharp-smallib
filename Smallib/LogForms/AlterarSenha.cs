﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FontAwesome.Sharp;

namespace Smallib
{
    public partial class ModificarSenha : Form
    {
        //string de conexão com o banco de dados
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True"); //Variável para conexão com o banco
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        string senha_master;

        public ModificarSenha()
        {
            InitializeComponent();
            metroTxtBoxNovaSenha.UseSystemPasswordChar = true;
            metroTxtBoxConfirmarNovaSenha.UseSystemPasswordChar = true;
        } 

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (metroTxtBoxNovaSenha.Text == metroTxtBoxConfirmarNovaSenha.Text)
            {
                senha_master = metroTxtBoxNovaSenha.Text;

                try
                {
                    conectar.Open();
                    SqlCommand update_senha = new SqlCommand();

                    update_senha.CommandText = ("UPDATE SenhaMaster set senha_master = '" + senha_master + "', alterada = 1 WHERE senha_master = 'master3ds'");

                    update_senha.Connection = conectar;
                    update_senha.ExecuteNonQuery();
                    conectar.Close();

                    if (MessageBox.Show("Senha master modificada com sucesso!", "Sucesso!", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Cadastro cadastro = new Cadastro();
                        Hide();
                        cadastro.ShowDialog();
                    }
                }

                catch (SqlException error)
                {
                    MessageBox.Show("Não foi possivel estabelecer a conexão, verifique o código! " + error);
                }
            }
            else
            {
                MessageBox.Show("As senhas não são iguais. Tente Novamente");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo fechar o programa?", "Fechar o programa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (metroTxtBoxNovaSenha.UseSystemPasswordChar == false)
            {
                metroTxtBoxNovaSenha.UseSystemPasswordChar = true;

                if (metroTxtBoxConfirmarNovaSenha.UseSystemPasswordChar == false)
                {
                    metroTxtBoxConfirmarNovaSenha.UseSystemPasswordChar = true;
                }
            }
            else if (metroTxtBoxNovaSenha.UseSystemPasswordChar == true)
            {
                metroTxtBoxNovaSenha.UseSystemPasswordChar = false;

                if (metroTxtBoxConfirmarNovaSenha.UseSystemPasswordChar == true)
                {
                    metroTxtBoxConfirmarNovaSenha.UseSystemPasswordChar = false;
                }
            }
        }

        private void TimerAviso_Tick(object sender, EventArgs e)
        {
            TimerAviso.Enabled = false;
            MessageBox.Show("Nunca esqueça esta senha, pois durante o uso do programa será necessário utiliza-la para algumas ações importantes! \n\nCaso ocorra a perda será necessário entrar em contato com os desenvolvedores do programa", "Senha Master", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void iconBtnAlerta_MouseEnter(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;

            currentBtn.IconColor = Color.FromArgb(122, 201, 245);
        }

        private void iconBtnAlerta_MouseLeave(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;

            currentBtn.IconColor = Color.FromArgb(46, 81, 116);
        }

        private void iconBtnAlerta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nunca esqueça esta senha, pois durante o uso do programa será necessário utiliza-la para algumas ações importantes! \n\nCaso ocorra a perda será necessário entrar em contato com os desenvolvedores do programa", "Senha Master", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}