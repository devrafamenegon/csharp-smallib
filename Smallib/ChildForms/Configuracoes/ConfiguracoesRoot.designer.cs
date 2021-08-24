
namespace Smallib.ChildForms
{
    partial class ConfiguracoesRoot
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
            this.iconSobre = new FontAwesome.Sharp.IconButton();
            this.iconFazerBackup = new FontAwesome.Sharp.IconButton();
            this.iconAlterarSenha = new FontAwesome.Sharp.IconButton();
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
            this.panel7.TabIndex = 22;
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.Controls.Add(this.MainTopLabel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(1004, 52);
            this.MainTopPanel.TabIndex = 21;
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
            // iconSobre
            // 
            this.iconSobre.BackColor = System.Drawing.Color.Transparent;
            this.iconSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSobre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconSobre.FlatAppearance.BorderSize = 2;
            this.iconSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSobre.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconSobre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconSobre.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconSobre.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconSobre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSobre.IconSize = 42;
            this.iconSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSobre.Location = new System.Drawing.Point(375, 364);
            this.iconSobre.Name = "iconSobre";
            this.iconSobre.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconSobre.Size = new System.Drawing.Size(250, 60);
            this.iconSobre.TabIndex = 31;
            this.iconSobre.Text = "Sobre o software";
            this.iconSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconSobre.UseVisualStyleBackColor = false;
            this.iconSobre.Click += new System.EventHandler(this.iconSobre_Click);
            this.iconSobre.MouseEnter += new System.EventHandler(this.iconSobre_MouseEnter);
            this.iconSobre.MouseLeave += new System.EventHandler(this.iconSobre_MouseLeave);
            // 
            // iconFazerBackup
            // 
            this.iconFazerBackup.BackColor = System.Drawing.Color.Transparent;
            this.iconFazerBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFazerBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconFazerBackup.FlatAppearance.BorderSize = 2;
            this.iconFazerBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconFazerBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconFazerBackup.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconFazerBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconFazerBackup.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.iconFazerBackup.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconFazerBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFazerBackup.IconSize = 42;
            this.iconFazerBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconFazerBackup.Location = new System.Drawing.Point(375, 280);
            this.iconFazerBackup.Name = "iconFazerBackup";
            this.iconFazerBackup.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconFazerBackup.Size = new System.Drawing.Size(250, 60);
            this.iconFazerBackup.TabIndex = 30;
            this.iconFazerBackup.Text = "Fazer backup";
            this.iconFazerBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconFazerBackup.UseVisualStyleBackColor = false;
            this.iconFazerBackup.Click += new System.EventHandler(this.iconFazerBackup_Click);
            this.iconFazerBackup.MouseEnter += new System.EventHandler(this.iconFazerBackup_MouseEnter);
            this.iconFazerBackup.MouseLeave += new System.EventHandler(this.iconFazerBackup_MouseLeave);
            // 
            // iconAlterarSenha
            // 
            this.iconAlterarSenha.BackColor = System.Drawing.Color.Transparent;
            this.iconAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconAlterarSenha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.iconAlterarSenha.FlatAppearance.BorderSize = 2;
            this.iconAlterarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.iconAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAlterarSenha.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconAlterarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.iconAlterarSenha.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconAlterarSenha.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.iconAlterarSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAlterarSenha.IconSize = 42;
            this.iconAlterarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAlterarSenha.Location = new System.Drawing.Point(375, 197);
            this.iconAlterarSenha.Name = "iconAlterarSenha";
            this.iconAlterarSenha.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconAlterarSenha.Size = new System.Drawing.Size(250, 60);
            this.iconAlterarSenha.TabIndex = 29;
            this.iconAlterarSenha.Text = "Alterar senha";
            this.iconAlterarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconAlterarSenha.UseVisualStyleBackColor = false;
            this.iconAlterarSenha.Click += new System.EventHandler(this.iconAlterarSenha_Click);
            this.iconAlterarSenha.MouseEnter += new System.EventHandler(this.iconAlterarSenha_MouseEnter);
            this.iconAlterarSenha.MouseLeave += new System.EventHandler(this.iconAlterarSenha_MouseLeave);
            // 
            // ConfiguracoesRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.iconSobre);
            this.Controls.Add(this.iconFazerBackup);
            this.Controls.Add(this.iconAlterarSenha);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.MainTopPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfiguracoesRoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuracoes";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private FontAwesome.Sharp.IconButton iconFazerBackup;
        private FontAwesome.Sharp.IconButton iconAlterarSenha;
        private FontAwesome.Sharp.IconButton iconSobre;
    }
}