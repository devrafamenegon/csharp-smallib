
namespace Smallib.ChildForms.Configuracoes
{
    partial class AlterarSenha
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
            this.checkBoxNovaSenha = new System.Windows.Forms.CheckBox();
            this.labelExplain = new System.Windows.Forms.Label();
            this.txtBoxNovaSenha = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtBoxSenhaAtual = new System.Windows.Forms.TextBox();
            this.checkBoxSenhaAtual = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel7.TabIndex = 24;
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.Controls.Add(this.MainTopLabel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(1004, 52);
            this.MainTopPanel.TabIndex = 23;
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
            // checkBoxNovaSenha
            // 
            this.checkBoxNovaSenha.AutoSize = true;
            this.checkBoxNovaSenha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNovaSenha.ForeColor = System.Drawing.Color.Black;
            this.checkBoxNovaSenha.Location = new System.Drawing.Point(642, 321);
            this.checkBoxNovaSenha.Name = "checkBoxNovaSenha";
            this.checkBoxNovaSenha.Size = new System.Drawing.Size(66, 23);
            this.checkBoxNovaSenha.TabIndex = 65;
            this.checkBoxNovaSenha.Text = "exibir";
            this.checkBoxNovaSenha.UseVisualStyleBackColor = true;
            this.checkBoxNovaSenha.CheckedChanged += new System.EventHandler(this.checkBoxNovaSenha_CheckedChanged);
            // 
            // labelExplain
            // 
            this.labelExplain.AutoSize = true;
            this.labelExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.labelExplain.Location = new System.Drawing.Point(301, 191);
            this.labelExplain.Name = "labelExplain";
            this.labelExplain.Size = new System.Drawing.Size(384, 24);
            this.labelExplain.TabIndex = 64;
            this.labelExplain.Text = "Preencha os campos para alterar sua senha:";
            // 
            // txtBoxNovaSenha
            // 
            this.txtBoxNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxNovaSenha.Location = new System.Drawing.Point(364, 317);
            this.txtBoxNovaSenha.Name = "txtBoxNovaSenha";
            this.txtBoxNovaSenha.Size = new System.Drawing.Size(272, 31);
            this.txtBoxNovaSenha.TabIndex = 63;
            this.txtBoxNovaSenha.UseSystemPasswordChar = true;
            // 
            // txtBoxConfirmarSenha
            // 
            this.txtBoxConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirmarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxConfirmarSenha.Location = new System.Drawing.Point(364, 360);
            this.txtBoxConfirmarSenha.Name = "txtBoxConfirmarSenha";
            this.txtBoxConfirmarSenha.Size = new System.Drawing.Size(272, 31);
            this.txtBoxConfirmarSenha.TabIndex = 62;
            this.txtBoxConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCancelar.Location = new System.Drawing.Point(364, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 31);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnAlterar.Location = new System.Drawing.Point(544, 410);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 31);
            this.btnAlterar.TabIndex = 60;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtBoxSenhaAtual
            // 
            this.txtBoxSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenhaAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxSenhaAtual.Location = new System.Drawing.Point(364, 259);
            this.txtBoxSenhaAtual.Name = "txtBoxSenhaAtual";
            this.txtBoxSenhaAtual.Size = new System.Drawing.Size(272, 31);
            this.txtBoxSenhaAtual.TabIndex = 66;
            this.txtBoxSenhaAtual.UseSystemPasswordChar = true;
            // 
            // checkBoxSenhaAtual
            // 
            this.checkBoxSenhaAtual.AutoSize = true;
            this.checkBoxSenhaAtual.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSenhaAtual.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSenhaAtual.Location = new System.Drawing.Point(642, 264);
            this.checkBoxSenhaAtual.Name = "checkBoxSenhaAtual";
            this.checkBoxSenhaAtual.Size = new System.Drawing.Size(66, 23);
            this.checkBoxSenhaAtual.TabIndex = 67;
            this.checkBoxSenhaAtual.Text = "exibir";
            this.checkBoxSenhaAtual.UseVisualStyleBackColor = true;
            this.checkBoxSenhaAtual.CheckedChanged += new System.EventHandler(this.checkBoxSenhaAtual_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(247, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 68;
            this.label1.Text = "Senha atual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(240, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nova senha: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(203, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 70;
            this.label3.Text = "Confirmar senha: ";
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxSenhaAtual);
            this.Controls.Add(this.txtBoxSenhaAtual);
            this.Controls.Add(this.checkBoxNovaSenha);
            this.Controls.Add(this.labelExplain);
            this.Controls.Add(this.txtBoxNovaSenha);
            this.Controls.Add(this.txtBoxConfirmarSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.MainTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TrocarSenha";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.CheckBox checkBoxNovaSenha;
        private System.Windows.Forms.Label labelExplain;
        private System.Windows.Forms.TextBox txtBoxNovaSenha;
        private System.Windows.Forms.TextBox txtBoxConfirmarSenha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtBoxSenhaAtual;
        private System.Windows.Forms.CheckBox checkBoxSenhaAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}