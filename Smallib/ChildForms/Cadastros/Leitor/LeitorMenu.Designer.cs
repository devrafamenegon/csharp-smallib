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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDgv = new System.Windows.Forms.Label();
            this.dgvLeitor = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.metroTxtBoxPesquisar = new MetroFramework.Controls.MetroTextBox();
            this.radioTipoLeitor = new System.Windows.Forms.RadioButton();
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
            this.id_usuario,
            this.nome_editora,
            this.telefone_leitor,
            this.tipo_leitor,
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
            this.dgvLeitor.Location = new System.Drawing.Point(60, 177);
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
            this.dgvLeitor.Size = new System.Drawing.Size(883, 353);
            this.dgvLeitor.TabIndex = 26;
            // 
            // id_usuario
            // 
            this.id_usuario.DataPropertyName = "pk_id_editora";
            this.id_usuario.FillWeight = 30.92407F;
            this.id_usuario.HeaderText = "ID ";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // nome_editora
            // 
            this.nome_editora.DataPropertyName = "nome_editora";
            this.nome_editora.FillWeight = 100.0759F;
            this.nome_editora.HeaderText = "Nome ";
            this.nome_editora.Name = "nome_editora";
            this.nome_editora.ReadOnly = true;
            // 
            // telefone_leitor
            // 
            this.telefone_leitor.HeaderText = "Telefone";
            this.telefone_leitor.Name = "telefone_leitor";
            this.telefone_leitor.ReadOnly = true;
            // 
            // tipo_leitor
            // 
            this.tipo_leitor.HeaderText = "Tipo";
            this.tipo_leitor.Name = "tipo_leitor";
            this.tipo_leitor.ReadOnly = true;
            // 
            // status_leitor
            // 
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
            this.radioNomeLeitor.TabStop = true;
            this.radioNomeLeitor.Text = "Nome";
            this.radioNomeLeitor.UseVisualStyleBackColor = true;
            // 
            // radioIdLeitor
            // 
            this.radioIdLeitor.AutoSize = true;
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
            this.panel5.Controls.Add(this.metroTxtBoxPesquisar);
            this.panel5.Controls.Add(this.radioTipoLeitor);
            this.panel5.Controls.Add(this.labelDgv);
            this.panel5.Controls.Add(this.dgvLeitor);
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
            this.metroTxtBoxPesquisar.Enabled = false;
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
            // radioTipoLeitor
            // 
            this.radioTipoLeitor.AutoSize = true;
            this.radioTipoLeitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioTipoLeitor.FlatAppearance.BorderSize = 2;
            this.radioTipoLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTipoLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.radioTipoLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.radioTipoLeitor.Location = new System.Drawing.Point(216, 131);
            this.radioTipoLeitor.Name = "radioTipoLeitor";
            this.radioTipoLeitor.Size = new System.Drawing.Size(56, 24);
            this.radioTipoLeitor.TabIndex = 29;
            this.radioTipoLeitor.TabStop = true;
            this.radioTipoLeitor.Text = "Tipo";
            this.radioTipoLeitor.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.RadioButton radioTipoLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_leitor;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxPesquisar;
    }
}