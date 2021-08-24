
namespace Smallib.ChildForms.Cadastros.Relatorios
{
    partial class RelatorioNacionalidade
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioNomeAutor = new System.Windows.Forms.RadioButton();
            this.radioIdAutor = new System.Windows.Forms.RadioButton();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.MainTopLabel = new System.Windows.Forms.Label();
            this.dgvNacionalidade = new System.Windows.Forms.DataGridView();
            this.id_nacionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_nacionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.MainTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNacionalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(82, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 37);
            this.label1.TabIndex = 91;
            this.label1.Text = "Identificação da Nacionalidade";
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
            // MainTopPanel
            // 
            this.MainTopPanel.Controls.Add(this.MainTopLabel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTopPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(1506, 80);
            this.MainTopPanel.TabIndex = 94;
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
            // dgvNacionalidade
            // 
            this.dgvNacionalidade.AllowUserToAddRows = false;
            this.dgvNacionalidade.AllowUserToDeleteRows = false;
            this.dgvNacionalidade.AllowUserToResizeColumns = false;
            this.dgvNacionalidade.AllowUserToResizeRows = false;
            this.dgvNacionalidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNacionalidade.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNacionalidade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNacionalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNacionalidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_nacionalidade,
            this.nome_nacionalidade});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNacionalidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNacionalidade.EnableHeadersVisualStyles = false;
            this.dgvNacionalidade.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvNacionalidade.Location = new System.Drawing.Point(90, 217);
            this.dgvNacionalidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNacionalidade.MultiSelect = false;
            this.dgvNacionalidade.Name = "dgvNacionalidade";
            this.dgvNacionalidade.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNacionalidade.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNacionalidade.RowHeadersVisible = false;
            this.dgvNacionalidade.RowHeadersWidth = 62;
            this.dgvNacionalidade.RowTemplate.Height = 43;
            this.dgvNacionalidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNacionalidade.Size = new System.Drawing.Size(1324, 583);
            this.dgvNacionalidade.TabIndex = 95;
            // 
            // id_nacionalidade
            // 
            this.id_nacionalidade.DataPropertyName = "pk_id_nacionalidade";
            this.id_nacionalidade.FillWeight = 30.92407F;
            this.id_nacionalidade.HeaderText = "ID";
            this.id_nacionalidade.MinimumWidth = 8;
            this.id_nacionalidade.Name = "id_nacionalidade";
            this.id_nacionalidade.ReadOnly = true;
            // 
            // nome_nacionalidade
            // 
            this.nome_nacionalidade.DataPropertyName = "nome_nacionalidade";
            this.nome_nacionalidade.FillWeight = 100.0759F;
            this.nome_nacionalidade.HeaderText = "Nome";
            this.nome_nacionalidade.MinimumWidth = 8;
            this.nome_nacionalidade.Name = "nome_nacionalidade";
            this.nome_nacionalidade.ReadOnly = true;
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
            this.btnGerar.TabIndex = 97;
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
            this.btnVoltar.TabIndex = 96;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // RelatorioNacionalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1506, 971);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvNacionalidade);
            this.Controls.Add(this.MainTopPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioNomeAutor);
            this.Controls.Add(this.radioIdAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RelatorioNacionalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RelatorioNacionalidade";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNacionalidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioNomeAutor;
        private System.Windows.Forms.RadioButton radioIdAutor;
        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.DataGridView dgvNacionalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_nacionalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_nacionalidade;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnVoltar;
    }
}