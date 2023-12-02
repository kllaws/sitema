namespace SistemaSaep
{
    partial class FormVisualizarAtividade
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
            this.components = new System.ComponentModel.Container();
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atividadeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrarAtividade = new System.Windows.Forms.Button();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // atividadeBindingSource
            // 
            this.atividadeBindingSource.DataSource = typeof(Models.Atividade);
            // 
            // atividadeDataGridView
            // 
            this.atividadeDataGridView.AllowUserToAddRows = false;
            this.atividadeDataGridView.AllowUserToDeleteRows = false;
            this.atividadeDataGridView.AllowUserToOrderColumns = true;
            this.atividadeDataGridView.AutoGenerateColumns = false;
            this.atividadeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atividadeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.atividadeDataGridView.DataSource = this.atividadeBindingSource;
            this.atividadeDataGridView.Location = new System.Drawing.Point(33, 164);
            this.atividadeDataGridView.Name = "atividadeDataGridView";
            this.atividadeDataGridView.ReadOnly = true;
            this.atividadeDataGridView.Size = new System.Drawing.Size(745, 239);
            this.atividadeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(699, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(79, 27);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrarAtividade
            // 
            this.btnCadastrarAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAtividade.Location = new System.Drawing.Point(585, 106);
            this.btnCadastrarAtividade.Name = "btnCadastrarAtividade";
            this.btnCadastrarAtividade.Size = new System.Drawing.Size(193, 30);
            this.btnCadastrarAtividade.TabIndex = 3;
            this.btnCadastrarAtividade.Text = "Cadastrar Atividade";
            this.btnCadastrarAtividade.UseVisualStyleBackColor = true;
            this.btnCadastrarAtividade.Click += new System.EventHandler(this.btnCadastrarAtividade_Click);
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(47, 29);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(116, 20);
            this.lblUsuarioLogado.TabIndex = 4;
            this.lblUsuarioLogado.Text = "Usuario logado";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(47, 116);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(66, 20);
            this.lblTurma.TabIndex = 5;
            this.lblTurma.Text = "TURMA";
            // 
            // FormVisualizarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.btnCadastrarAtividade);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.atividadeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormVisualizarAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormVisualizarAtividade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private System.Windows.Forms.DataGridView atividadeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrarAtividade;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label lblTurma;
    }
}