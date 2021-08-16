namespace Smallib.ChildForms.Cadastros.Editora
{
    partial class EditoraMenu
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
            this.MainTopLabel = new System.Windows.Forms.Label();
            this.labelDtgv = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.radioEditora = new System.Windows.Forms.RadioButton();
            this.radioIdEditora = new System.Windows.Forms.RadioButton();
            this.txtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.panel5.SuspendLayout();
            this.MainTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTopLabel
            // 
            this.MainTopLabel.AutoSize = true;
            this.MainTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.MainTopLabel.Location = new System.Drawing.Point(46, 12);
            this.MainTopLabel.Name = "MainTopLabel";
            this.MainTopLabel.Size = new System.Drawing.Size(227, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Cadastro de Editora";
            // 
            // labelDtgv
            // 
            this.labelDtgv.AutoSize = true;
            this.labelDtgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDtgv.Location = new System.Drawing.Point(355, 355);
            this.labelDtgv.Name = "labelDtgv";
            this.labelDtgv.Size = new System.Drawing.Size(0, 25);
            this.labelDtgv.TabIndex = 28;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToResizeColumns = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.cidade_editora,
            this.email_editora,
            this.nome_editora,
            this.telefone_editora,
            this.site_editora});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuario.EnableHeadersVisualStyles = false;
            this.dgvUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvUsuario.Location = new System.Drawing.Point(60, 177);
            this.dgvUsuario.MultiSelect = false;
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuario.RowHeadersVisible = false;
            this.dgvUsuario.RowTemplate.Height = 43;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(883, 353);
            this.dgvUsuario.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel5.Controls.Add(this.labelDtgv);
            this.panel5.Controls.Add(this.dgvUsuario);
            this.panel5.Controls.Add(this.btnConsultar);
            this.panel5.Controls.Add(this.btnExcluir);
            this.panel5.Controls.Add(this.btnEditar);
            this.panel5.Controls.Add(this.btnNovo);
            this.panel5.Controls.Add(this.btnAtualizar);
            this.panel5.Controls.Add(this.btnPesquisar);
            this.panel5.Controls.Add(this.radioEditora);
            this.panel5.Controls.Add(this.radioIdEditora);
            this.panel5.Controls.Add(this.txtBoxPesquisar);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.MainTopPanel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1004, 631);
            this.panel5.TabIndex = 18;
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
            // 
            // radioEditora
            // 
            this.radioEditora.AutoSize = true;
            this.radioEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioEditora.FlatAppearance.BorderSize = 2;
            this.radioEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioEditora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioEditora.Location = new System.Drawing.Point(182, 131);
            this.radioEditora.Name = "radioEditora";
            this.radioEditora.Size = new System.Drawing.Size(145, 24);
            this.radioEditora.TabIndex = 19;
            this.radioEditora.TabStop = true;
            this.radioEditora.Text = "Nome da Editora";
            this.radioEditora.UseVisualStyleBackColor = true;
            // 
            // radioIdEditora
            // 
            this.radioIdEditora.AutoSize = true;
            this.radioIdEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioIdEditora.FlatAppearance.BorderSize = 2;
            this.radioIdEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioIdEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioIdEditora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioIdEditora.Location = new System.Drawing.Point(60, 131);
            this.radioIdEditora.Name = "radioIdEditora";
            this.radioIdEditora.Size = new System.Drawing.Size(98, 24);
            this.radioIdEditora.TabIndex = 18;
            this.radioIdEditora.TabStop = true;
            this.radioIdEditora.Text = "ID Editora";
            this.radioIdEditora.UseVisualStyleBackColor = true;
            // 
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPesquisar.Enabled = false;
            this.txtBoxPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F);
            this.txtBoxPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxPesquisar.Location = new System.Drawing.Point(60, 90);
            this.txtBoxPesquisar.Multiline = true;
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(649, 35);
            this.txtBoxPesquisar.TabIndex = 17;
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
            // id_usuario
            // 
            this.id_usuario.DataPropertyName = "pk_id_editora";
            this.id_usuario.FillWeight = 99.92407F;
            this.id_usuario.HeaderText = "ID ";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // cidade_editora
            // 
            this.cidade_editora.DataPropertyName = "cidade_editora";
            this.cidade_editora.HeaderText = "Cidade ";
            this.cidade_editora.Name = "cidade_editora";
            this.cidade_editora.ReadOnly = true;
            // 
            // email_editora
            // 
            this.email_editora.HeaderText = "Email";
            this.email_editora.Name = "email_editora";
            this.email_editora.ReadOnly = true;
            // 
            // nome_editora
            // 
            this.nome_editora.DataPropertyName = "nome_editora";
            this.nome_editora.FillWeight = 100.0759F;
            this.nome_editora.HeaderText = "Nome ";
            this.nome_editora.Name = "nome_editora";
            this.nome_editora.ReadOnly = true;
            // 
            // telefone_editora
            // 
            this.telefone_editora.HeaderText = "Telefone ";
            this.telefone_editora.Name = "telefone_editora";
            this.telefone_editora.ReadOnly = true;
            // 
            // site_editora
            // 
            this.site_editora.HeaderText = "Site ";
            this.site_editora.Name = "site_editora";
            this.site_editora.ReadOnly = true;
            // 
            // EditoraMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditoraMenu";
            this.Text = "EditoraMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.Label labelDtgv;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton radioEditora;
        private System.Windows.Forms.RadioButton radioIdEditora;
        private System.Windows.Forms.TextBox txtBoxPesquisar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn site_editora;
    }
}