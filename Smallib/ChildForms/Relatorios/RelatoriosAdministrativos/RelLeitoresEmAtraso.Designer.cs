
namespace Smallib.ChildForms.Relatorios.RelatoriosAdministrativos
{
    partial class RelLeitoresEmAtraso
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.MainTopLabel = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.metroTxtBoxPesquisar = new MetroFramework.Controls.MetroTextBox();
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.radioCursoLeitor = new System.Windows.Forms.RadioButton();
            this.radioStatusLeitor = new System.Windows.Forms.RadioButton();
            this.radioTipoLeitor = new System.Windows.Forms.RadioButton();
            this.radioCidadeLeitor = new System.Windows.Forms.RadioButton();
            this.radioNomeLeitor = new System.Windows.Forms.RadioButton();
            this.radioIdLeitor = new System.Windows.Forms.RadioButton();
            this.labelDgv = new System.Windows.Forms.Label();
            this.MainTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnVoltar.Location = new System.Drawing.Point(51, 538);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 40);
            this.btnVoltar.TabIndex = 65;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 52);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1004, 2);
            this.panel7.TabIndex = 67;
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.Controls.Add(this.MainTopLabel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(1004, 52);
            this.MainTopPanel.TabIndex = 66;
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
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(233)))));
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnRelatorio.Location = new System.Drawing.Point(840, 538);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(110, 40);
            this.btnRelatorio.TabIndex = 74;
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
            this.metroTxtBoxPesquisar.CustomButton.Location = new System.Drawing.Point(751, 1);
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
            this.metroTxtBoxPesquisar.Location = new System.Drawing.Point(53, 80);
            this.metroTxtBoxPesquisar.MaxLength = 32767;
            this.metroTxtBoxPesquisar.Name = "metroTxtBoxPesquisar";
            this.metroTxtBoxPesquisar.PasswordChar = '\0';
            this.metroTxtBoxPesquisar.PromptText = "Pesquisar";
            this.metroTxtBoxPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtBoxPesquisar.SelectedText = "";
            this.metroTxtBoxPesquisar.SelectionLength = 0;
            this.metroTxtBoxPesquisar.SelectionStart = 0;
            this.metroTxtBoxPesquisar.ShortcutsEnabled = true;
            this.metroTxtBoxPesquisar.Size = new System.Drawing.Size(785, 35);
            this.metroTxtBoxPesquisar.TabIndex = 73;
            this.metroTxtBoxPesquisar.UseSelectable = true;
            this.metroTxtBoxPesquisar.WaterMark = "Pesquisar";
            this.metroTxtBoxPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.metroTxtBoxPesquisar.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dgvLeitor
            // 
            this.dgvLeitor.AllowUserToAddRows = false;
            this.dgvLeitor.AllowUserToDeleteRows = false;
            this.dgvLeitor.AllowUserToResizeColumns = false;
            this.dgvLeitor.AllowUserToResizeRows = false;
            this.dgvLeitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeitor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeitor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeitor.EnableHeadersVisualStyles = false;
            this.dgvLeitor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvLeitor.Location = new System.Drawing.Point(53, 167);
            this.dgvLeitor.MultiSelect = false;
            this.dgvLeitor.Name = "dgvLeitor";
            this.dgvLeitor.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeitor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLeitor.RowHeadersVisible = false;
            this.dgvLeitor.RowTemplate.Height = 43;
            this.dgvLeitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeitor.Size = new System.Drawing.Size(897, 353);
            this.dgvLeitor.TabIndex = 72;
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
            this.nome_curso.FillWeight = 50F;
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
            // status_leitor
            // 
            this.status_leitor.DataPropertyName = "status_leitor";
            this.status_leitor.FillWeight = 40F;
            this.status_leitor.HeaderText = "Status";
            this.status_leitor.Name = "status_leitor";
            this.status_leitor.ReadOnly = true;
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
            this.btnAtualizar.Location = new System.Drawing.Point(915, 82);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(30, 30);
            this.btnAtualizar.TabIndex = 71;
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
            this.btnPesquisar.Location = new System.Drawing.Point(857, 82);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisar.TabIndex = 70;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // radioCursoLeitor
            // 
            this.radioCursoLeitor.AutoSize = true;
            this.radioCursoLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioCursoLeitor.FlatAppearance.BorderSize = 2;
            this.radioCursoLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioCursoLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioCursoLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioCursoLeitor.Location = new System.Drawing.Point(479, 121);
            this.radioCursoLeitor.Name = "radioCursoLeitor";
            this.radioCursoLeitor.Size = new System.Drawing.Size(68, 24);
            this.radioCursoLeitor.TabIndex = 81;
            this.radioCursoLeitor.TabStop = true;
            this.radioCursoLeitor.Text = "Curso";
            this.radioCursoLeitor.UseVisualStyleBackColor = true;
            this.radioCursoLeitor.CheckedChanged += new System.EventHandler(this.radioCursoLeitor_CheckedChanged);
            // 
            // radioStatusLeitor
            // 
            this.radioStatusLeitor.AutoSize = true;
            this.radioStatusLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioStatusLeitor.FlatAppearance.BorderSize = 2;
            this.radioStatusLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioStatusLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioStatusLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioStatusLeitor.Location = new System.Drawing.Point(387, 121);
            this.radioStatusLeitor.Name = "radioStatusLeitor";
            this.radioStatusLeitor.Size = new System.Drawing.Size(73, 24);
            this.radioStatusLeitor.TabIndex = 86;
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
            this.radioTipoLeitor.Location = new System.Drawing.Point(307, 121);
            this.radioTipoLeitor.Name = "radioTipoLeitor";
            this.radioTipoLeitor.Size = new System.Drawing.Size(56, 24);
            this.radioTipoLeitor.TabIndex = 85;
            this.radioTipoLeitor.Text = "Tipo";
            this.radioTipoLeitor.UseVisualStyleBackColor = true;
            this.radioTipoLeitor.CheckedChanged += new System.EventHandler(this.radioTipoLeitor_CheckedChanged);
            // 
            // radioCidadeLeitor
            // 
            this.radioCidadeLeitor.AutoSize = true;
            this.radioCidadeLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioCidadeLeitor.FlatAppearance.BorderSize = 2;
            this.radioCidadeLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioCidadeLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioCidadeLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioCidadeLeitor.Location = new System.Drawing.Point(209, 121);
            this.radioCidadeLeitor.Name = "radioCidadeLeitor";
            this.radioCidadeLeitor.Size = new System.Drawing.Size(76, 24);
            this.radioCidadeLeitor.TabIndex = 84;
            this.radioCidadeLeitor.Text = "Cidade";
            this.radioCidadeLeitor.UseVisualStyleBackColor = true;
            this.radioCidadeLeitor.CheckedChanged += new System.EventHandler(this.radioCidadeLeitor_CheckedChanged);
            // 
            // radioNomeLeitor
            // 
            this.radioNomeLeitor.AutoSize = true;
            this.radioNomeLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioNomeLeitor.FlatAppearance.BorderSize = 2;
            this.radioNomeLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioNomeLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioNomeLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioNomeLeitor.Location = new System.Drawing.Point(120, 121);
            this.radioNomeLeitor.Name = "radioNomeLeitor";
            this.radioNomeLeitor.Size = new System.Drawing.Size(68, 24);
            this.radioNomeLeitor.TabIndex = 83;
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
            this.radioIdLeitor.Location = new System.Drawing.Point(53, 121);
            this.radioIdLeitor.Name = "radioIdLeitor";
            this.radioIdLeitor.Size = new System.Drawing.Size(43, 24);
            this.radioIdLeitor.TabIndex = 82;
            this.radioIdLeitor.TabStop = true;
            this.radioIdLeitor.Text = "ID";
            this.radioIdLeitor.UseVisualStyleBackColor = true;
            this.radioIdLeitor.CheckedChanged += new System.EventHandler(this.radioIdLeitor_CheckedChanged);
            // 
            // labelDgv
            // 
            this.labelDgv.AutoSize = true;
            this.labelDgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDgv.Location = new System.Drawing.Point(335, 351);
            this.labelDgv.Name = "labelDgv";
            this.labelDgv.Size = new System.Drawing.Size(0, 25);
            this.labelDgv.TabIndex = 87;
            // 
            // RelLeitoresEmAtraso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.labelDgv);
            this.Controls.Add(this.radioStatusLeitor);
            this.Controls.Add(this.radioTipoLeitor);
            this.Controls.Add(this.radioCidadeLeitor);
            this.Controls.Add(this.radioNomeLeitor);
            this.Controls.Add(this.radioIdLeitor);
            this.Controls.Add(this.radioCursoLeitor);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.metroTxtBoxPesquisar);
            this.Controls.Add(this.dgvLeitor);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.MainTopPanel);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelLeitoresEmAtraso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RelLeitoresEmAtraso";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.Button btnRelatorio;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxPesquisar;
        private System.Windows.Forms.DataGridView dgvLeitor;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton radioCursoLeitor;
        private System.Windows.Forms.RadioButton radioStatusLeitor;
        private System.Windows.Forms.RadioButton radioTipoLeitor;
        private System.Windows.Forms.RadioButton radioCidadeLeitor;
        private System.Windows.Forms.RadioButton radioNomeLeitor;
        private System.Windows.Forms.RadioButton radioIdLeitor;
        private System.Windows.Forms.Label labelDgv;
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