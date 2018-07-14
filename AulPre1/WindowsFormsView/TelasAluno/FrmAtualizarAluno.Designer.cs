namespace WindowsFormsView.TelasAluno
{
    partial class frmAtualizarAluno
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
            this.txtMatriculaAtt = new System.Windows.Forms.TextBox();
            this.txtNomeAtt = new System.Windows.Forms.TextBox();
            this.btnCancelarAtt = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlunoid = new System.Windows.Forms.TextBox();
            this.btnProcuraAluno = new System.Windows.Forms.Button();
            this.btnProcuraMatricula = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMatriculaAtt
            // 
            this.txtMatriculaAtt.Location = new System.Drawing.Point(67, 108);
            this.txtMatriculaAtt.Name = "txtMatriculaAtt";
            this.txtMatriculaAtt.Size = new System.Drawing.Size(214, 20);
            this.txtMatriculaAtt.TabIndex = 5;
            // 
            // txtNomeAtt
            // 
            this.txtNomeAtt.Location = new System.Drawing.Point(67, 83);
            this.txtNomeAtt.Name = "txtNomeAtt";
            this.txtNomeAtt.Size = new System.Drawing.Size(214, 20);
            this.txtNomeAtt.TabIndex = 4;
            // 
            // btnCancelarAtt
            // 
            this.btnCancelarAtt.Location = new System.Drawing.Point(168, 145);
            this.btnCancelarAtt.Name = "btnCancelarAtt";
            this.btnCancelarAtt.Size = new System.Drawing.Size(119, 23);
            this.btnCancelarAtt.TabIndex = 7;
            this.btnCancelarAtt.Text = "Cancelar";
            this.btnCancelarAtt.UseVisualStyleBackColor = true;
            this.btnCancelarAtt.Click += new System.EventHandler(this.btnCancelarAtt_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(27, 145);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(116, 23);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Digite o AlunoID ->";
            // 
            // txtAlunoid
            // 
            this.txtAlunoid.Location = new System.Drawing.Point(100, 10);
            this.txtAlunoid.Name = "txtAlunoid";
            this.txtAlunoid.Size = new System.Drawing.Size(59, 20);
            this.txtAlunoid.TabIndex = 11;
            // 
            // btnProcuraAluno
            // 
            this.btnProcuraAluno.Location = new System.Drawing.Point(180, 3);
            this.btnProcuraAluno.Name = "btnProcuraAluno";
            this.btnProcuraAluno.Size = new System.Drawing.Size(101, 23);
            this.btnProcuraAluno.TabIndex = 12;
            this.btnProcuraAluno.Text = "Procurar por ID";
            this.btnProcuraAluno.UseVisualStyleBackColor = true;
            this.btnProcuraAluno.Click += new System.EventHandler(this.btnProcuraAluno_Click);
            // 
            // btnProcuraMatricula
            // 
            this.btnProcuraMatricula.Location = new System.Drawing.Point(168, 31);
            this.btnProcuraMatricula.Name = "btnProcuraMatricula";
            this.btnProcuraMatricula.Size = new System.Drawing.Size(119, 23);
            this.btnProcuraMatricula.TabIndex = 15;
            this.btnProcuraMatricula.Text = "Procurar por Matricula";
            this.btnProcuraMatricula.UseVisualStyleBackColor = true;
            this.btnProcuraMatricula.Click += new System.EventHandler(this.btnProcuraMatricula_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(100, 33);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(59, 20);
            this.txtMatricula.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Digite a Matricula ->";
            // 
            // frmAtualizarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 189);
            this.Controls.Add(this.btnProcuraMatricula);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProcuraAluno);
            this.Controls.Add(this.txtAlunoid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarAtt);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtMatriculaAtt);
            this.Controls.Add(this.txtNomeAtt);
            this.Name = "frmAtualizarAluno";
            this.Text = "FrmAtualizarAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatriculaAtt;
        private System.Windows.Forms.TextBox txtNomeAtt;
        private System.Windows.Forms.Button btnCancelarAtt;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlunoid;
        private System.Windows.Forms.Button btnProcuraAluno;
        private System.Windows.Forms.Button btnProcuraMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
    }
}