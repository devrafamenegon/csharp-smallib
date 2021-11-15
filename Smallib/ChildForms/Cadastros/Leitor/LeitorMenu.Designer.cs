namespace Smallib.ChildForms.Cadastros.Leitores
{
    partial class LeitorMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDgv = new System.Windows.Forms.Label();
            this.dgvLeitor = new System.Windows.Forms.DataGridView();
            this.pk_id_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_cel_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtnasc_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcad_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.radioNomeLeitor = new System.Windows.Forms.RadioButton();
            this.radioIdLeitor = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.MainTopLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.radioStatusLeitor = new System.Windows.Forms.RadioButton();
            this.radioTipoLeitor = new System.Windows.Forms.RadioButton();
            this.metroTxtBoxPesquisar = new MetroFramework.Controls.MetroTextBox();
            this.radioCidadeLeitor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).BeginInit();
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
            // dgvLeitor
            // 
            this.dgvLeitor.AllowUserToAddRows = false;
            this.dgvLeitor.AllowUserToDeleteRows = false;
            this.dgvLeitor.AllowUserToResizeColumns = false;
            this.dgvLeitor.AllowUserToResizeRows = false;
            this.dgvLeitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeitor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pk_id_leitor,
            this.nome_leitor,
            this.email_leitor,
            this.tel_cel_leitor,
            this.rg_leitor,
            this.dtnasc_leitor,
            this.dtcad_leitor,
            this.nome_cidade,
            this.estado_cidade,
            this.nome_tipo,
            this.nome_curso,
            this.classe_leitor,
            this.status_leitor});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeitor.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLeitor.EnableHeadersVisualStyles = false;
            this.dgvLeitor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvLeitor.Location = new System.Drawing.Point(60, 177);
            this.dgvLeitor.MultiSelect = false;
            this.dgvLeitor.Name = "dgvLeitor";
            this.dgvLeitor.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeitor.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLeitor.RowHeadersVisible = false;
            this.dgvLeitor.RowTemplate.Height = 43;
            this.dgvLeitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeitor.Size = new System.Drawing.Size(883, 353);
            this.dgvLeitor.TabIndex = 26;
            // 
            // pk_id_leitor
            // 
            this.pk_id_leitor.DataPropertyName = "pk_id_leitor";
            this.pk_id_leitor.FillWeight = 20.92407F;
            this.pk_id_leitor.HeaderText = "ID ";
            this.pk_id_leitor.Name = "pk_id_leitor";
            this.pk_id_leitor.ReadOnly = true;
            // 
            // nome_leitor
            // 
            this.nome_leitor.DataPropertyName = "nome_leitor";
            this.nome_leitor.HeaderText = "Nome";
            this.nome_leitor.Name = "nome_leitor";
            this.nome_leitor.ReadOnly = true;
            // 
            // email_leitor
            // 
            this.email_leitor.DataPropertyName = "email_leitor";
            this.email_leitor.HeaderText = "Email";
            this.email_leitor.Name = "email_leitor";
            this.email_leitor.ReadOnly = true;
            this.email_leitor.Visible = false;
            // 
            // tel_cel_leitor
            // 
            this.tel_cel_leitor.DataPropertyName = "tel_cel_leitor";
            this.tel_cel_leitor.HeaderText = "Tel. Celular";
            this.tel_cel_leitor.Name = "tel_cel_leitor";
            this.tel_cel_leitor.ReadOnly = true;
            this.tel_cel_leitor.Visible = false;
            // 
            // rg_leitor
            // 
            this.rg_leitor.DataPropertyName = "rg_leitor";
            this.rg_leitor.HeaderText = "RG";
            this.rg_leitor.Name = "rg_leitor";
            this.rg_leitor.ReadOnly = true;
            this.rg_leitor.Visible = false;
            // 
            // dtnasc_leitor
            // 
            this.dtnasc_leitor.DataPropertyName = "dtnasc_leitor";
            this.dtnasc_leitor.HeaderText = "Data de Nascimento";
            this.dtnasc_leitor.Name = "dtnasc_leitor";
            this.dtnasc_leitor.ReadOnly = true;
            this.dtnasc_leitor.Visible = false;
            // 
            // dtcad_leitor
            // 
            this.dtcad_leitor.DataPropertyName = "dtcad_leitor";
            this.dtcad_leitor.HeaderText = "Data de Atualização";
            this.dtcad_leitor.Name = "dtcad_leitor";
            this.dtcad_leitor.ReadOnly = true;
            this.dtcad_leitor.Visible = false;
            // 
            // nome_cidade
            // 
            this.nome_cidade.DataPropertyName = "nome_cidade";
            this.nome_cidade.FillWeight = 60F;
            this.nome_cidade.HeaderText = "Cidade";
            this.nome_cidade.Name = "nome_cidade";
            this.nome_cidade.ReadOnly = true;
            // 
            // estado_cidade
            // 
            this.estado_cidade.DataPropertyName = "estado_cidade";
            this.estado_cidade.HeaderText = "Estado";
            this.estado_cidade.Name = "estado_cidade";
            this.estado_cidade.ReadOnly = true;
            this.estado_cidade.Visible = false;
            // 
            // nome_tipo
            // 
            this.nome_tipo.DataPropertyName = "nome_tipo";
            this.nome_tipo.FillWeight = 50F;
            this.nome_tipo.HeaderText = "Tipo";
            this.nome_tipo.Name = "nome_tipo";
            this.nome_tipo.ReadOnly = true;
            // 
            // nome_curso
            // 
            this.nome_curso.DataPropertyName = "nome_curso";
            this.nome_curso.HeaderText = "Curso";
            this.nome_curso.Name = "nome_curso";
            this.nome_curso.ReadOnly = true;
            this.nome_curso.Visible = false;
            // 
            // classe_leitor
            // 
            this.classe_leitor.DataPropertyName = "classe_leitor";
            this.classe_leitor.HeaderText = "Classe";
            this.classe_leitor.Name = "classe_leitor";
            this.classe_leitor.ReadOnly = true;
            this.classe_leitor.Visible = false;
            // 
            // status_leitor
            // 
            this.status_leitor.DataPropertyName = "status_leitor";
            this.status_leitor.FillWeight = 40F;
            this.status_leitor.HeaderText = "Status";
            this.status_leitor.Name = "status_leitor";
            this.status_leitor.ReadOnly = true;
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
            // radioNomeLeitor
            // 
            this.radioNomeLeitor.AutoSize = true;
            this.radioNomeLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioNomeLeitor.FlatAppearance.BorderSize = 2;
            this.radioNomeLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioNomeLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioNomeLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioNomeLeitor.Location = new System.Drawing.Point(127, 131);
            this.radioNomeLeitor.Name = "radioNomeLeitor";
            this.radioNomeLeitor.Size = new System.Drawing.Size(68, 24);
            this.radioNomeLeitor.TabIndex = 19;
            this.radioNomeLeitor.Text = "Nome";
            this.radioNomeLeitor.UseVisualStyleBackColor = true;
            this.radioNomeLeitor.CheckedChanged += new System.EventHandler(this.radioNomeLeitor_CheckedChanged);
            // 
            // radioIdLeitor
            // 
            this.radioIdLeitor.AutoSize = true;
            this.radioIdLeitor.Checked = true;
            this.radioIdLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioIdLeitor.FlatAppearance.BorderSize = 2;
            this.radioIdLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioIdLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioIdLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioIdLeitor.Location = new System.Drawing.Point(60, 131);
            this.radioIdLeitor.Name = "radioIdLeitor";
            this.radioIdLeitor.Size = new System.Drawing.Size(43, 24);
            this.radioIdLeitor.TabIndex = 18;
            this.radioIdLeitor.TabStop = true;
            this.radioIdLeitor.Text = "ID";
            this.radioIdLeitor.UseVisualStyleBackColor = true;
            this.radioIdLeitor.CheckedChanged += new System.EventHandler(this.radioIdLeitor_CheckedChanged);
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
            this.MainTopLabel.Size = new System.Drawing.Size(211, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Cadastro de Leitor";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel5.Controls.Add(this.dgvLeitor);
            this.panel5.Controls.Add(this.btnRelatorio);
            this.panel5.Controls.Add(this.radioStatusLeitor);
            this.panel5.Controls.Add(this.radioTipoLeitor);
            this.panel5.Controls.Add(this.metroTxtBoxPesquisar);
            this.panel5.Controls.Add(this.radioCidadeLeitor);
            this.panel5.Controls.Add(this.labelDgv);
            this.panel5.Controls.Add(this.btnConsultar);
            this.panel5.Controls.Add(this.btnExcluir);
            this.panel5.Controls.Add(this.btnEditar);
            this.panel5.Controls.Add(this.btnNovo);
            this.panel5.Controls.Add(this.btnAtualizar);
            this.panel5.Controls.Add(this.btnPesquisar);
            this.panel5.Controls.Add(this.radioNomeLeitor);
            this.panel5.Controls.Add(this.radioIdLeitor);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.MainTopPanel);
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
            this.btnRelatorio.TabIndex = 47;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // radioStatusLeitor
            // 
            this.radioStatusLeitor.AutoSize = true;
            this.radioStatusLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioStatusLeitor.FlatAppearance.BorderSize = 2;
            this.radioStatusLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioStatusLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioStatusLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioStatusLeitor.Location = new System.Drawing.Point(394, 131);
            this.radioStatusLeitor.Name = "radioStatusLeitor";
            this.radioStatusLeitor.Size = new System.Drawing.Size(73, 24);
            this.radioStatusLeitor.TabIndex = 32;
            this.radioStatusLeitor.Text = "Status";
            this.radioStatusLeitor.UseVisualStyleBackColor = true;
            this.radioStatusLeitor.CheckedChanged += new System.EventHandler(this.radioStatusLeitor_CheckedChanged);
            // 
            // radioTipoLeitor
            // 
            this.radioTipoLeitor.AutoSize = true;
            this.radioTipoLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioTipoLeitor.FlatAppearance.BorderSize = 2;
            this.radioTipoLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTipoLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioTipoLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioTipoLeitor.Location = new System.Drawing.Point(314, 131);
            this.radioTipoLeitor.Name = "radioTipoLeitor";
            this.radioTipoLeitor.Size = new System.Drawing.Size(56, 24);
            this.radioTipoLeitor.TabIndex = 31;
            this.radioTipoLeitor.Text = "Tipo";
            this.radioTipoLeitor.UseVisualStyleBackColor = true;
            this.radioTipoLeitor.CheckedChanged += new System.EventHandler(this.radioTipoLeitor_CheckedChanged);
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
            this.metroTxtBoxPesquisar.TabIndex = 30;
            this.metroTxtBoxPesquisar.UseSelectable = true;
            this.metroTxtBoxPesquisar.WaterMark = "Pesquisar";
            this.metroTxtBoxPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.metroTxtBoxPesquisar.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // radioCidadeLeitor
            // 
            this.radioCidadeLeitor.AutoSize = true;
            this.radioCidadeLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioCidadeLeitor.FlatAppearance.BorderSize = 2;
            this.radioCidadeLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioCidadeLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioCidadeLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioCidadeLeitor.Location = new System.Drawing.Point(216, 131);
            this.radioCidadeLeitor.Name = "radioCidadeLeitor";
            this.radioCidadeLeitor.Size = new System.Drawing.Size(76, 24);
            this.radioCidadeLeitor.TabIndex = 29;
            this.radioCidadeLeitor.Text = "Cidade";
            this.radioCidadeLeitor.UseVisualStyleBackColor = true;
            this.radioCidadeLeitor.CheckedChanged += new System.EventHandler(this.radioCidadeLeitor_CheckedChanged);
            // 
            // LeitorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeitorMenu";
            this.Text = "LeitoresMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).EndInit();
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDgv;
        private System.Windows.Forms.DataGridView dgvLeitor;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton radioNomeLeitor;
        private System.Windows.Forms.RadioButton radioIdLeitor;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioCidadeLeitor;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxPesquisar;
        private System.Windows.Forms.RadioButton radioTipoLeitor;
        private System.Windows.Forms.RadioButton radioStatusLeitor;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk_id_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_cel_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtnasc_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcad_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_leitor;
    }
}