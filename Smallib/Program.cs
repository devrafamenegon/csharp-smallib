using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Smallib
{
    static class Program
    {
        public static SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        public static SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        public static SqlCommandBuilder cmd; //mostra os códigos SQL
        public static DataTable datb; //DataTable é quem vai receber os dados do adapter

        public struct RGBColors
        {
            public static Color azulEscuro = Color.FromArgb(46, 81, 116);
            public static Color azulClaro = Color.FromArgb(122, 201, 245);
            public static Color azul = Color.FromArgb(44, 136, 217);
            public static Color verde = Color.FromArgb(26, 174, 159);
            public static Color laranja = Color.FromArgb(232, 131, 58);
            public static Color vermelho = Color.FromArgb(211, 69, 91);
            public static Color cinzaEscuro = Color.FromArgb(249, 88, 155);
            public static Color cinza = Color.FromArgb(197, 197, 197);
            public static Color branco = Color.FromArgb(253, 253, 253);
        }

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
