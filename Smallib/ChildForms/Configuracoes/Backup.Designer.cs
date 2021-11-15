
namespace Smallib.ChildForms.Configuracoes
{
    partial class Backup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel7 = new System.Windows.Forms.Panel();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.MainTopLabel = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnProcurarBackup = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.txtBoxServidor = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxLocalBackup = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxLocalRestaurar = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxBanco = new MetroFramework.Controls.MetroComboBox();
            this.btnProcurarRestaurar = new System.Windows.Forms.Button();
            this.MainTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 52);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1004, 2);
            this.panel7.TabIndex = 26;
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.Controls.Add(this.MainTopLabel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(1004, 52);
            this.MainTopPanel.TabIndex = 25;
            // 
            // MainTopLabel
            // 
            this.MainTopLabel.AutoSize = true;
            this.MainTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F);
            this.MainTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.MainTopLabel.Location = new System.Drawing.Point(46, 12);
            this.MainTopLabel.Name = "MainTopLabel";
            this.MainTopLabel.Size = new System.Drawing.Size(169, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Configurações";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnVoltar.Location = new System.Drawing.Point(51, 538);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 40);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(106, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 147;
            this.label5.Text = "Servidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(106, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 149;
            this.label1.Text = "Banco de dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(106, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 151;
            this.label2.Text = "Local para o Backup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(106, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 25);
            this.label3.TabIndex = 153;
            this.label3.Text = "Local para a Restauração";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btnDesconectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDesconectar.Location = new System.Drawing.Point(591, 159);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(130, 40);
            this.btnDesconectar.TabIndex = 2;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.EnabledChanged += new System.EventHandler(this.sender_EnabledChanged);
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnBackup.Location = new System.Drawing.Point(749, 334);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(130, 40);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.EnabledChanged += new System.EventHandler(this.sender_EnabledChanged);
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnConectar.Location = new System.Drawing.Point(749, 159);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(130, 40);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.EnabledChanged += new System.EventHandler(this.sender_EnabledChanged);
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnProcurarBackup
            // 
            this.btnProcurarBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.btnProcurarBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcurarBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnProcurarBackup.Location = new System.Drawing.Point(591, 334);
            this.btnProcurarBackup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnProcurarBackup.Name = "btnProcurarBackup";
            this.btnProcurarBackup.Size = new System.Drawing.Size(130, 40);
            this.btnProcurarBackup.TabIndex = 6;
            this.btnProcurarBackup.Text = "Procurar";
            this.btnProcurarBackup.UseVisualStyleBackColor = false;
            this.btnProcurarBackup.EnabledChanged += new System.EventHandler(this.sender_EnabledChanged);
            this.btnProcurarBackup.Click += new System.EventHandler(this.btnProcurarBackup_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnRestaurar.Location = new System.Drawing.Point(749, 421);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(130, 40);
            this.btnRestaurar.TabIndex = 10;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.EnabledChanged += new System.EventHandler(this.sender_EnabledChanged);
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // txtBoxServidor
            // 
            // 
            // 
            // 
            this.txtBoxServidor.CustomButton.Image = null;
            this.txtBoxServidor.CustomButton.Location = new System.Drawing.Point(353, 1);
            this.txtBoxServidor.CustomButton.Name = "";
            this.txtBoxServidor.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtBoxServidor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxServidor.CustomButton.TabIndex = 1;
            this.txtBoxServidor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxServidor.CustomButton.UseSelectable = true;
            this.txtBoxServidor.CustomButton.Visible = false;
            this.txtBoxServidor.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxServidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxServidor.Lines = new string[0];
            this.txtBoxServidor.Location = new System.Drawing.Point(103, 166);
            this.txtBoxServidor.MaxLength = 32767;
            this.txtBoxServidor.Name = "txtBoxServidor";
            this.txtBoxServidor.PasswordChar = '\0';
            this.txtBoxServidor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxServidor.SelectedText = "";
            this.txtBoxServidor.SelectionLength = 0;
            this.txtBoxServidor.SelectionStart = 0;
            this.txtBoxServidor.ShortcutsEnabled = true;
            this.txtBoxServidor.Size = new System.Drawing.Size(383, 31);
            this.txtBoxServidor.TabIndex = 164;
            this.txtBoxServidor.UseCustomForeColor = true;
            this.txtBoxServidor.UseSelectable = true;
            this.txtBoxServidor.WaterMarkColor = System.Drawing.Color.Empty;
            this.txtBoxServidor.WaterMarkFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtBoxLocalBackup
            // 
            // 
            // 
            // 
            this.txtBoxLocalBackup.CustomButton.Image = null;
            this.txtBoxLocalBackup.CustomButton.Location = new System.Drawing.Point(353, 1);
            this.txtBoxLocalBackup.CustomButton.Name = "";
            this.txtBoxLocalBackup.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtBoxLocalBackup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxLocalBackup.CustomButton.TabIndex = 1;
            this.txtBoxLocalBackup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxLocalBackup.CustomButton.UseSelectable = true;
            this.txtBoxLocalBackup.CustomButton.Visible = false;
            this.txtBoxLocalBackup.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxLocalBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxLocalBackup.Lines = new string[0];
            this.txtBoxLocalBackup.Location = new System.Drawing.Point(103, 342);
            this.txtBoxLocalBackup.MaxLength = 32767;
            this.txtBoxLocalBackup.Name = "txtBoxLocalBackup";
            this.txtBoxLocalBackup.PasswordChar = '\0';
            this.txtBoxLocalBackup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxLocalBackup.SelectedText = "";
            this.txtBoxLocalBackup.SelectionLength = 0;
            this.txtBoxLocalBackup.SelectionStart = 0;
            this.txtBoxLocalBackup.ShortcutsEnabled = true;
            this.txtBoxLocalBackup.Size = new System.Drawing.Size(383, 31);
            this.txtBoxLocalBackup.TabIndex = 165;
            this.txtBoxLocalBackup.UseCustomForeColor = true;
            this.txtBoxLocalBackup.UseSelectable = true;
            this.txtBoxLocalBackup.WaterMarkColor = System.Drawing.Color.Empty;
            this.txtBoxLocalBackup.WaterMarkFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLocalBackup.TextChanged += new System.EventHandler(this.txtBoxLocalBackup_TextChanged);
            // 
            // txtBoxLocalRestaurar
            // 
            // 
            // 
            // 
            this.txtBoxLocalRestaurar.CustomButton.Image = null;
            this.txtBoxLocalRestaurar.CustomButton.Location = new System.Drawing.Point(353, 1);
            this.txtBoxLocalRestaurar.CustomButton.Name = "";
            this.txtBoxLocalRestaurar.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtBoxLocalRestaurar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxLocalRestaurar.CustomButton.TabIndex = 1;
            this.txtBoxLocalRestaurar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxLocalRestaurar.CustomButton.UseSelectable = true;
            this.txtBoxLocalRestaurar.CustomButton.Visible = false;
            this.txtBoxLocalRestaurar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBoxLocalRestaurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxLocalRestaurar.Lines = new string[0];
            this.txtBoxLocalRestaurar.Location = new System.Drawing.Point(103, 430);
            this.txtBoxLocalRestaurar.MaxLength = 32767;
            this.txtBoxLocalRestaurar.Name = "txtBoxLocalRestaurar";
            this.txtBoxLocalRestaurar.PasswordChar = '\0';
            this.txtBoxLocalRestaurar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxLocalRestaurar.SelectedText = "";
            this.txtBoxLocalRestaurar.SelectionLength = 0;
            this.txtBoxLocalRestaurar.SelectionStart = 0;
            this.txtBoxLocalRestaurar.ShortcutsEnabled = true;
            this.txtBoxLocalRestaurar.Size = new System.Drawing.Size(383, 31);
            this.txtBoxLocalRestaurar.TabIndex = 166;
            this.txtBoxLocalRestaurar.UseCustomForeColor = true;
            this.txtBoxLocalRestaurar.UseSelectable = true;
            this.txtBoxLocalRestaurar.WaterMarkColor = System.Drawing.Color.Empty;
            this.txtBoxLocalRestaurar.WaterMarkFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLocalRestaurar.TextChanged += new System.EventHandler(this.txtBoxLocalRestaurar_TextChanged);
            // 
            // comboBoxBanco
            // 
            this.comboBoxBanco.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.comboBoxBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.comboBoxBanco.FormattingEnabled = true;
            this.comboBoxBanco.ItemHeight = 29;
            this.comboBoxBanco.Location = new System.Drawing.Point(103, 252);
            this.comboBoxBanco.Name = "comboBoxBanco";
            this.comboBoxBanco.Size = new System.Drawing.Size(383, 35);
            this.comboBoxBanco.TabIndex = 167;
            this.comboBoxBanco.UseCustomForeColor = true;
            this.comboBoxBanco.UseSelectable = true;
            this.comboBoxBanco.SelectedIndexChanged += new System.EventHandler(this.comboBoxBanco_SelectedIndexChanged);
            // 
            // btnProcurarRestaurar
            // 
            this.btnProcurarRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.btnProcurarRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcurarRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurarRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarRestaurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnProcurarRestaurar.Location = new System.Drawing.Point(591, 421);
            this.btnProcurarRestaurar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnProcurarRestaurar.Name = "btnProcurarRestaurar";
            this.btnProcurarRestaurar.Size = new System.Drawing.Size(130, 40);
            this.btnProcurarRestaurar.TabIndex = 9;
            this.btnProcurarRestaurar.Text = "Procurar";
            this.btnProcurarRestaurar.UseVisualStyleBackColor = false;
            this.btnProcurarRestaurar.EnabledChanged += new System.EventHandler(this.sender_EnabledChanged);
            this.btnProcurarRestaurar.Click += new System.EventHandler(this.btnProcurarRestaurar_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.btnProcurarBackup);
            this.Controls.Add(this.btnProcurarRestaurar);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.MainTopPanel);
            this.Controls.Add(this.txtBoxServidor);
            this.Controls.Add(this.txtBoxLocalBackup);
            this.Controls.Add(this.txtBoxLocalRestaurar);
            this.Controls.Add(this.comboBoxBanco);
            this.Controls.Add(this.btnRestaurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnProcurarBackup;
        private System.Windows.Forms.Button btnRestaurar;
        private MetroFramework.Controls.MetroTextBox txtBoxServidor;
        private MetroFramework.Controls.MetroTextBox txtBoxLocalBackup;
        private MetroFramework.Controls.MetroTextBox txtBoxLocalRestaurar;
        private MetroFramework.Controls.MetroComboBox comboBoxBanco;
        private System.Windows.Forms.Button btnProcurarRestaurar;
    }
}