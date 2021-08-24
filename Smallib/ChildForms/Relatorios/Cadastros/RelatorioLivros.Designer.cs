
namespace Smallib.ChildForms.Cadastros.Relatorios
{
    partial class RelatorioLivros
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioNomeAutor = new System.Windows.Forms.RadioButton();
            this.radioIdAutor = new System.Windows.Forms.RadioButton();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editora_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idioma_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.Controls.Add(this.MainTopLabel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTopPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(1506, 80);
            this.MainTopPanel.TabIndex = 32;
            // 
            // MainTopLabel
            // 
            this.MainTopLabel.AutoSize = true;
            this.MainTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F);
            this.MainTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.MainTopLabel.Location = new System.Drawing.Point(69, 18);
            this.MainTopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainTopLabel.Name = "MainTopLabel";
            this.MainTopLabel.Size = new System.Drawing.Size(374, 39);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Relatórios de cadastros";
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGerar.Location = new System.Drawing.Point(90, 849);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(165, 62);
            this.btnGerar.TabIndex = 93;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnVoltar.Location = new System.Drawing.Point(322, 849);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(165, 62);
            this.btnVoltar.TabIndex = 92;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(82, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 37);
            this.label1.TabIndex = 91;
            this.label1.Text = "Identificação do Livro";
            // 
            // radioNomeAutor
            // 
            this.radioNomeAutor.AutoSize = true;
            this.radioNomeAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioNomeAutor.FlatAppearance.BorderSize = 2;
            this.radioNomeAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioNomeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioNomeAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioNomeAutor.Location = new System.Drawing.Point(1305, 163);
            this.radioNomeAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioNomeAutor.Name = "radioNomeAutor";
            this.radioNomeAutor.Size = new System.Drawing.Size(102, 33);
            this.radioNomeAutor.TabIndex = 90;
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
            this.radioIdAutor.Location = new System.Drawing.Point(1185, 163);
            this.radioIdAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioIdAutor.Name = "radioIdAutor";
            this.radioIdAutor.Size = new System.Drawing.Size(59, 33);
            this.radioIdAutor.TabIndex = 89;
            this.radioIdAutor.TabStop = true;
            this.radioIdAutor.Text = "ID";
            this.radioIdAutor.UseVisualStyleBackColor = true;
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            this.dgvLivros.AllowUserToResizeColumns = false;
            this.dgvLivros.AllowUserToResizeRows = false;
            this.dgvLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.titulo_livro,
            this.editora_livro,
            this.genero_livro,
            this.autor_livro,
            this.idioma_livro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLivros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivros.EnableHeadersVisualStyles = false;
            this.dgvLivros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvLivros.Location = new System.Drawing.Point(90, 217);
            this.dgvLivros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLivros.MultiSelect = false;
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLivros.RowHeadersVisible = false;
            this.dgvLivros.RowHeadersWidth = 62;
            this.dgvLivros.RowTemplate.Height = 43;
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(1324, 583);
            this.dgvLivros.TabIndex = 94;
            // 
            // id_usuario
            // 
            this.id_usuario.DataPropertyName = "pk_id_editora";
            this.id_usuario.FillWeight = 40.92407F;
            this.id_usuario.HeaderText = "ID ";
            this.id_usuario.MinimumWidth = 8;
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // titulo_livro
            // 
            this.titulo_livro.DataPropertyName = "titulo_livro";
            this.titulo_livro.FillWeight = 100.0759F;
            this.titulo_livro.HeaderText = "Titulo ";
            this.titulo_livro.MinimumWidth = 8;
            this.titulo_livro.Name = "titulo_livro";
            this.titulo_livro.ReadOnly = true;
            // 
            // editora_livro
            // 
            this.editora_livro.DataPropertyName = "cidade_editora";
            this.editora_livro.HeaderText = "Editora";
            this.editora_livro.MinimumWidth = 8;
            this.editora_livro.Name = "editora_livro";
            this.editora_livro.ReadOnly = true;
            // 
            // genero_livro
            // 
            this.genero_livro.HeaderText = "Gênero";
            this.genero_livro.MinimumWidth = 8;
            this.genero_livro.Name = "genero_livro";
            this.genero_livro.ReadOnly = true;
            // 
            // autor_livro
            // 
            this.autor_livro.HeaderText = "Autor";
            this.autor_livro.MinimumWidth = 8;
            this.autor_livro.Name = "autor_livro";
            this.autor_livro.ReadOnly = true;
            // 
            // idioma_livro
            // 
            this.idioma_livro.HeaderText = "Idioma";
            this.idioma_livro.MinimumWidth = 8;
            this.idioma_livro.Name = "idioma_livro";
            this.idioma_livro.ReadOnly = true;
            // 
            // RelatorioLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1506, 971);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioNomeAutor);
            this.Controls.Add(this.radioIdAutor);
            this.Controls.Add(this.MainTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RelatorioLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RelatorioLivros";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioNomeAutor;
        private System.Windows.Forms.RadioButton radioIdAutor;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn editora_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idioma_livro;
    }
}