
namespace Smallib.ChildForms.Relatorios.RelatoriosAdministrativos
{
    partial class RelLeitoresDevPendentes
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
            this.dgvDevPendentes = new System.Windows.Forms.DataGridView();
            this.pk_id_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_cel_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_dev_prev_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.radioDataDevPrevista = new System.Windows.Forms.RadioButton();
            this.radioDataEmprestimo = new System.Windows.Forms.RadioButton();
            this.radioTituloLivro = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDgv = new System.Windows.Forms.Label();
            this.radioCursoLeitor = new System.Windows.Forms.RadioButton();
            this.metroTxtBoxPesquisar = new MetroFramework.Controls.MetroTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.radioNomeLeitor = new System.Windows.Forms.RadioButton();
            this.radioIdEmprestimo = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.MainTopLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevPendentes)).BeginInit();
            this.panel5.SuspendLayout();
            this.MainTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDevPendentes
            // 
            this.dgvDevPendentes.AllowUserToAddRows = false;
            this.dgvDevPendentes.AllowUserToDeleteRows = false;
            this.dgvDevPendentes.AllowUserToResizeColumns = false;
            this.dgvDevPendentes.AllowUserToResizeRows = false;
            this.dgvDevPendentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevPendentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevPendentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pk_id_emprestimo,
            this.nome_leitor,
            this.titulo_livro,
            this.tel_cel_leitor,
            this.dt_emprestimo,
            this.dt_dev_prev_emprestimo,
            this.nome_tipo,
            this.nome_curso,
            this.classe_leitor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevPendentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevPendentes.EnableHeadersVisualStyles = false;
            this.dgvDevPendentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvDevPendentes.Location = new System.Drawing.Point(60, 177);
            this.dgvDevPendentes.MultiSelect = false;
            this.dgvDevPendentes.Name = "dgvDevPendentes";
            this.dgvDevPendentes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevPendentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDevPendentes.RowHeadersVisible = false;
            this.dgvDevPendentes.RowTemplate.Height = 43;
            this.dgvDevPendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevPendentes.Size = new System.Drawing.Size(883, 353);
            this.dgvDevPendentes.TabIndex = 26;
            // 
            // pk_id_emprestimo
            // 
            this.pk_id_emprestimo.DataPropertyName = "pk_id_emprestimo";
            this.pk_id_emprestimo.FillWeight = 30F;
            this.pk_id_emprestimo.HeaderText = "ID Emp.";
            this.pk_id_emprestimo.Name = "pk_id_emprestimo";
            this.pk_id_emprestimo.ReadOnly = true;
            // 
            // nome_leitor
            // 
            this.nome_leitor.DataPropertyName = "nome_leitor";
            this.nome_leitor.FillWeight = 40F;
            this.nome_leitor.HeaderText = "Nome Leitor";
            this.nome_leitor.Name = "nome_leitor";
            this.nome_leitor.ReadOnly = true;
            // 
            // titulo_livro
            // 
            this.titulo_livro.DataPropertyName = "titulo_livro";
            this.titulo_livro.FillWeight = 40F;
            this.titulo_livro.HeaderText = "Título Livro";
            this.titulo_livro.Name = "titulo_livro";
            this.titulo_livro.ReadOnly = true;
            // 
            // tel_cel_leitor
            // 
            this.tel_cel_leitor.DataPropertyName = "tel_cel_leitor";
            this.tel_cel_leitor.HeaderText = "Telefone";
            this.tel_cel_leitor.Name = "tel_cel_leitor";
            this.tel_cel_leitor.ReadOnly = true;
            this.tel_cel_leitor.Visible = false;
            // 
            // dt_emprestimo
            // 
            this.dt_emprestimo.DataPropertyName = "dt_emprestimo";
            this.dt_emprestimo.FillWeight = 50F;
            this.dt_emprestimo.HeaderText = "Dt. Empréstimo";
            this.dt_emprestimo.Name = "dt_emprestimo";
            this.dt_emprestimo.ReadOnly = true;
            // 
            // dt_dev_prev_emprestimo
            // 
            this.dt_dev_prev_emprestimo.DataPropertyName = "dt_dev_prev_emprestimo";
            this.dt_dev_prev_emprestimo.FillWeight = 50F;
            this.dt_dev_prev_emprestimo.HeaderText = "Dt. Dev. Prevista";
            this.dt_dev_prev_emprestimo.Name = "dt_dev_prev_emprestimo";
            this.dt_dev_prev_emprestimo.ReadOnly = true;
            // 
            // nome_tipo
            // 
            this.nome_tipo.DataPropertyName = "nome_tipo";
            this.nome_tipo.FillWeight = 50F;
            this.nome_tipo.HeaderText = "Tipo";
            this.nome_tipo.Name = "nome_tipo";
            this.nome_tipo.ReadOnly = true;
            this.nome_tipo.Visible = false;
            // 
            // nome_curso
            // 
            this.nome_curso.DataPropertyName = "nome_curso";
            this.nome_curso.FillWeight = 32F;
            this.nome_curso.HeaderText = "Curso";
            this.nome_curso.Name = "nome_curso";
            this.nome_curso.ReadOnly = true;
            // 
            // classe_leitor
            // 
            this.classe_leitor.DataPropertyName = "classe_leitor";
            this.classe_leitor.HeaderText = "Classe";
            this.classe_leitor.Name = "classe_leitor";
            this.classe_leitor.ReadOnly = true;
            this.classe_leitor.Visible = false;
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
            // radioDataDevPrevista
            // 
            this.radioDataDevPrevista.AutoSize = true;
            this.radioDataDevPrevista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioDataDevPrevista.FlatAppearance.BorderSize = 2;
            this.radioDataDevPrevista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDataDevPrevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioDataDevPrevista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioDataDevPrevista.Location = new System.Drawing.Point(564, 131);
            this.radioDataDevPrevista.Name = "radioDataDevPrevista";
            this.radioDataDevPrevista.Size = new System.Drawing.Size(143, 24);
            this.radioDataDevPrevista.TabIndex = 32;
            this.radioDataDevPrevista.Text = "Dt. Dev. Prevista";
            this.radioDataDevPrevista.UseVisualStyleBackColor = true;
            this.radioDataDevPrevista.Click += new System.EventHandler(this.radioDataDevPrevista_CheckedChanged);
            // 
            // radioDataEmprestimo
            // 
            this.radioDataEmprestimo.AutoSize = true;
            this.radioDataEmprestimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioDataEmprestimo.FlatAppearance.BorderSize = 2;
            this.radioDataEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDataEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioDataEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioDataEmprestimo.Location = new System.Drawing.Point(410, 131);
            this.radioDataEmprestimo.Name = "radioDataEmprestimo";
            this.radioDataEmprestimo.Size = new System.Drawing.Size(136, 24);
            this.radioDataEmprestimo.TabIndex = 31;
            this.radioDataEmprestimo.Text = "Dt. Emprestimo";
            this.radioDataEmprestimo.UseVisualStyleBackColor = true;
            this.radioDataEmprestimo.CheckedChanged += new System.EventHandler(this.radioDataEmprestimo_CheckedChanged);
            // 
            // radioTituloLivro
            // 
            this.radioTituloLivro.AutoSize = true;
            this.radioTituloLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioTituloLivro.FlatAppearance.BorderSize = 2;
            this.radioTituloLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioTituloLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioTituloLivro.Location = new System.Drawing.Point(288, 131);
            this.radioTituloLivro.Name = "radioTituloLivro";
            this.radioTituloLivro.Size = new System.Drawing.Size(101, 24);
            this.radioTituloLivro.TabIndex = 29;
            this.radioTituloLivro.Text = "Título Livro";
            this.radioTituloLivro.UseVisualStyleBackColor = true;
            this.radioTituloLivro.CheckedChanged += new System.EventHandler(this.radioTituloLivro_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel5.Controls.Add(this.labelDgv);
            this.panel5.Controls.Add(this.radioCursoLeitor);
            this.panel5.Controls.Add(this.btnRelatorio);
            this.panel5.Controls.Add(this.radioDataDevPrevista);
            this.panel5.Controls.Add(this.radioDataEmprestimo);
            this.panel5.Controls.Add(this.metroTxtBoxPesquisar);
            this.panel5.Controls.Add(this.radioTituloLivro);
            this.panel5.Controls.Add(this.btnVoltar);
            this.panel5.Controls.Add(this.btnAtualizar);
            this.panel5.Controls.Add(this.btnPesquisar);
            this.panel5.Controls.Add(this.radioNomeLeitor);
            this.panel5.Controls.Add(this.radioIdEmprestimo);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.MainTopPanel);
            this.panel5.Controls.Add(this.dgvDevPendentes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1004, 631);
            this.panel5.TabIndex = 20;
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
            // radioCursoLeitor
            // 
            this.radioCursoLeitor.AutoSize = true;
            this.radioCursoLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioCursoLeitor.FlatAppearance.BorderSize = 2;
            this.radioCursoLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioCursoLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioCursoLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioCursoLeitor.Location = new System.Drawing.Point(723, 131);
            this.radioCursoLeitor.Name = "radioCursoLeitor";
            this.radioCursoLeitor.Size = new System.Drawing.Size(68, 24);
            this.radioCursoLeitor.TabIndex = 48;
            this.radioCursoLeitor.Text = "Curso";
            this.radioCursoLeitor.UseVisualStyleBackColor = true;
            this.radioCursoLeitor.Click += new System.EventHandler(this.radioCursoLeitor_CheckedChanged);
            // 
            // metroTxtBoxPesquisar
            // 
            this.metroTxtBoxPesquisar.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTxtBoxPesquisar.CustomButton.Image = null;
            this.metroTxtBoxPesquisar.CustomButton.Location = new System.Drawing.Point(740, 1);
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
            this.metroTxtBoxPesquisar.MaxLength = 32767;
            this.metroTxtBoxPesquisar.Name = "metroTxtBoxPesquisar";
            this.metroTxtBoxPesquisar.PasswordChar = '\0';
            this.metroTxtBoxPesquisar.PromptText = "Pesquisar";
            this.metroTxtBoxPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtBoxPesquisar.SelectedText = "";
            this.metroTxtBoxPesquisar.SelectionLength = 0;
            this.metroTxtBoxPesquisar.SelectionStart = 0;
            this.metroTxtBoxPesquisar.ShortcutsEnabled = true;
            this.metroTxtBoxPesquisar.Size = new System.Drawing.Size(774, 35);
            this.metroTxtBoxPesquisar.TabIndex = 30;
            this.metroTxtBoxPesquisar.UseSelectable = true;
            this.metroTxtBoxPesquisar.WaterMark = "Pesquisar";
            this.metroTxtBoxPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.metroTxtBoxPesquisar.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAtualizar.Location = new System.Drawing.Point(907, 92);
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
            this.btnPesquisar.Location = new System.Drawing.Point(849, 92);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisar.TabIndex = 20;
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
            this.radioNomeLeitor.Location = new System.Drawing.Point(159, 131);
            this.radioNomeLeitor.Name = "radioNomeLeitor";
            this.radioNomeLeitor.Size = new System.Drawing.Size(112, 24);
            this.radioNomeLeitor.TabIndex = 19;
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
            this.radioIdEmprestimo.Name = "radioIdEmprestimo";
            this.radioIdEmprestimo.Size = new System.Drawing.Size(84, 24);
            this.radioIdEmprestimo.TabIndex = 18;
            this.radioIdEmprestimo.TabStop = true;
            this.radioIdEmprestimo.Text = "ID Emp.";
            this.radioIdEmprestimo.UseVisualStyleBackColor = true;
            this.radioIdEmprestimo.CheckedChanged += new System.EventHandler(this.radioIdEmprestimo_CheckedChanged);
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
            this.MainTopLabel.Size = new System.Drawing.Size(528, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Relatório Administrativo: Devoluções Pendentes";
            // 
            // RelLeitoresDevPendentes
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelLeitoresDevPendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevPendentes)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevPendentes;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.RadioButton radioDataDevPrevista;
        private System.Windows.Forms.RadioButton radioDataEmprestimo;
        private System.Windows.Forms.RadioButton radioTituloLivro;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxPesquisar;
        private System.Windows.Forms.Label labelDgv;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton radioNomeLeitor;
        private System.Windows.Forms.RadioButton radioIdEmprestimo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.RadioButton radioCursoLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk_id_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_cel_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_dev_prev_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe_leitor;
    }
}