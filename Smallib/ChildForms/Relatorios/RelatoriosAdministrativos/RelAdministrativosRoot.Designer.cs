
namespace Smallib.ChildForms.Relatorios
{
    partial class RelAdministrativosRoot
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
            this.iconHistoricoEmprestimos = new FontAwesome.Sharp.IconButton();
            this.iconLivrosDevolvidos = new FontAwesome.Sharp.IconButton();
            this.iconEmprestados = new FontAwesome.Sharp.IconButton();
            this.iconDevolucoesPendentes = new FontAwesome.Sharp.IconButton();
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
            this.MainTopLabel.Size = new System.Drawing.Size(289, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Relatórios administrativos";
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
            this.btnVoltar.TabIndex = 64;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // iconHistoricoEmprestimos
            // 
            this.iconHistoricoEmprestimos.BackColor = System.Drawing.Color.Transparent;
            this.iconHistoricoEmprestimos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconHistoricoEmprestimos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconHistoricoEmprestimos.FlatAppearance.BorderSize = 2;
            this.iconHistoricoEmprestimos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconHistoricoEmprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHistoricoEmprestimos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconHistoricoEmprestimos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconHistoricoEmprestimos.IconChar = FontAwesome.Sharp.IconChar.History;
            this.iconHistoricoEmprestimos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconHistoricoEmprestimos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHistoricoEmprestimos.IconSize = 42;
            this.iconHistoricoEmprestimos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHistoricoEmprestimos.Location = new System.Drawing.Point(338, 404);
            this.iconHistoricoEmprestimos.Name = "iconHistoricoEmprestimos";
            this.iconHistoricoEmprestimos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconHistoricoEmprestimos.Size = new System.Drawing.Size(328, 60);
            this.iconHistoricoEmprestimos.TabIndex = 68;
            this.iconHistoricoEmprestimos.Text = "Histórico de empréstimos";
            this.iconHistoricoEmprestimos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconHistoricoEmprestimos.UseVisualStyleBackColor = false;
            this.iconHistoricoEmprestimos.Click += new System.EventHandler(this.iconHistoricoEmprestimos_Click);
            this.iconHistoricoEmprestimos.MouseEnter += new System.EventHandler(this.iconHistoricoEmprestimos_MouseEnter);
            this.iconHistoricoEmprestimos.MouseLeave += new System.EventHandler(this.iconHistoricoEmprestimos_MouseLeave);
            // 
            // iconLivrosDevolvidos
            // 
            this.iconLivrosDevolvidos.BackColor = System.Drawing.Color.Transparent;
            this.iconLivrosDevolvidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconLivrosDevolvidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconLivrosDevolvidos.FlatAppearance.BorderSize = 2;
            this.iconLivrosDevolvidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconLivrosDevolvidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLivrosDevolvidos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLivrosDevolvidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconLivrosDevolvidos.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.iconLivrosDevolvidos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconLivrosDevolvidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLivrosDevolvidos.IconSize = 42;
            this.iconLivrosDevolvidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLivrosDevolvidos.Location = new System.Drawing.Point(338, 248);
            this.iconLivrosDevolvidos.Name = "iconLivrosDevolvidos";
            this.iconLivrosDevolvidos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconLivrosDevolvidos.Size = new System.Drawing.Size(328, 60);
            this.iconLivrosDevolvidos.TabIndex = 67;
            this.iconLivrosDevolvidos.Text = "Livros devolvidos";
            this.iconLivrosDevolvidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconLivrosDevolvidos.UseVisualStyleBackColor = false;
            this.iconLivrosDevolvidos.Click += new System.EventHandler(this.iconLivrosDevolvidos_Click);
            this.iconLivrosDevolvidos.MouseEnter += new System.EventHandler(this.iconLivrosDevolvidos_MouseEnter);
            this.iconLivrosDevolvidos.MouseLeave += new System.EventHandler(this.iconLivrosDevolvidos_MouseLeave);
            // 
            // iconEmprestados
            // 
            this.iconEmprestados.BackColor = System.Drawing.Color.Transparent;
            this.iconEmprestados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEmprestados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconEmprestados.FlatAppearance.BorderSize = 2;
            this.iconEmprestados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconEmprestados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEmprestados.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconEmprestados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconEmprestados.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconEmprestados.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconEmprestados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEmprestados.IconSize = 42;
            this.iconEmprestados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEmprestados.Location = new System.Drawing.Point(338, 172);
            this.iconEmprestados.Name = "iconEmprestados";
            this.iconEmprestados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconEmprestados.Size = new System.Drawing.Size(328, 60);
            this.iconEmprestados.TabIndex = 66;
            this.iconEmprestados.Text = "Livros emprestados";
            this.iconEmprestados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEmprestados.UseVisualStyleBackColor = false;
            this.iconEmprestados.Click += new System.EventHandler(this.iconEmprestados_Click);
            this.iconEmprestados.MouseEnter += new System.EventHandler(this.iconEmprestados_MouseEnter);
            this.iconEmprestados.MouseLeave += new System.EventHandler(this.iconEmprestados_MouseLeave);
            // 
            // iconDevolucoesPendentes
            // 
            this.iconDevolucoesPendentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.iconDevolucoesPendentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconDevolucoesPendentes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconDevolucoesPendentes.FlatAppearance.BorderSize = 2;
            this.iconDevolucoesPendentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconDevolucoesPendentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDevolucoesPendentes.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconDevolucoesPendentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconDevolucoesPendentes.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconDevolucoesPendentes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.iconDevolucoesPendentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDevolucoesPendentes.IconSize = 42;
            this.iconDevolucoesPendentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDevolucoesPendentes.Location = new System.Drawing.Point(338, 326);
            this.iconDevolucoesPendentes.Name = "iconDevolucoesPendentes";
            this.iconDevolucoesPendentes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconDevolucoesPendentes.Size = new System.Drawing.Size(328, 60);
            this.iconDevolucoesPendentes.TabIndex = 65;
            this.iconDevolucoesPendentes.Text = "Devoluções pendentes";
            this.iconDevolucoesPendentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconDevolucoesPendentes.UseVisualStyleBackColor = false;
            this.iconDevolucoesPendentes.Click += new System.EventHandler(this.iconLeitoresAtraso_Click);
            this.iconDevolucoesPendentes.MouseEnter += new System.EventHandler(this.iconLeitoresAtraso_MouseEnter);
            this.iconDevolucoesPendentes.MouseLeave += new System.EventHandler(this.iconLeitoresAtraso_MouseLeave);
            // 
            // RelAdministrativosRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.iconHistoricoEmprestimos);
            this.Controls.Add(this.iconLivrosDevolvidos);
            this.Controls.Add(this.iconEmprestados);
            this.Controls.Add(this.iconDevolucoesPendentes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.MainTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelAdministrativosRoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RelAdministrativos";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.Button btnVoltar;
        private FontAwesome.Sharp.IconButton iconLivrosDevolvidos;
        private FontAwesome.Sharp.IconButton iconEmprestados;
        private FontAwesome.Sharp.IconButton iconDevolucoesPendentes;
        private FontAwesome.Sharp.IconButton iconHistoricoEmprestimos;
    }
}