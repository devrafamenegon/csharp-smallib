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

namespace Smallib.ChildForms.Configuracoes
{
    public partial class Backup : Form
    {
        private Principal _principal;
        string _userLogin;

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = "";
        string connectionString = "";

        public Backup(Principal principal, string userLogin)
        {
            InitializeComponent();
            _principal = principal;
            _userLogin = userLogin;

            txtBoxServidor.Text = System.Net.Dns.GetHostName().ToUpper() + @"\SQLEXPRESS";
            comboBoxBanco.SelectedItem = 0;

            btnDesconectar.Enabled = false;
            txtBoxLocalBackup.Enabled = false;
            btnProcurarBackup.Enabled = false;
            btnBackup.Enabled = false;
            txtBoxLocalRestaurar.Enabled = false;
            btnProcurarRestaurar.Enabled = false;
            btnRestaurar.Enabled = false;
        }
   
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new ConfiguracoesRoot(_principal, _userLogin));
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString = "Data Source = " + txtBoxServidor.Text.Trim() + "; Trusted_Connection = True;";
                connection = new SqlConnection(connectionString);
                connection.Open();
                sql = "SELECT * FROM sys.databases d WHERE d.database_id > 4";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxBanco.Items.Add(reader[0].ToString());
                }
                txtBoxServidor.Enabled = false;
                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
                comboBoxBanco.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            txtBoxServidor.Enabled = true;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            comboBoxBanco.Enabled = false;
            comboBoxBanco.Items.Clear();
            comboBoxBanco.Text = "";
            txtBoxLocalBackup.Clear();
            txtBoxLocalBackup.Enabled = false;
            btnProcurarBackup.Enabled = false;
            btnBackup.Enabled = false;
            txtBoxLocalRestaurar.Clear();
            txtBoxLocalRestaurar.Enabled = false;
            btnProcurarRestaurar.Enabled = false;
            btnRestaurar.Enabled = false;
        }

        private void comboBoxBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBanco.SelectedIndex != 0)
            {
                txtBoxLocalBackup.Enabled = true;
                btnProcurarBackup.Enabled = true;
                txtBoxLocalRestaurar.Enabled = true;
                btnProcurarRestaurar.Enabled = true;
            }
            else
            {
                txtBoxLocalBackup.Enabled = false;
                btnProcurarBackup.Enabled = false;
                btnBackup.Enabled = false;
                txtBoxLocalRestaurar.Enabled = false;
                btnProcurarRestaurar.Enabled = false;
                btnRestaurar.Enabled = false;
            }

            txtBoxLocalBackup.Clear();
            txtBoxLocalRestaurar.Clear();
        }

        
        private void txtBoxLocalBackup_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxLocalBackup.Text.Trim() != string.Empty)
            {
                btnBackup.Enabled = true;
            }
            else
            {
                btnBackup.Enabled = false;
            }
        }

        private void txtBoxLocalRestaurar_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxLocalRestaurar.Text.Trim() != string.Empty)
            {
                btnRestaurar.Enabled = true;
            }
            else
            {
                btnRestaurar.Enabled = false;
            }
        }

        private void btnProcurarBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog1 = new FolderBrowserDialog();

            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBoxLocalBackup.Text = FolderBrowserDialog1.SelectedPath;
            }

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                sql = "BACKUP DATABASE " + comboBoxBanco.Text + " TO DISK = '" + txtBoxLocalBackup.Text.Trim() + "\\" + comboBoxBanco.Text + "-" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH-mm-ss") + ".bak'";
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                connection.Dispose();

                if(MessageBox.Show("Backup realizado com sucesso!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txtBoxLocalBackup.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcurarRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (txtBoxLocalBackup.Text != @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup") ;
            openFileDialog1.InitialDirectory = txtBoxLocalBackup.Text;

            openFileDialog1.Filter = "Backup Files(*.bak)|*bak|All Files(*.*)| *.*";
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBoxLocalRestaurar.Text = openFileDialog1.FileName;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Tem certeza que deseja fazer a restauração de seu banco de dados? esta ação será irreversível caso não possua um backup de sua versão atual.", "Restauração", MessageBoxButtons.OKCancel,  MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    sql = "ALTER DATABASE " + comboBoxBanco.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    sql += "RESTORE DATABASE " + comboBoxBanco.Text + " FROM DISK = '" + txtBoxLocalRestaurar.Text.Trim() + "' WITH REPLACE;";
                    sql += "ALTER DATABASE " + comboBoxBanco.Text + " SET MULTI_USER WITH ROLLBACK IMMEDIATE;";

                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();

                    if (MessageBox.Show("Restauração realizada com sucesso!", "Restauração", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        txtBoxLocalRestaurar.Text = "";
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Backup Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sender_EnabledChanged(object sender, EventArgs e)
        {
            Button senderBtn = (Button)sender;

            if (senderBtn != null)
            {
                if (senderBtn.Enabled)
                {
                    switch (senderBtn.Text)
                    {
                        case "Desconectar":
                            senderBtn.BackColor = RGBColors.vermelho;
                            break;

                        case "Conectar":
                            senderBtn.BackColor = RGBColors.verde;
                            break;

                        case "Procurar":
                            senderBtn.BackColor = RGBColors.laranja;
                            break;

                        case "Backup":
                            senderBtn.BackColor = RGBColors.azul;
                            break;

                        case "Restaurar":
                            senderBtn.BackColor = RGBColors.azul;
                            break;

                        default:
                            break;
                    }
                }

                else
                {
                    senderBtn.BackColor = Color.FromArgb(90, RGBColors.cinza);
                }

                senderBtn.ForeColor = RGBColors.branco;
            }
        }
    }
}
