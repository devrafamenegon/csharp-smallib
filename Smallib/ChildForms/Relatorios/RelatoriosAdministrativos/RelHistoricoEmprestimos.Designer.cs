namespace Smallib.ChildForms.Relatorios.RelatoriosAdministrativos
{
    partial class RelHistoricoEmprestimos
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBoxAte = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDe = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Site = new System.Windows.Forms.Label();
            this.comboBoxTituloLivro = new System.Windows.Forms.ComboBox();
            this.labelDgv = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.MainTopLabel = new System.Windows.Forms.Label();
            this.dgvHistoricoEmprestimos = new System.Windows.Forms.DataGridView();
            this.pk_id_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_dev_prev_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_devolucao_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.MainTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel5.Controls.Add(this.txtBoxAte);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtBoxDe);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.Site);
            this.panel5.Controls.Add(this.comboBoxTituloLivro);
            this.panel5.Controls.Add(this.labelDgv);
            this.panel5.Controls.Add(this.btnRelatorio);
            this.panel5.Controls.Add(this.btnVoltar);
            this.panel5.Controls.Add(this.btnAtualizar);
            this.panel5.Controls.Add(this.btnPesquisar);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.MainTopPanel);
            this.panel5.Controls.Add(this.dgvHistoricoEmprestimos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1004, 631);
            this.panel5.TabIndex = 22;
            // 
            // txtBoxAte
            // 
            this.txtBoxAte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtBoxAte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxAte.Location = new System.Drawing.Point(676, 116);
            this.txtBoxAte.Mask = "00/00/0000";
            this.txtBoxAte.Name = "txtBoxAte";
            this.txtBoxAte.Size = new System.Drawing.Size(161, 31);
            this.txtBoxAte.TabIndex = 132;
            this.txtBoxAte.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(679, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 131;
            this.label1.Text = "Até:";
            // 
            // txtBoxDe
            // 
            this.txtBoxDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtBoxDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxDe.Location = new System.Drawing.Point(495, 116);
            this.txtBoxDe.Mask = "00/00/0000";
            this.txtBoxDe.Name = "txtBoxDe";
            this.txtBoxDe.Size = new System.Drawing.Size(161, 31);
            this.txtBoxDe.TabIndex = 130;
            this.txtBoxDe.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label10.Location = new System.Drawing.Point(498, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 25);
            this.label10.TabIndex = 129;
            this.label10.Text = "De:";
            // 
            // Site
            // 
            this.Site.AutoSize = true;
            this.Site.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Site.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.Site.Location = new System.Drawing.Point(62, 88);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(148, 25);
            this.Site.TabIndex = 127;
            this.Site.Text = "Titulo do Livro";
            // 
            // comboBoxTituloLivro
            // 
            this.comboBoxTituloLivro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTituloLivro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTituloLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.comboBoxTituloLivro.FormattingEnabled = true;
            this.comboBoxTituloLivro.IntegralHeight = false;
            this.comboBoxTituloLivro.ItemHeight = 25;
            this.comboBoxTituloLivro.Location = new System.Drawing.Point(63, 116);
            this.comboBoxTituloLivro.Name = "comboBoxTituloLivro";
            this.comboBoxTituloLivro.Size = new System.Drawing.Size(409, 33);
            this.comboBoxTituloLivro.TabIndex = 128;
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
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImage = global::Smallib.Properties.Resources.Refresh;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.Location = new System.Drawing.Point(914, 116);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(30, 30);
            this.btnAtualizar.TabIndex = 21;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = global::Smallib.Properties.Resources.Lupa;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Location = new System.Drawing.Point(856, 116);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            // MainTopLabel
            // 
            this.MainTopLabel.AutoSize = true;
            this.MainTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.MainTopLabel.Location = new System.Drawing.Point(46, 12);
            this.MainTopLabel.Name = "MainTopLabel";
            this.MainTopLabel.Size = new System.Drawing.Size(556, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Relatório Administrativo: Histórico de Empréstimos";
            // 
            // dgvHistoricoEmprestimos
            // 
            this.dgvHistoricoEmprestimos.AllowUserToAddRows = false;
            this.dgvHistoricoEmprestimos.AllowUserToDeleteRows = false;
            this.dgvHistoricoEmprestimos.AllowUserToResizeColumns = false;
            this.dgvHistoricoEmprestimos.AllowUserToResizeRows = false;
            this.dgvHistoricoEmprestimos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoricoEmprestimos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistoricoEmprestimos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistoricoEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricoEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pk_id_livro,
            this.titulo_livro,
            this.nome_leitor,
            this.dt_emprestimo,
            this.dt_dev_prev_emprestimo,
            this.dt_devolucao_emprestimo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistoricoEmprestimos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistoricoEmprestimos.EnableHeadersVisualStyles = false;
            this.dgvHistoricoEmprestimos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvHistoricoEmprestimos.Location = new System.Drawing.Point(60, 177);
            this.dgvHistoricoEmprestimos.MultiSelect = false;
            this.dgvHistoricoEmprestimos.Name = "dgvHistoricoEmprestimos";
            this.dgvHistoricoEmprestimos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistoricoEmprestimos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistoricoEmprestimos.RowHeadersVisible = false;
            this.dgvHistoricoEmprestimos.RowTemplate.Height = 43;
            this.dgvHistoricoEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoricoEmprestimos.Size = new System.Drawing.Size(883, 353);
            this.dgvHistoricoEmprestimos.TabIndex = 26;
            // 
            // pk_id_livro
            // 
            this.pk_id_livro.DataPropertyName = "pk_id_livro";
            this.pk_id_livro.FillWeight = 15F;
            this.pk_id_livro.HeaderText = "ID";
            this.pk_id_livro.Name = "pk_id_livro";
            this.pk_id_livro.ReadOnly = true;
            // 
            // titulo_livro
            // 
            this.titulo_livro.DataPropertyName = "titulo_livro";
            this.titulo_livro.FillWeight = 35F;
            this.titulo_livro.HeaderText = "Título Livro";
            this.titulo_livro.Name = "titulo_livro";
            this.titulo_livro.ReadOnly = true;
            // 
            // nome_leitor
            // 
            this.nome_leitor.DataPropertyName = "nome_leitor";
            this.nome_leitor.FillWeight = 35F;
            this.nome_leitor.HeaderText = "Nome Leitor";
            this.nome_leitor.Name = "nome_leitor";
            this.nome_leitor.ReadOnly = true;
            // 
            // dt_emprestimo
            // 
            this.dt_emprestimo.DataPropertyName = "dt_emprestimo";
            this.dt_emprestimo.FillWeight = 38F;
            this.dt_emprestimo.HeaderText = "Dt. Empréstimo";
            this.dt_emprestimo.Name = "dt_emprestimo";
            this.dt_emprestimo.ReadOnly = true;
            // 
            // dt_dev_prev_emprestimo
            // 
            this.dt_dev_prev_emprestimo.DataPropertyName = "dt_dev_prev_emprestimo";
            this.dt_dev_prev_emprestimo.FillWeight = 38F;
            this.dt_dev_prev_emprestimo.HeaderText = "Dt. Dev. Prevista";
            this.dt_dev_prev_emprestimo.Name = "dt_dev_prev_emprestimo";
            this.dt_dev_prev_emprestimo.ReadOnly = true;
            // 
            // dt_devolucao_emprestimo
            // 
            this.dt_devolucao_emprestimo.DataPropertyName = "dt_devolucao_emprestimo";
            this.dt_devolucao_emprestimo.FillWeight = 34F;
            this.dt_devolucao_emprestimo.HeaderText = "Dt. Devolução";
            this.dt_devolucao_emprestimo.Name = "dt_devolucao_emprestimo";
            this.dt_devolucao_emprestimo.ReadOnly = true;
            // 
            // RelHistoricoEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelHistoricoEmprestimos";
            this.Text = "RelEmprestimos";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoEmprestimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox txtBoxAte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBoxDe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Site;
        private System.Windows.Forms.ComboBox comboBoxTituloLivro;
        private System.Windows.Forms.Label labelDgv;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.DataGridView dgvHistoricoEmprestimos;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk_id_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_dev_prev_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_devolucao_emprestimo;
    }
}