
namespace Smallib.ChildForms
{
    partial class Devolucao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.MainTopLabel = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.labelDgv = new System.Windows.Forms.Label();
            this.dgvDevolucao = new System.Windows.Forms.DataGridView();
            this.metroTxtBoxPesquisar = new MetroFramework.Controls.MetroTextBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.radioNomeLeitor = new System.Windows.Forms.RadioButton();
            this.radioIdEmprestimo = new System.Windows.Forms.RadioButton();
            this.pk_id_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_id_leitor_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_id_livro_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_dev_prev_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioTituloLivro = new System.Windows.Forms.RadioButton();
            this.MainTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 52);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1004, 2);
            this.panel7.TabIndex = 20;
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.Controls.Add(this.MainTopLabel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(1004, 52);
            this.MainTopPanel.TabIndex = 19;
            // 
            // MainTopLabel
            // 
            this.MainTopLabel.AutoSize = true;
            this.MainTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F);
            this.MainTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.MainTopLabel.Location = new System.Drawing.Point(46, 12);
            this.MainTopLabel.Name = "MainTopLabel";
            this.MainTopLabel.Size = new System.Drawing.Size(127, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Devolução";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnVoltar.Location = new System.Drawing.Point(60, 558);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 40);
            this.btnVoltar.TabIndex = 91;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // labelDgv
            // 
            this.labelDgv.AutoSize = true;
            this.labelDgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDgv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDgv.Location = new System.Drawing.Point(355, 355);
            this.labelDgv.Name = "labelDgv";
            this.labelDgv.Size = new System.Drawing.Size(0, 25);
            this.labelDgv.TabIndex = 88;
            // 
            // dgvDevolucao
            // 
            this.dgvDevolucao.AllowUserToAddRows = false;
            this.dgvDevolucao.AllowUserToDeleteRows = false;
            this.dgvDevolucao.AllowUserToResizeColumns = false;
            this.dgvDevolucao.AllowUserToResizeRows = false;
            this.dgvDevolucao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevolucao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pk_id_emprestimo,
            this.fk_id_leitor_emprestimo,
            this.fk_id_livro_emprestimo,
            this.nome_leitor,
            this.titulo_livro,
            this.dt_emprestimo,
            this.dt_dev_prev_emprestimo});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevolucao.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDevolucao.EnableHeadersVisualStyles = false;
            this.dgvDevolucao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvDevolucao.Location = new System.Drawing.Point(60, 178);
            this.dgvDevolucao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvDevolucao.MultiSelect = false;
            this.dgvDevolucao.Name = "dgvDevolucao";
            this.dgvDevolucao.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucao.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvDevolucao.RowHeadersVisible = false;
            this.dgvDevolucao.RowTemplate.Height = 43;
            this.dgvDevolucao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucao.Size = new System.Drawing.Size(883, 352);
            this.dgvDevolucao.TabIndex = 86;
            // 
            // metroTxtBoxPesquisar
            // 
            this.metroTxtBoxPesquisar.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTxtBoxPesquisar.CustomButton.Image = null;
            this.metroTxtBoxPesquisar.CustomButton.Location = new System.Drawing.Point(615, 1);
            this.metroTxtBoxPesquisar.CustomButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroTxtBoxPesquisar.CustomButton.Name = "";
            this.metroTxtBoxPesquisar.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTxtBoxPesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtBoxPesquisar.CustomButton.TabIndex = 1;
            this.metroTxtBoxPesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtBoxPesquisar.CustomButton.UseSelectable = true;
            this.metroTxtBoxPesquisar.CustomButton.Visible = false;
            this.metroTxtBoxPesquisar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTxtBoxPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.metroTxtBoxPesquisar.Lines = new string[0];
            this.metroTxtBoxPesquisar.Location = new System.Drawing.Point(60, 90);
            this.metroTxtBoxPesquisar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroTxtBoxPesquisar.MaxLength = 32767;
            this.metroTxtBoxPesquisar.Name = "metroTxtBoxPesquisar";
            this.metroTxtBoxPesquisar.PasswordChar = '\0';
            this.metroTxtBoxPesquisar.PromptText = "Pesquisar";
            this.metroTxtBoxPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtBoxPesquisar.SelectedText = "";
            this.metroTxtBoxPesquisar.SelectionLength = 0;
            this.metroTxtBoxPesquisar.SelectionStart = 0;
            this.metroTxtBoxPesquisar.ShortcutsEnabled = true;
            this.metroTxtBoxPesquisar.Size = new System.Drawing.Size(649, 35);
            this.metroTxtBoxPesquisar.TabIndex = 87;
            this.metroTxtBoxPesquisar.UseSelectable = true;
            this.metroTxtBoxPesquisar.WaterMark = "Pesquisar";
            this.metroTxtBoxPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.metroTxtBoxPesquisar.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(233)))));
            this.btnDevolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDevolver.Location = new System.Drawing.Point(833, 558);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(110, 40);
            this.btnDevolver.TabIndex = 85;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
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
            this.btnAtualizar.Location = new System.Drawing.Point(794, 92);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(30, 30);
            this.btnAtualizar.TabIndex = 84;
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
            this.btnPesquisar.Location = new System.Drawing.Point(736, 92);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisar.TabIndex = 83;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // radioNomeLeitor
            // 
            this.radioNomeLeitor.AutoSize = true;
            this.radioNomeLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioNomeLeitor.FlatAppearance.BorderSize = 2;
            this.radioNomeLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioNomeLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioNomeLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioNomeLeitor.Location = new System.Drawing.Point(153, 131);
            this.radioNomeLeitor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioNomeLeitor.Name = "radioNomeLeitor";
            this.radioNomeLeitor.Size = new System.Drawing.Size(112, 24);
            this.radioNomeLeitor.TabIndex = 82;
            this.radioNomeLeitor.Text = "Nome Leitor";
            this.radioNomeLeitor.UseVisualStyleBackColor = true;
            this.radioNomeLeitor.CheckedChanged += new System.EventHandler(this.radioNomeLeitor_CheckedChanged);
            // 
            // radioIdEmprestimo
            // 
            this.radioIdEmprestimo.AutoSize = true;
            this.radioIdEmprestimo.Checked = true;
            this.radioIdEmprestimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioIdEmprestimo.FlatAppearance.BorderSize = 2;
            this.radioIdEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioIdEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioIdEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioIdEmprestimo.Location = new System.Drawing.Point(60, 131);
            this.radioIdEmprestimo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioIdEmprestimo.Name = "radioIdEmprestimo";
            this.radioIdEmprestimo.Size = new System.Drawing.Size(84, 24);
            this.radioIdEmprestimo.TabIndex = 81;
            this.radioIdEmprestimo.TabStop = true;
            this.radioIdEmprestimo.Text = "ID Emp.";
            this.radioIdEmprestimo.UseVisualStyleBackColor = true;
            this.radioIdEmprestimo.CheckedChanged += new System.EventHandler(this.radioIdEmprestimo_CheckedChanged);
            // 
            // pk_id_emprestimo
            // 
            this.pk_id_emprestimo.DataPropertyName = "pk_id_emprestimo";
            this.pk_id_emprestimo.FillWeight = 60F;
            this.pk_id_emprestimo.HeaderText = "ID Emp.";
            this.pk_id_emprestimo.Name = "pk_id_emprestimo";
            this.pk_id_emprestimo.ReadOnly = true;
            // 
            // fk_id_leitor_emprestimo
            // 
            this.fk_id_leitor_emprestimo.DataPropertyName = "fk_id_leitor_emprestimo";
            this.fk_id_leitor_emprestimo.HeaderText = "ID Lt.";
            this.fk_id_leitor_emprestimo.Name = "fk_id_leitor_emprestimo";
            this.fk_id_leitor_emprestimo.ReadOnly = true;
            this.fk_id_leitor_emprestimo.Visible = false;
            // 
            // fk_id_livro_emprestimo
            // 
            this.fk_id_livro_emprestimo.DataPropertyName = "fk_id_livro_emprestimo";
            this.fk_id_livro_emprestimo.HeaderText = "ID Lv.";
            this.fk_id_livro_emprestimo.Name = "fk_id_livro_emprestimo";
            this.fk_id_livro_emprestimo.ReadOnly = true;
            this.fk_id_livro_emprestimo.Visible = false;
            // 
            // nome_leitor
            // 
            this.nome_leitor.DataPropertyName = "nome_leitor";
            this.nome_leitor.HeaderText = "Nome Leitor";
            this.nome_leitor.Name = "nome_leitor";
            this.nome_leitor.ReadOnly = true;
            // 
            // titulo_livro
            // 
            this.titulo_livro.DataPropertyName = "titulo_livro";
            this.titulo_livro.HeaderText = "Título Livro";
            this.titulo_livro.Name = "titulo_livro";
            this.titulo_livro.ReadOnly = true;
            // 
            // dt_emprestimo
            // 
            this.dt_emprestimo.DataPropertyName = "dt_emprestimo";
            this.dt_emprestimo.FillWeight = 80F;
            this.dt_emprestimo.HeaderText = "Dt. Empréstimo";
            this.dt_emprestimo.Name = "dt_emprestimo";
            this.dt_emprestimo.ReadOnly = true;
            // 
            // dt_dev_prev_emprestimo
            // 
            this.dt_dev_prev_emprestimo.DataPropertyName = "dt_dev_prev_emprestimo";
            this.dt_dev_prev_emprestimo.FillWeight = 85F;
            this.dt_dev_prev_emprestimo.HeaderText = "Dt. Dev. Prevista";
            this.dt_dev_prev_emprestimo.Name = "dt_dev_prev_emprestimo";
            this.dt_dev_prev_emprestimo.ReadOnly = true;
            // 
            // radioTituloLivro
            // 
            this.radioTituloLivro.AutoSize = true;
            this.radioTituloLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioTituloLivro.FlatAppearance.BorderSize = 2;
            this.radioTituloLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioTituloLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioTituloLivro.Location = new System.Drawing.Point(276, 131);
            this.radioTituloLivro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioTituloLivro.Name = "radioTituloLivro";
            this.radioTituloLivro.Size = new System.Drawing.Size(101, 24);
            this.radioTituloLivro.TabIndex = 92;
            this.radioTituloLivro.Text = "Título Livro";
            this.radioTituloLivro.UseVisualStyleBackColor = true;
            this.radioTituloLivro.CheckedChanged += new System.EventHandler(this.radioTituloLivro_CheckedChanged);
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.radioTituloLivro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.labelDgv);
            this.Controls.Add(this.metroTxtBoxPesquisar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.radioNomeLeitor);
            this.Controls.Add(this.radioIdEmprestimo);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.MainTopPanel);
            this.Controls.Add(this.dgvDevolucao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Devolução";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label labelDgv;
        private System.Windows.Forms.DataGridView dgvDevolucao;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxPesquisar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton radioNomeLeitor;
        private System.Windows.Forms.RadioButton radioIdEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk_id_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_id_leitor_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_id_livro_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_dev_prev_emprestimo;
        private System.Windows.Forms.RadioButton radioTituloLivro;
    }
}