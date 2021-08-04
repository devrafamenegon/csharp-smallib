namespace Smallib
{
    partial class Senha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSenha = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTxtBoxSenha = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.checkBoxSenha);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.metroTxtBoxSenha);
            this.panel1.Location = new System.Drawing.Point(101, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 580);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxSenha
            // 
            this.checkBoxSenha.AutoSize = true;
            this.checkBoxSenha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSenha.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSenha.Location = new System.Drawing.Point(669, 312);
            this.checkBoxSenha.Name = "checkBoxSenha";
            this.checkBoxSenha.Size = new System.Drawing.Size(66, 23);
            this.checkBoxSenha.TabIndex = 57;
            this.checkBoxSenha.Text = "exibir";
            this.checkBoxSenha.UseVisualStyleBackColor = true;
            this.checkBoxSenha.CheckedChanged += new System.EventHandler(this.checkBoxSenha_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSair.Location = new System.Drawing.Point(483, 394);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 31);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnEntrar.Location = new System.Drawing.Point(483, 354);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(93, 31);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(436, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insira a Senha master:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Smallib.Properties.Resources.Smalllib;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(320, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroTxtBoxSenha
            // 
            // 
            // 
            // 
            this.metroTxtBoxSenha.CustomButton.Image = null;
            this.metroTxtBoxSenha.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.metroTxtBoxSenha.CustomButton.Name = "";
            this.metroTxtBoxSenha.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTxtBoxSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtBoxSenha.CustomButton.TabIndex = 1;
            this.metroTxtBoxSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtBoxSenha.CustomButton.UseSelectable = true;
            this.metroTxtBoxSenha.CustomButton.Visible = false;
            this.metroTxtBoxSenha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxtBoxSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.metroTxtBoxSenha.Lines = new string[0];
            this.metroTxtBoxSenha.Location = new System.Drawing.Point(391, 307);
            this.metroTxtBoxSenha.MaxLength = 32767;
            this.metroTxtBoxSenha.Name = "metroTxtBoxSenha";
            this.metroTxtBoxSenha.PasswordChar = '\0';
            this.metroTxtBoxSenha.PromptText = "Senha master";
            this.metroTxtBoxSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtBoxSenha.SelectedText = "";
            this.metroTxtBoxSenha.SelectionLength = 0;
            this.metroTxtBoxSenha.SelectionStart = 0;
            this.metroTxtBoxSenha.ShortcutsEnabled = true;
            this.metroTxtBoxSenha.Size = new System.Drawing.Size(272, 31);
            this.metroTxtBoxSenha.TabIndex = 82;
            this.metroTxtBoxSenha.UseCustomForeColor = true;
            this.metroTxtBoxSenha.UseSelectable = true;
            this.metroTxtBoxSenha.WaterMark = "Senha master";
            this.metroTxtBoxSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.metroTxtBoxSenha.WaterMarkFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Senha";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSenha;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxSenha;
    }
}

