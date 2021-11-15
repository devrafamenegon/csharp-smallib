
namespace Smallib.ChildForms.Relatorios
{
    partial class RelEstatisticosRoot
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
            this.iconLivrosMaisEmprestados = new FontAwesome.Sharp.IconButton();
            this.iconGenerosMaisEmprestados = new FontAwesome.Sharp.IconButton();
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
            this.MainTopLabel.Size = new System.Drawing.Size(248, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Relatórios estatísticos";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnVoltar.Location = new System.Drawing.Point(60, 552);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 40);
            this.btnVoltar.TabIndex = 63;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // iconLivrosMaisEmprestados
            // 
            this.iconLivrosMaisEmprestados.BackColor = System.Drawing.Color.Transparent;
            this.iconLivrosMaisEmprestados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconLivrosMaisEmprestados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconLivrosMaisEmprestados.FlatAppearance.BorderSize = 2;
            this.iconLivrosMaisEmprestados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconLivrosMaisEmprestados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLivrosMaisEmprestados.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLivrosMaisEmprestados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconLivrosMaisEmprestados.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.iconLivrosMaisEmprestados.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconLivrosMaisEmprestados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLivrosMaisEmprestados.IconSize = 42;
            this.iconLivrosMaisEmprestados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLivrosMaisEmprestados.Location = new System.Drawing.Point(338, 340);
            this.iconLivrosMaisEmprestados.Name = "iconLivrosMaisEmprestados";
            this.iconLivrosMaisEmprestados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconLivrosMaisEmprestados.Size = new System.Drawing.Size(342, 60);
            this.iconLivrosMaisEmprestados.TabIndex = 71;
            this.iconLivrosMaisEmprestados.Text = "Livros Mais Emprestados";
            this.iconLivrosMaisEmprestados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconLivrosMaisEmprestados.UseVisualStyleBackColor = false;
            this.iconLivrosMaisEmprestados.Click += new System.EventHandler(this.iconLivrosMaisEmprestados_Click);
            this.iconLivrosMaisEmprestados.MouseEnter += new System.EventHandler(this.iconLivrosMaisEmprestados_MouseEnter);
            this.iconLivrosMaisEmprestados.MouseLeave += new System.EventHandler(this.iconLivrosMaisEmprestados_MouseLeave);
            // 
            // iconGenerosMaisEmprestados
            // 
            this.iconGenerosMaisEmprestados.BackColor = System.Drawing.Color.Transparent;
            this.iconGenerosMaisEmprestados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconGenerosMaisEmprestados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconGenerosMaisEmprestados.FlatAppearance.BorderSize = 2;
            this.iconGenerosMaisEmprestados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconGenerosMaisEmprestados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGenerosMaisEmprestados.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconGenerosMaisEmprestados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconGenerosMaisEmprestados.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconGenerosMaisEmprestados.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.iconGenerosMaisEmprestados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGenerosMaisEmprestados.IconSize = 42;
            this.iconGenerosMaisEmprestados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconGenerosMaisEmprestados.Location = new System.Drawing.Point(338, 263);
            this.iconGenerosMaisEmprestados.Name = "iconGenerosMaisEmprestados";
            this.iconGenerosMaisEmprestados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconGenerosMaisEmprestados.Size = new System.Drawing.Size(342, 60);
            this.iconGenerosMaisEmprestados.TabIndex = 70;
            this.iconGenerosMaisEmprestados.Text = "Gêneros Mais Emprestados";
            this.iconGenerosMaisEmprestados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconGenerosMaisEmprestados.UseVisualStyleBackColor = false;
            this.iconGenerosMaisEmprestados.Click += new System.EventHandler(this.iconGenerosMaisEmprestados_Click);
            this.iconGenerosMaisEmprestados.MouseEnter += new System.EventHandler(this.iconGenerosMaisEmprestados_MouseEnter);
            this.iconGenerosMaisEmprestados.MouseLeave += new System.EventHandler(this.iconGenerosMaisEmprestados_MouseLeave);
            // 
            // RelEstatisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.iconLivrosMaisEmprestados);
            this.Controls.Add(this.iconGenerosMaisEmprestados);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.MainTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelEstatisticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RelEstaticos";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.Button btnVoltar;
        private FontAwesome.Sharp.IconButton iconLivrosMaisEmprestados;
        private FontAwesome.Sharp.IconButton iconGenerosMaisEmprestados;
    }
}