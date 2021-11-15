
namespace Smallib.ChildForms.Relatorios.RelatoriosAdministrativos
{
    partial class RelLivrosEmprestados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioDataDevPrevista = new System.Windows.Forms.RadioButton();
            this.MainTopLabel = new System.Windows.Forms.Label();
            this.labelDgv = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.radioTituloLivro = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.radioNomeLeitor = new System.Windows.Forms.RadioButton();
            this.radioIdLivro = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.dgvLivrosEmprestados = new System.Windows.Forms.DataGridView();
            this.pk_id_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_dev_prev_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioDataEmprestimo = new System.Windows.Forms.RadioButton();
            this.MainTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosEmprestados)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioDataDevPrevista
            // 
            this.radioDataDevPrevista.AutoSize = true;
            this.radioDataDevPrevista.Checked = true;
            this.radioDataDevPrevista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioDataDevPrevista.FlatAppearance.BorderSize = 2;
            this.radioDataDevPrevista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDataDevPrevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioDataDevPrevista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioDataDevPrevista.Location = new System.Drawing.Point(60, 105);
            this.radioDataDevPrevista.Name = "radioDataDevPrevista";
            this.radioDataDevPrevista.Size = new System.Drawing.Size(143, 24);
            this.radioDataDevPrevista.TabIndex = 32;
            this.radioDataDevPrevista.TabStop = true;
            this.radioDataDevPrevista.Text = "Dt. Dev. Prevista";
            this.radioDataDevPrevista.UseVisualStyleBackColor = true;
            this.radioDataDevPrevista.CheckedChanged += new System.EventHandler(this.radioDataDevPrevista_CheckedChanged);
            // 
            // MainTopLabel
            // 
            this.MainTopLabel.AutoSize = true;
            this.MainTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.MainTopLabel.Location = new System.Drawing.Point(46, 12);
            this.MainTopLabel.Name = "MainTopLabel";
            this.MainTopLabel.Size = new System.Drawing.Size(492, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Relatório Administrativo: Livros Emprestados";
            // 
            // labelDgv
            // 
            this.labelDgv.AutoSize = true;
            this.labelDgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDgv.Location = new System.Drawing.Point(355, 355);
            this.labelDgv.Name = "labelDgv";
            this.labelDgv.Size = new System.Drawing.Size(0, 25);
            this.labelDgv.TabIndex = 28;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(233)))));
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.btnRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnRelatorio.Location = new System.Drawing.Point(833, 552);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(110, 40);
            this.btnRelatorio.TabIndex = 47;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // radioTituloLivro
            // 
            this.radioTituloLivro.AutoSize = true;
            this.radioTituloLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioTituloLivro.FlatAppearance.BorderSize = 2;
            this.radioTituloLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioTituloLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioTituloLivro.Location = new System.Drawing.Point(442, 105);
            this.radioTituloLivro.Name = "radioTituloLivro";
            this.radioTituloLivro.Size = new System.Drawing.Size(101, 24);
            this.radioTituloLivro.TabIndex = 29;
            this.radioTituloLivro.Text = "Título Livro";
            this.radioTituloLivro.UseVisualStyleBackColor = true;
            this.radioTituloLivro.CheckedChanged += new System.EventHandler(this.radioTituloLivro_CheckedChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnVoltar.Location = new System.Drawing.Point(60, 552);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 40);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // radioNomeLeitor
            // 
            this.radioNomeLeitor.AutoSize = true;
            this.radioNomeLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioNomeLeitor.FlatAppearance.BorderSize = 2;
            this.radioNomeLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioNomeLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioNomeLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioNomeLeitor.Location = new System.Drawing.Point(309, 105);
            this.radioNomeLeitor.Name = "radioNomeLeitor";
            this.radioNomeLeitor.Size = new System.Drawing.Size(112, 24);
            this.radioNomeLeitor.TabIndex = 19;
            this.radioNomeLeitor.Text = "Nome Leitor";
            this.radioNomeLeitor.UseVisualStyleBackColor = true;
            this.radioNomeLeitor.CheckedChanged += new System.EventHandler(this.radioNomeLeitor_CheckedChanged);
            // 
            // radioIdLivro
            // 
            this.radioIdLivro.AutoSize = true;
            this.radioIdLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioIdLivro.FlatAppearance.BorderSize = 2;
            this.radioIdLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioIdLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioIdLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioIdLivro.Location = new System.Drawing.Point(221, 105);
            this.radioIdLivro.Name = "radioIdLivro";
            this.radioIdLivro.Size = new System.Drawing.Size(67, 24);
            this.radioIdLivro.TabIndex = 18;
            this.radioIdLivro.Text = "ID Lv.";
            this.radioIdLivro.UseVisualStyleBackColor = true;
            this.radioIdLivro.CheckedChanged += new System.EventHandler(this.radioIdLivro_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 52);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1004, 2);
            this.panel7.TabIndex = 16;
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.Controls.Add(this.MainTopLabel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(1004, 52);
            this.MainTopPanel.TabIndex = 15;
            // 
            // dgvLivrosEmprestados
            // 
            this.dgvLivrosEmprestados.AllowUserToAddRows = false;
            this.dgvLivrosEmprestados.AllowUserToDeleteRows = false;
            this.dgvLivrosEmprestados.AllowUserToResizeColumns = false;
            this.dgvLivrosEmprestados.AllowUserToResizeRows = false;
            this.dgvLivrosEmprestados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivrosEmprestados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivrosEmprestados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivrosEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivrosEmprestados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pk_id_livro,
            this.titulo_livro,
            this.nome_leitor,
            this.dt_emprestimo,
            this.dt_dev_prev_emprestimo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLivrosEmprestados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivrosEmprestados.EnableHeadersVisualStyles = false;
            this.dgvLivrosEmprestados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvLivrosEmprestados.Location = new System.Drawing.Point(60, 146);
            this.dgvLivrosEmprestados.MultiSelect = false;
            this.dgvLivrosEmprestados.Name = "dgvLivrosEmprestados";
            this.dgvLivrosEmprestados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivrosEmprestados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLivrosEmprestados.RowHeadersVisible = false;
            this.dgvLivrosEmprestados.RowTemplate.Height = 43;
            this.dgvLivrosEmprestados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivrosEmprestados.Size = new System.Drawing.Size(883, 384);
            this.dgvLivrosEmprestados.TabIndex = 26;
            // 
            // pk_id_livro
            // 
            this.pk_id_livro.DataPropertyName = "pk_id_livro";
            this.pk_id_livro.FillWeight = 30F;
            this.pk_id_livro.HeaderText = "ID Lv.";
            this.pk_id_livro.Name = "pk_id_livro";
            this.pk_id_livro.ReadOnly = true;
            // 
            // titulo_livro
            // 
            this.titulo_livro.DataPropertyName = "titulo_livro";
            this.titulo_livro.FillWeight = 80F;
            this.titulo_livro.HeaderText = "Título Livro";
            this.titulo_livro.Name = "titulo_livro";
            this.titulo_livro.ReadOnly = true;
            // 
            // nome_leitor
            // 
            this.nome_leitor.DataPropertyName = "nome_leitor";
            this.nome_leitor.FillWeight = 80F;
            this.nome_leitor.HeaderText = "Nome Leitor";
            this.nome_leitor.Name = "nome_leitor";
            this.nome_leitor.ReadOnly = true;
            // 
            // dt_emprestimo
            // 
            this.dt_emprestimo.DataPropertyName = "dt_emprestimo";
            this.dt_emprestimo.FillWeight = 60F;
            this.dt_emprestimo.HeaderText = "Dt. Empréstimo";
            this.dt_emprestimo.Name = "dt_emprestimo";
            this.dt_emprestimo.ReadOnly = true;
            // 
            // dt_dev_prev_emprestimo
            // 
            this.dt_dev_prev_emprestimo.DataPropertyName = "dt_dev_prev_emprestimo";
            this.dt_dev_prev_emprestimo.FillWeight = 60F;
            this.dt_dev_prev_emprestimo.HeaderText = "Dt. Dev. Prevista";
            this.dt_dev_prev_emprestimo.Name = "dt_dev_prev_emprestimo";
            this.dt_dev_prev_emprestimo.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel5.Controls.Add(this.radioDataEmprestimo);
            this.panel5.Controls.Add(this.labelDgv);
            this.panel5.Controls.Add(this.btnRelatorio);
            this.panel5.Controls.Add(this.radioDataDevPrevista);
            this.panel5.Controls.Add(this.radioTituloLivro);
            this.panel5.Controls.Add(this.btnVoltar);
            this.panel5.Controls.Add(this.radioNomeLeitor);
            this.panel5.Controls.Add(this.radioIdLivro);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.MainTopPanel);
            this.panel5.Controls.Add(this.dgvLivrosEmprestados);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1004, 631);
            this.panel5.TabIndex = 21;
            // 
            // radioDataEmprestimo
            // 
            this.radioDataEmprestimo.AutoSize = true;
            this.radioDataEmprestimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioDataEmprestimo.FlatAppearance.BorderSize = 2;
            this.radioDataEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDataEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioDataEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioDataEmprestimo.Location = new System.Drawing.Point(564, 105);
            this.radioDataEmprestimo.Name = "radioDataEmprestimo";
            this.radioDataEmprestimo.Size = new System.Drawing.Size(136, 24);
            this.radioDataEmprestimo.TabIndex = 48;
            this.radioDataEmprestimo.Text = "Dt. Empréstimo";
            this.radioDataEmprestimo.UseVisualStyleBackColor = true;
            this.radioDataEmprestimo.CheckedChanged += new System.EventHandler(this.radioDataEmprestimo_CheckedChanged);
            // 
            // RelLivrosEmprestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelLivrosEmprestados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RelLivrosEmprestados";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosEmprestados)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioDataDevPrevista;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.Label labelDgv;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.RadioButton radioTituloLivro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton radioNomeLeitor;
        private System.Windows.Forms.RadioButton radioIdLivro;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.DataGridView dgvLivrosEmprestados;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk_id_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_dev_prev_emprestimo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioDataEmprestimo;
    }
}