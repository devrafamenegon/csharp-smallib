
namespace Smallib
{
    partial class PrimeiraEntrada
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
            this.checkBoxNovaSenha = new System.Windows.Forms.CheckBox();
            this.labelExplain = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.iconBtnAlerta = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTxtBoxNovaSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroTxtBoxConfirmarNovaSenha = new MetroFramework.Controls.MetroTextBox();
            this.timerAviso = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxNovaSenha
            // 
            this.checkBoxNovaSenha.AutoSize = true;
            this.checkBoxNovaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.checkBoxNovaSenha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNovaSenha.ForeColor = System.Drawing.Color.Black;
            this.checkBoxNovaSenha.Location = new System.Drawing.Point(670, 311);
            this.checkBoxNovaSenha.Name = "checkBoxNovaSenha";
            this.checkBoxNovaSenha.Size = new System.Drawing.Size(66, 23);
            this.checkBoxNovaSenha.TabIndex = 78;
            this.checkBoxNovaSenha.Text = "exibir";
            this.checkBoxNovaSenha.UseVisualStyleBackColor = false;
            this.checkBoxNovaSenha.CheckedChanged += new System.EventHandler(this.checkBoxNovaSenha_CheckedChanged);
            // 
            // labelExplain
            // 
            this.labelExplain.AutoSize = true;
            this.labelExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.labelExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.labelExplain.Location = new System.Drawing.Point(338, 271);
            this.labelExplain.Name = "labelExplain";
            this.labelExplain.Size = new System.Drawing.Size(384, 24);
            this.labelExplain.TabIndex = 77;
            this.labelExplain.Text = "Preencha os campos para alterar sua senha:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAlterar.Location = new System.Drawing.Point(483, 400);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 31);
            this.btnAlterar.TabIndex = 73;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.iconBtnAlerta.Location = new System.Drawing.Point(996, 519);
            this.iconBtnAlerta.Name = "iconBtnAlerta";
            this.iconBtnAlerta.Size = new System.Drawing.Size(50, 50);
            this.iconBtnAlerta.TabIndex = 84;
            this.iconBtnAlerta.UseVisualStyleBackColor = true;
            this.iconBtnAlerta.Click += new System.EventHandler(this.iconBtnAlerta_Click);
            this.iconBtnAlerta.MouseEnter += new System.EventHandler(this.iconBtnAlerta_MouseEnter);
            this.iconBtnAlerta.MouseLeave += new System.EventHandler(this.iconBtnAlerta_MouseLeave);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.iconBtnAlerta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelExplain);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.checkBoxNovaSenha);
            this.panel1.Controls.Add(this.metroTxtBoxNovaSenha);
            this.panel1.Controls.Add(this.metroTxtBoxConfirmarNovaSenha);
            this.panel1.Location = new System.Drawing.Point(102, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 580);
            this.panel1.TabIndex = 85;
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
            this.metroTxtBoxNovaSenha.TabIndex = 79;
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
            this.metroTxtBoxConfirmarNovaSenha.TabIndex = 80;
            this.metroTxtBoxConfirmarNovaSenha.UseCustomForeColor = true;
            this.metroTxtBoxConfirmarNovaSenha.UseSelectable = true;
            this.metroTxtBoxConfirmarNovaSenha.WaterMark = "Confirmar senha";
            this.metroTxtBoxConfirmarNovaSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.metroTxtBoxConfirmarNovaSenha.WaterMarkFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // timerAviso
            // 
            this.timerAviso.Enabled = true;
            this.timerAviso.Tick += new System.EventHandler(this.timerAviso_Tick);
            // 
            // PrimeiraEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "PrimeiraEntrada";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxNovaSenha;
        private System.Windows.Forms.Label labelExplain;
        private System.Windows.Forms.Button btnAlterar;
        private FontAwesome.Sharp.IconButton iconBtnAlerta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxNovaSenha;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxConfirmarNovaSenha;
        private System.Windows.Forms.Timer timerAviso;
    }
}