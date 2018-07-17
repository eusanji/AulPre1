namespace WindowsFormsView.TelasProfessor
{
    partial class frmAtualizarProfessor
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
            this.btnProcuraMatriculaP = new System.Windows.Forms.Button();
            this.txtMatriculaProf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcuraProfessor = new System.Windows.Forms.Button();
            this.txtProfessorid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarAttProfessor = new System.Windows.Forms.Button();
            this.btnAtualizarProfessor = new System.Windows.Forms.Button();
            this.txtMatriculaAttProf = new System.Windows.Forms.TextBox();
            this.txtNomeAttProf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcuraMatriculaP
            // 
            this.btnProcuraMatriculaP.Location = new System.Drawing.Point(183, 46);
            this.btnProcuraMatriculaP.Name = "btnProcuraMatriculaP";
            this.btnProcuraMatriculaP.Size = new System.Drawing.Size(119, 23);
            this.btnProcuraMatriculaP.TabIndex = 27;
            this.btnProcuraMatriculaP.Text = "Procurar por Matricula";
            this.btnProcuraMatriculaP.UseVisualStyleBackColor = true;
            // 
            // txtMatriculaProf
            // 
            this.txtMatriculaProf.Location = new System.Drawing.Point(115, 48);
            this.txtMatriculaProf.Name = "txtMatriculaProf";
            this.txtMatriculaProf.Size = new System.Drawing.Size(59, 20);
            this.txtMatriculaProf.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Digite a Matricula ->";
            // 
            // btnProcuraProfessor
            // 
            this.btnProcuraProfessor.Location = new System.Drawing.Point(195, 18);
            this.btnProcuraProfessor.Name = "btnProcuraProfessor";
            this.btnProcuraProfessor.Size = new System.Drawing.Size(101, 23);
            this.btnProcuraProfessor.TabIndex = 24;
            this.btnProcuraProfessor.Text = "Procurar por ID";
            this.btnProcuraProfessor.UseVisualStyleBackColor = true;
            this.btnProcuraProfessor.Click += new System.EventHandler(this.btnProcuraProfessor_Click);
            // 
            // txtProfessorid
            // 
            this.txtProfessorid.Location = new System.Drawing.Point(115, 25);
            this.txtProfessorid.Name = "txtProfessorid";
            this.txtProfessorid.Size = new System.Drawing.Size(59, 20);
            this.txtProfessorid.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Digite o ProfessorID ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome:";
            // 
            // btnCancelarAttProfessor
            // 
            this.btnCancelarAttProfessor.Location = new System.Drawing.Point(183, 160);
            this.btnCancelarAttProfessor.Name = "btnCancelarAttProfessor";
            this.btnCancelarAttProfessor.Size = new System.Drawing.Size(119, 23);
            this.btnCancelarAttProfessor.TabIndex = 19;
            this.btnCancelarAttProfessor.Text = "Cancelar";
            this.btnCancelarAttProfessor.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarProfessor
            // 
            this.btnAtualizarProfessor.Location = new System.Drawing.Point(42, 160);
            this.btnAtualizarProfessor.Name = "btnAtualizarProfessor";
            this.btnAtualizarProfessor.Size = new System.Drawing.Size(116, 23);
            this.btnAtualizarProfessor.TabIndex = 18;
            this.btnAtualizarProfessor.Text = "Atualizar";
            this.btnAtualizarProfessor.UseVisualStyleBackColor = true;
            this.btnAtualizarProfessor.Click += new System.EventHandler(this.btnAtualizarProfessor_Click);
            // 
            // txtMatriculaAttProf
            // 
            this.txtMatriculaAttProf.Location = new System.Drawing.Point(82, 123);
            this.txtMatriculaAttProf.Name = "txtMatriculaAttProf";
            this.txtMatriculaAttProf.Size = new System.Drawing.Size(214, 20);
            this.txtMatriculaAttProf.TabIndex = 17;
            // 
            // txtNomeAttProf
            // 
            this.txtNomeAttProf.Location = new System.Drawing.Point(82, 98);
            this.txtNomeAttProf.Name = "txtNomeAttProf";
            this.txtNomeAttProf.Size = new System.Drawing.Size(214, 20);
            this.txtNomeAttProf.TabIndex = 16;
            // 
            // frmAtualizarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 190);
            this.Controls.Add(this.btnProcuraMatriculaP);
            this.Controls.Add(this.txtMatriculaProf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProcuraProfessor);
            this.Controls.Add(this.txtProfessorid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarAttProfessor);
            this.Controls.Add(this.btnAtualizarProfessor);
            this.Controls.Add(this.txtMatriculaAttProf);
            this.Controls.Add(this.txtNomeAttProf);
            this.Name = "frmAtualizarProfessor";
            this.Text = "frmAtualizarProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcuraMatriculaP;
        private System.Windows.Forms.TextBox txtMatriculaProf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcuraProfessor;
        private System.Windows.Forms.TextBox txtProfessorid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarAttProfessor;
        private System.Windows.Forms.Button btnAtualizarProfessor;
        private System.Windows.Forms.TextBox txtMatriculaAttProf;
        private System.Windows.Forms.TextBox txtNomeAttProf;
    }
}