
namespace Smallib.ChildForms.Cadastros.Relatorios
{
    partial class RelatorioAutores
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
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.MainTopLabel = new System.Windows.Forms.Label();
            this.dgvAutor = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidade_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.radioNomeAutor = new System.Windows.Forms.RadioButton();
            this.radioIdAutor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.MainTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.Controls.Add(this.MainTopLabel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(867, 52);
            this.MainTopPanel.TabIndex = 26;
            // 
            // MainTopLabel
            // 
            this.MainTopLabel.AutoSize = true;
            this.MainTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F);
            this.MainTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.MainTopLabel.Location = new System.Drawing.Point(46, 12);
            this.MainTopLabel.Name = "MainTopLabel";
            this.MainTopLabel.Size = new System.Drawing.Size(267, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Relatórios de cadastros";
            // 
            // dgvAutor
            // 
            this.dgvAutor.AllowUserToAddRows = false;
            this.dgvAutor.AllowUserToDeleteRows = false;
            this.dgvAutor.AllowUserToResizeColumns = false;
            this.dgvAutor.AllowUserToResizeRows = false;
            this.dgvAutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nome_editora,
            this.nacionalidade_autor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutor.EnableHeadersVisualStyles = false;
            this.dgvAutor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvAutor.Location = new System.Drawing.Point(60, 141);
            this.dgvAutor.MultiSelect = false;
            this.dgvAutor.Name = "dgvAutor";
            this.dgvAutor.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAutor.RowHeadersVisible = false;
            this.dgvAutor.RowHeadersWidth = 62;
            this.dgvAutor.RowTemplate.Height = 43;
            this.dgvAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutor.Size = new System.Drawing.Size(883, 379);
            this.dgvAutor.TabIndex = 27;
            // 
            // id_usuario
            // 
            this.id_usuario.DataPropertyName = "pk_id_editora";
            this.id_usuario.FillWeight = 30.92407F;
            this.id_usuario.HeaderText = "ID ";
            this.id_usuario.MinimumWidth = 8;
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // nome_editora
            // 
            this.nome_editora.DataPropertyName = "nome_editora";
            this.nome_editora.FillWeight = 100.0759F;
            this.nome_editora.HeaderText = "Nome ";
            this.nome_editora.MinimumWidth = 8;
            this.nome_editora.Name = "nome_editora";
            this.nome_editora.ReadOnly = true;
            // 
            // nacionalidade_autor
            // 
            this.nacionalidade_autor.DataPropertyName = "nacionalidade_autor";
            this.nacionalidade_autor.HeaderText = "Nacionalidade";
            this.nacionalidade_autor.MinimumWidth = 8;
            this.nacionalidade_autor.Name = "nacionalidade_autor";
            this.nacionalidade_autor.ReadOnly = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnVoltar.Location = new System.Drawing.Point(215, 552);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 40);
            this.btnVoltar.TabIndex = 63;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGerar.Location = new System.Drawing.Point(60, 552);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(110, 40);
            this.btnGerar.TabIndex = 64;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            // 
            // radioNomeAutor
            // 
            this.radioNomeAutor.AutoSize = true;
            this.radioNomeAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioNomeAutor.FlatAppearance.BorderSize = 2;
            this.radioNomeAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioNomeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioNomeAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioNomeAutor.Location = new System.Drawing.Point(870, 106);
            this.radioNomeAutor.Name = "radioNomeAutor";
            this.radioNomeAutor.Size = new System.Drawing.Size(68, 24);
            this.radioNomeAutor.TabIndex = 66;
            this.radioNomeAutor.TabStop = true;
            this.radioNomeAutor.Text = "Nome";
            this.radioNomeAutor.UseVisualStyleBackColor = true;
            // 
            // radioIdAutor
            // 
            this.radioIdAutor.AutoSize = true;
            this.radioIdAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioIdAutor.FlatAppearance.BorderSize = 2;
            this.radioIdAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioIdAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioIdAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioIdAutor.Location = new System.Drawing.Point(790, 106);
            this.radioIdAutor.Name = "radioIdAutor";
            this.radioIdAutor.Size = new System.Drawing.Size(43, 24);
            this.radioIdAutor.TabIndex = 65;
            this.radioIdAutor.TabStop = true;
            this.radioIdAutor.Text = "ID";
            this.radioIdAutor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(55, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Identificação do Autor";
            // 
            // RelatorioAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(867, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioNomeAutor);
            this.Controls.Add(this.radioIdAutor);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvAutor);
            this.Controls.Add(this.MainTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatorioAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RelatorioAutores";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.DataGridView dgvAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidade_autor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.RadioButton radioNomeAutor;
        private System.Windows.Forms.RadioButton radioIdAutor;
        private System.Windows.Forms.Label label1;
    }
}