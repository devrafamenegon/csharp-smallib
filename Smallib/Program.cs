using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Smallib
{
    static class Program
    {
        public static SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        public static SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        public static SqlCommandBuilder cmd; //mostra os códigos SQL
        public static DataTable datb; //DataTable é quem vai receber os dados do adapter

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Senha());
        }

    }
}
