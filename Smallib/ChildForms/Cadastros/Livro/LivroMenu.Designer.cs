namespace Smallib.ChildForms.Cadastros.Livros
{
    partial class LivroMenu
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
            this.labelDgv = new System.Windows.Forms.Label();
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.pk_id_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tombo_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultemprest_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultleitor_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.radioTituloLivro = new System.Windows.Forms.RadioButton();
            this.radioIdLivro = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.MainTopLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.metroTxtBoxPesquisar = new MetroFramework.Controls.MetroTextBox();
            this.radioAutorLivro = new System.Windows.Forms.RadioButton();
            this.radioGeneroLivro = new System.Windows.Forms.RadioButton();
            this.radioEditoraLivro = new System.Windows.Forms.RadioButton();
            this.radioStatusLivro = new System.Windows.Forms.RadioButton();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.MainTopPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            // dgvLivro
            // 
            this.dgvLivro.AllowUserToAddRows = false;
            this.dgvLivro.AllowUserToDeleteRows = false;
            this.dgvLivro.AllowUserToResizeColumns = false;
            this.dgvLivro.AllowUserToResizeRows = false;
            this.dgvLivro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pk_id_livro,
            this.titulo_livro,
            this.tombo_livro,
            this.nome_editora,
            this.nome_genero,
            this.nome_autor,
            this.nome_idioma,
            this.ultemprest_livro,
            this.ultleitor_livro,
            this.status_livro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLivro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivro.EnableHeadersVisualStyles = false;
            this.dgvLivro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvLivro.Location = new System.Drawing.Point(60, 177);
            this.dgvLivro.MultiSelect = false;
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLivro.RowHeadersVisible = false;
            this.dgvLivro.RowTemplate.Height = 43;
            this.dgvLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivro.Size = new System.Drawing.Size(883, 353);
            this.dgvLivro.TabIndex = 26;
            // 
            // pk_id_livro
            // 
            this.pk_id_livro.DataPropertyName = "pk_id_livro";
            this.pk_id_livro.FillWeight = 40.92407F;
            this.pk_id_livro.HeaderText = "ID ";
            this.pk_id_livro.Name = "pk_id_livro";
            this.pk_id_livro.ReadOnly = true;
            // 
            // titulo_livro
            // 
            this.titulo_livro.DataPropertyName = "titulo_livro";
            this.titulo_livro.FillWeight = 100.0759F;
            this.titulo_livro.HeaderText = "Titulo ";
            this.titulo_livro.Name = "titulo_livro";
            this.titulo_livro.ReadOnly = true;
            // 
            // tombo_livro
            // 
            this.tombo_livro.DataPropertyName = "tombo_livro";
            this.tombo_livro.HeaderText = "Tombamento";
            this.tombo_livro.Name = "tombo_livro";
            this.tombo_livro.ReadOnly = true;
            this.tombo_livro.Visible = false;
            // 
            // nome_editora
            // 
            this.nome_editora.DataPropertyName = "nome_editora";
            this.nome_editora.HeaderText = "Editora";
            this.nome_editora.Name = "nome_editora";
            this.nome_editora.ReadOnly = true;
            // 
            // nome_genero
            // 
            this.nome_genero.DataPropertyName = "nome_genero";
            this.nome_genero.HeaderText = "Gênero";
            this.nome_genero.Name = "nome_genero";
            this.nome_genero.ReadOnly = true;
            // 
            // nome_autor
            // 
            this.nome_autor.DataPropertyName = "nome_autor";
            this.nome_autor.HeaderText = "Autor";
            this.nome_autor.Name = "nome_autor";
            this.nome_autor.ReadOnly = true;
            // 
            // nome_idioma
            // 
            this.nome_idioma.DataPropertyName = "nome_idioma";
            this.nome_idioma.HeaderText = "Idioma";
            this.nome_idioma.Name = "nome_idioma";
            this.nome_idioma.ReadOnly = true;
            this.nome_idioma.Visible = false;
            // 
            // ultemprest_livro
            // 
            this.ultemprest_livro.DataPropertyName = "ultemprest_livro";
            this.ultemprest_livro.HeaderText = "Último Empréstimo";
            this.ultemprest_livro.Name = "ultemprest_livro";
            this.ultemprest_livro.ReadOnly = true;
            this.ultemprest_livro.Visible = false;
            // 
            // ultleitor_livro
            // 
            this.ultleitor_livro.DataPropertyName = "ultleitor_livro";
            this.ultleitor_livro.HeaderText = "Último Leitor";
            this.ultleitor_livro.Name = "ultleitor_livro";
            this.ultleitor_livro.ReadOnly = true;
            this.ultleitor_livro.Visible = false;
            // 
            // status_livro
            // 
            this.status_livro.DataPropertyName = "status_livro";
            this.status_livro.HeaderText = "Status";
            this.status_livro.Name = "status_livro";
            this.status_livro.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(131)))), ((int)(((byte)(58)))));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnConsultar.Location = new System.Drawing.Point(516, 552);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 40);
            this.btnConsultar.TabIndex = 25;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnExcluir.Location = new System.Drawing.Point(365, 552);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 40);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnEditar.Location = new System.Drawing.Point(215, 552);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 40);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnNovo.Location = new System.Drawing.Point(60, 552);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 40);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // radioTituloLivro
            // 
            this.radioTituloLivro.AutoSize = true;
            this.radioTituloLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioTituloLivro.FlatAppearance.BorderSize = 2;
            this.radioTituloLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioTituloLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioTituloLivro.Location = new System.Drawing.Point(121, 131);
            this.radioTituloLivro.Name = "radioTituloLivro";
            this.radioTituloLivro.Size = new System.Drawing.Size(64, 24);
            this.radioTituloLivro.TabIndex = 19;
            this.radioTituloLivro.TabStop = true;
            this.radioTituloLivro.Text = "Titulo";
            this.radioTituloLivro.UseVisualStyleBackColor = true;
            this.radioTituloLivro.CheckedChanged += new System.EventHandler(this.radioTituloLivro_CheckedChanged);
            // 
            // radioIdLivro
            // 
            this.radioIdLivro.AutoSize = true;
            this.radioIdLivro.Checked = true;
            this.radioIdLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioIdLivro.FlatAppearance.BorderSize = 2;
            this.radioIdLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioIdLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioIdLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioIdLivro.Location = new System.Drawing.Point(60, 131);
            this.radioIdLivro.Name = "radioIdLivro";
            this.radioIdLivro.Size = new System.Drawing.Size(43, 24);
            this.radioIdLivro.TabIndex = 18;
            this.radioIdLivro.TabStop = true;
            this.radioIdLivro.Text = "ID";
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
            // MainTopLabel
            // 
            this.MainTopLabel.AutoSize = true;
            this.MainTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.MainTopLabel.Location = new System.Drawing.Point(46, 12);
            this.MainTopLabel.Name = "MainTopLabel";
            this.MainTopLabel.Size = new System.Drawing.Size(202, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Cadastro de Livro";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel5.Controls.Add(this.dgvLivro);
            this.panel5.Controls.Add(this.btnRelatorio);
            this.panel5.Controls.Add(this.metroTxtBoxPesquisar);
            this.panel5.Controls.Add(this.radioAutorLivro);
            this.panel5.Controls.Add(this.radioGeneroLivro);
            this.panel5.Controls.Add(this.radioEditoraLivro);
            this.panel5.Controls.Add(this.labelDgv);
            this.panel5.Controls.Add(this.btnConsultar);
            this.panel5.Controls.Add(this.btnExcluir);
            this.panel5.Controls.Add(this.btnEditar);
            this.panel5.Controls.Add(this.btnNovo);
            this.panel5.Controls.Add(this.btnAtualizar);
            this.panel5.Controls.Add(this.btnPesquisar);
            this.panel5.Controls.Add(this.radioTituloLivro);
            this.panel5.Controls.Add(this.radioIdLivro);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.MainTopPanel);
            this.panel5.Controls.Add(this.radioStatusLivro);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1004, 631);
            this.panel5.TabIndex = 19;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(233)))));
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnRelatorio.Location = new System.Drawing.Point(833, 552);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(110, 40);
            this.btnRelatorio.TabIndex = 48;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // metroTxtBoxPesquisar
            // 
            this.metroTxtBoxPesquisar.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTxtBoxPesquisar.CustomButton.Image = null;
            this.metroTxtBoxPesquisar.CustomButton.Location = new System.Drawing.Point(615, 1);
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
            this.metroTxtBoxPesquisar.Size = new System.Drawing.Size(649, 35);
            this.metroTxtBoxPesquisar.TabIndex = 33;
            this.metroTxtBoxPesquisar.UseSelectable = true;
            this.metroTxtBoxPesquisar.WaterMark = "Pesquisar";
            this.metroTxtBoxPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.metroTxtBoxPesquisar.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // radioAutorLivro
            // 
            this.radioAutorLivro.AutoSize = true;
            this.radioAutorLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioAutorLivro.FlatAppearance.BorderSize = 2;
            this.radioAutorLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioAutorLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioAutorLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioAutorLivro.Location = new System.Drawing.Point(403, 131);
            this.radioAutorLivro.Name = "radioAutorLivro";
            this.radioAutorLivro.Size = new System.Drawing.Size(65, 24);
            this.radioAutorLivro.TabIndex = 31;
            this.radioAutorLivro.TabStop = true;
            this.radioAutorLivro.Text = "Autor";
            this.radioAutorLivro.UseVisualStyleBackColor = true;
            this.radioAutorLivro.CheckedChanged += new System.EventHandler(this.radioAutorLivro_CheckedChanged);
            // 
            // radioGeneroLivro
            // 
            this.radioGeneroLivro.AutoSize = true;
            this.radioGeneroLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioGeneroLivro.FlatAppearance.BorderSize = 2;
            this.radioGeneroLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioGeneroLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioGeneroLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioGeneroLivro.Location = new System.Drawing.Point(302, 131);
            this.radioGeneroLivro.Name = "radioGeneroLivro";
            this.radioGeneroLivro.Size = new System.Drawing.Size(80, 24);
            this.radioGeneroLivro.TabIndex = 30;
            this.radioGeneroLivro.TabStop = true;
            this.radioGeneroLivro.Text = "Gênero";
            this.radioGeneroLivro.UseVisualStyleBackColor = true;
            this.radioGeneroLivro.CheckedChanged += new System.EventHandler(this.radioGeneroLivro_CheckedChanged);
            // 
            // radioEditoraLivro
            // 
            this.radioEditoraLivro.AutoSize = true;
            this.radioEditoraLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioEditoraLivro.FlatAppearance.BorderSize = 2;
            this.radioEditoraLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioEditoraLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioEditoraLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioEditoraLivro.Location = new System.Drawing.Point(204, 131);
            this.radioEditoraLivro.Name = "radioEditoraLivro";
            this.radioEditoraLivro.Size = new System.Drawing.Size(77, 24);
            this.radioEditoraLivro.TabIndex = 29;
            this.radioEditoraLivro.TabStop = true;
            this.radioEditoraLivro.Text = "Editora";
            this.radioEditoraLivro.UseVisualStyleBackColor = true;
            this.radioEditoraLivro.CheckedChanged += new System.EventHandler(this.radioEditoraLivro_CheckedChanged);
            // 
            // radioStatusLivro
            // 
            this.radioStatusLivro.AutoSize = true;
            this.radioStatusLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioStatusLivro.FlatAppearance.BorderSize = 2;
            this.radioStatusLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioStatusLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioStatusLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioStatusLivro.Location = new System.Drawing.Point(488, 131);
            this.radioStatusLivro.Name = "radioStatusLivro";
            this.radioStatusLivro.Size = new System.Drawing.Size(73, 24);
            this.radioStatusLivro.TabIndex = 34;
            this.radioStatusLivro.TabStop = true;
            this.radioStatusLivro.Text = "Status";
            this.radioStatusLivro.UseVisualStyleBackColor = true;
            this.radioStatusLivro.CheckedChanged += new System.EventHandler(this.radioStatusLivro_CheckedChanged);
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
            this.btnPesquisar.Location = new System.Drawing.Point(736, 92);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // LivroMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LivroMenu";
            this.Text = "LivrosMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDgv;
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton radioTituloLivro;
        private System.Windows.Forms.RadioButton radioIdLivro;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioAutorLivro;
        private System.Windows.Forms.RadioButton radioGeneroLivro;
        private System.Windows.Forms.RadioButton radioEditoraLivro;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxPesquisar;
        private System.Windows.Forms.RadioButton radioStatusLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk_id_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tombo_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultemprest_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultleitor_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_livro;
        private System.Windows.Forms.Button btnRelatorio;
    }
}