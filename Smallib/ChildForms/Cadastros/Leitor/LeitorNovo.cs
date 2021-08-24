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
using System.Data.SqlClient;

namespace Smallib.ChildForms.Cadastros.Leitores
{
    public partial class LeitorNovo : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter
        
        // Falta colocar os Dados aaaaaaaaaaaaaaaaaaa
        int pk_id_curso, id;
        string nome_curso, idstring;

        Principal _principal;
        public LeitorNovo(Principal principal)
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
