namespace WindowsFormsView.TelasProfessor
{
    partial class frmCadastroProfessor
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
            this.btnCancelarProfessor = new System.Windows.Forms.Button();
            this.btnSalvarProfessor = new System.Windows.Forms.Button();
            this.txtMatriculaProfessor = new System.Windows.Forms.TextBox();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarProfessor
            // 
            this.btnCancelarProfessor.Location = new System.Drawing.Point(153, 90);
            this.btnCancelarProfessor.Name = "btnCancelarProfessor";
            this.btnCancelarProfessor.Size = new System.Drawing.Size(119, 23);
            this.btnCancelarProfessor.TabIndex = 11;
            this.btnCancelarProfessor.Text = "Cancelar";
            this.btnCancelarProfessor.UseVisualStyleBackColor = true;
            this.btnCancelarProfessor.Click += new System.EventHandler(this.btnCancelarProfessor_Click);
            // 
            // btnSalvarProfessor
            // 
            this.btnSalvarProfessor.Location = new System.Drawing.Point(12, 90);
            this.btnSalvarProfessor.Name = "btnSalvarProfessor";
            this.btnSalvarProfessor.Size = new System.Drawing.Size(116, 23);
            this.btnSalvarProfessor.TabIndex = 10;
            this.btnSalvarProfessor.Text = "Salvar";
            this.btnSalvarProfessor.UseVisualStyleBackColor = true;
            this.btnSalvarProfessor.Click += new System.EventHandler(this.btnSalvarProfessor_Click);
            // 
            // txtMatriculaProfessor
            // 
            this.txtMatriculaProfessor.Location = new System.Drawing.Point(58, 37);
            this.txtMatriculaProfessor.Name = "txtMatriculaProfessor";
            this.txtMatriculaProfessor.Size = new System.Drawing.Size(214, 20);
            this.txtMatriculaProfessor.TabIndex = 9;
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Location = new System.Drawing.Point(58, 12);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(214, 20);
            this.txtNomeProfessor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // frmCadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancelarProfessor);
            this.Controls.Add(this.btnSalvarProfessor);
            this.Controls.Add(this.txtMatriculaProfessor);
            this.Controls.Add(this.txtNomeProfessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroProfessor";
            this.Text = "frmCadastroProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarProfessor;
        private System.Windows.Forms.Button btnSalvarProfessor;
        private System.Windows.Forms.TextBox txtMatriculaProfessor;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}