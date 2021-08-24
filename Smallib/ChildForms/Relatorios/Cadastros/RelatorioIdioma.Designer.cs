
namespace Smallib.ChildForms.Cadastros.Relatorios
{
    partial class RelatorioIdioma
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
            this.dgvIdioma = new System.Windows.Forms.DataGridView();
            this.id_idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdioma)).BeginInit();
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
            this.MainTopPanel.TabIndex = 31;
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
            this.btnGerar.TabIndex = 88;
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
            this.btnVoltar.TabIndex = 87;
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
            this.label1.Size = new System.Drawing.Size(346, 37);
            this.label1.TabIndex = 86;
            this.label1.Text = "Identificação do Idioma";
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
            this.radioNomeAutor.TabIndex = 85;
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
            this.radioIdAutor.TabIndex = 84;
            this.radioIdAutor.TabStop = true;
            this.radioIdAutor.Text = "ID";
            this.radioIdAutor.UseVisualStyleBackColor = true;
            // 
            // dgvIdioma
            // 
            this.dgvIdioma.AllowUserToAddRows = false;
            this.dgvIdioma.AllowUserToDeleteRows = false;
            this.dgvIdioma.AllowUserToResizeColumns = false;
            this.dgvIdioma.AllowUserToResizeRows = false;
            this.dgvIdioma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIdioma.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIdioma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdioma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_idioma,
            this.nome_idioma});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIdioma.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIdioma.EnableHeadersVisualStyles = false;
            this.dgvIdioma.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvIdioma.Location = new System.Drawing.Point(90, 217);
            this.dgvIdioma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvIdioma.MultiSelect = false;
            this.dgvIdioma.Name = "dgvIdioma";
            this.dgvIdioma.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIdioma.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIdioma.RowHeadersVisible = false;
            this.dgvIdioma.RowHeadersWidth = 62;
            this.dgvIdioma.RowTemplate.Height = 43;
            this.dgvIdioma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIdioma.Size = new System.Drawing.Size(1324, 583);
            this.dgvIdioma.TabIndex = 89;
            // 
            // id_idioma
            // 
            this.id_idioma.DataPropertyName = "pk_id_idioma";
            this.id_idioma.FillWeight = 20.92407F;
            this.id_idioma.HeaderText = "ID";
            this.id_idioma.MinimumWidth = 8;
            this.id_idioma.Name = "id_idioma";
            this.id_idioma.ReadOnly = true;
            // 
            // nome_idioma
            // 
            this.nome_idioma.DataPropertyName = "nome_idioma";
            this.nome_idioma.FillWeight = 100.0759F;
            this.nome_idioma.HeaderText = "Nome";
            this.nome_idioma.MinimumWidth = 8;
            this.nome_idioma.Name = "nome_idioma";
            this.nome_idioma.ReadOnly = true;
            // 
            // RelatorioIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1506, 971);
            this.Controls.Add(this.dgvIdioma);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioNomeAutor);
            this.Controls.Add(this.radioIdAutor);
            this.Controls.Add(this.MainTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RelatorioIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RelatorioIdioma";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdioma)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_idioma;
    }
}