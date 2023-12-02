namespace SistemaSaep
{
    partial class FormCadastrarAtividade
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
            this.btnCadastrarAtividade = new System.Windows.Forms.Button();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.txtCadastrarAtividade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarAtividade
            // 
            this.btnCadastrarAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAtividade.Location = new System.Drawing.Point(627, 182);
            this.btnCadastrarAtividade.Name = "btnCadastrarAtividade";
            this.btnCadastrarAtividade.Size = new System.Drawing.Size(100, 31);
            this.btnCadastrarAtividade.TabIndex = 0;
            this.btnCadastrarAtividade.Text = "Cadastrar";
            this.btnCadastrarAtividade.UseVisualStyleBackColor = true;
            this.btnCadastrarAtividade.Click += new System.EventHandler(this.btnCadastrarAtividade_Click);
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(62, 19);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(143, 24);
            this.lblUsuarioLogado.TabIndex = 1;
            this.lblUsuarioLogado.Text = "Usuario Logado";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(62, 71);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(57, 24);
            this.lblTurma.TabIndex = 2;
            this.lblTurma.Text = "turma";
            // 
            // txtCadastrarAtividade
            // 
            this.txtCadastrarAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarAtividade.Location = new System.Drawing.Point(91, 184);
            this.txtCadastrarAtividade.Name = "txtCadastrarAtividade";
            this.txtCadastrarAtividade.Size = new System.Drawing.Size(496, 29);
            this.txtCadastrarAtividade.TabIndex = 3;
            // 
            // FormCadastrarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCadastrarAtividade);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.btnCadastrarAtividade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormCadastrarAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastrarAtividade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarAtividade;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.TextBox txtCadastrarAtividade;
    }
}