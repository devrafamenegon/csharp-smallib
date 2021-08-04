namespace Smallib
{
    partial class ModificarSenha
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtnAlerta = new FontAwesome.Sharp.IconButton();
            this.checkBoxSenha = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimerAviso = new System.Windows.Forms.Timer(this.components);
            this.metroTxtBoxNovaSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroTxtBoxConfirmarNovaSenha = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.iconBtnAlerta);
            this.panel1.Controls.Add(this.checkBoxSenha);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.metroTxtBoxNovaSenha);
            this.panel1.Controls.Add(this.metroTxtBoxConfirmarNovaSenha);
            this.panel1.Location = new System.Drawing.Point(101, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 580);
            this.panel1.TabIndex = 1;
            // 
            // iconBtnAlerta
            // 
            this.iconBtnAlerta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnAlerta.FlatAppearance.BorderSize = 0;
            this.iconBtnAlerta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconBtnAlerta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconBtnAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAlerta.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconBtnAlerta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.iconBtnAlerta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAlerta.Location = new System.Drawing.Point(992, 514);
            this.iconBtnAlerta.Name = "iconBtnAlerta";
            this.iconBtnAlerta.Size = new System.Drawing.Size(50, 50);
            this.iconBtnAlerta.TabIndex = 59;
            this.iconBtnAlerta.UseVisualStyleBackColor = true;
            this.iconBtnAlerta.Click += new System.EventHandler(this.iconBtnAlerta_Click);
            this.iconBtnAlerta.MouseEnter += new System.EventHandler(this.iconBtnAlerta_MouseEnter);
            this.iconBtnAlerta.MouseLeave += new System.EventHandler(this.iconBtnAlerta_MouseLeave);
            // 
            // checkBoxSenha
            // 
            this.checkBoxSenha.AutoSize = true;
            this.checkBoxSenha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSenha.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSenha.Location = new System.Drawing.Point(669, 312);
            this.checkBoxSenha.Name = "checkBoxSenha";
            this.checkBoxSenha.Size = new System.Drawing.Size(66, 23);
            this.checkBoxSenha.TabIndex = 58;
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
            this.btnSair.Location = new System.Drawing.Point(483, 440);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 31);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnConfirmar.Location = new System.Drawing.Point(473, 400);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 31);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(417, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alterar a Senha master:";
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
            // TimerAviso
            // 
            this.TimerAviso.Enabled = true;
            this.TimerAviso.Interval = 500;
            this.TimerAviso.Tick += new System.EventHandler(this.TimerAviso_Tick);
            // 
            // metroTxtBoxNovaSenha
            // 
            // 
            // 
            // 
            this.metroTxtBoxNovaSenha.CustomButton.Image = null;
            this.metroTxtBoxNovaSenha.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.metroTxtBoxNovaSenha.CustomButton.Name = "";
            this.metroTxtBoxNovaSenha.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTxtBoxNovaSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtBoxNovaSenha.CustomButton.TabIndex = 1;
            this.metroTxtBoxNovaSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtBoxNovaSenha.CustomButton.UseSelectable = true;
            this.metroTxtBoxNovaSenha.CustomButton.Visible = false;
            this.metroTxtBoxNovaSenha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxtBoxNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.metroTxtBoxNovaSenha.Lines = new string[0];
            this.metroTxtBoxNovaSenha.Location = new System.Drawing.Point(391, 307);
            this.metroTxtBoxNovaSenha.MaxLength = 32767;
            this.metroTxtBoxNovaSenha.Name = "metroTxtBoxNovaSenha";
            this.metroTxtBoxNovaSenha.PasswordChar = '\0';
            this.metroTxtBoxNovaSenha.PromptText = "Nova senha";
            this.metroTxtBoxNovaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtBoxNovaSenha.SelectedText = "";
            this.metroTxtBoxNovaSenha.SelectionLength = 0;
            this.metroTxtBoxNovaSenha.SelectionStart = 0;
            this.metroTxtBoxNovaSenha.ShortcutsEnabled = true;
            this.metroTxtBoxNovaSenha.Size = new System.Drawing.Size(272, 31);
            this.metroTxtBoxNovaSenha.TabIndex = 81;
            this.metroTxtBoxNovaSenha.UseCustomForeColor = true;
            this.metroTxtBoxNovaSenha.UseSelectable = true;
            this.metroTxtBoxNovaSenha.WaterMark = "Nova senha";
            this.metroTxtBoxNovaSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.metroTxtBoxNovaSenha.WaterMarkFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTxtBoxConfirmarNovaSenha
            // 
            // 
            // 
            // 
            this.metroTxtBoxConfirmarNovaSenha.CustomButton.Image = null;
            this.metroTxtBoxConfirmarNovaSenha.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.metroTxtBoxConfirmarNovaSenha.CustomButton.Name = "";
            this.metroTxtBoxConfirmarNovaSenha.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTxtBoxConfirmarNovaSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtBoxConfirmarNovaSenha.CustomButton.TabIndex = 1;
            this.metroTxtBoxConfirmarNovaSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtBoxConfirmarNovaSenha.CustomButton.UseSelectable = true;
            this.metroTxtBoxConfirmarNovaSenha.CustomButton.Visible = false;
            this.metroTxtBoxConfirmarNovaSenha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxtBoxConfirmarNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.metroTxtBoxConfirmarNovaSenha.Lines = new string[0];
            this.metroTxtBoxConfirmarNovaSenha.Location = new System.Drawing.Point(391, 350);
            this.metroTxtBoxConfirmarNovaSenha.MaxLength = 32767;
            this.metroTxtBoxConfirmarNovaSenha.Name = "metroTxtBoxConfirmarNovaSenha";
            this.metroTxtBoxConfirmarNovaSenha.PasswordChar = '\0';
            this.metroTxtBoxConfirmarNovaSenha.PromptText = "Confirmar senha";
            this.metroTxtBoxConfirmarNovaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtBoxConfirmarNovaSenha.SelectedText = "";
            this.metroTxtBoxConfirmarNovaSenha.SelectionLength = 0;
            this.metroTxtBoxConfirmarNovaSenha.SelectionStart = 0;
            this.metroTxtBoxConfirmarNovaSenha.ShortcutsEnabled = true;
            this.metroTxtBoxConfirmarNovaSenha.Size = new System.Drawing.Size(272, 31);
            this.metroTxtBoxConfirmarNovaSenha.TabIndex = 82;
            this.metroTxtBoxConfirmarNovaSenha.UseCustomForeColor = true;
            this.metroTxtBoxConfirmarNovaSenha.UseSelectable = true;
            this.metroTxtBoxConfirmarNovaSenha.WaterMark = "Confirmar senha";
            this.metroTxtBoxConfirmarNovaSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.metroTxtBoxConfirmarNovaSenha.WaterMarkFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ModificarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "ModificarSenha";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxSenha;
        private FontAwesome.Sharp.IconButton iconBtnAlerta;
        private System.Windows.Forms.Timer TimerAviso;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxNovaSenha;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxConfirmarNovaSenha;
    }
}