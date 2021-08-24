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
    public partial class LeitorEditar : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True"); //Variável para conexão com o banco
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        // Os Dados
        string nome_leitor;
        int pk_id_leitor;

        Principal _principal;

        public LeitorEditar(Principal principal, Cadastro_Leitor cadastro_leitor_01)
        {
            InitializeComponent();
            _principal = principal;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LeitorMenu(_principal));
        }
    }
}
