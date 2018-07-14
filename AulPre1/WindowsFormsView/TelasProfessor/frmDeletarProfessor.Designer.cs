namespace WindowsFormsView.TelasProfessor
{
    partial class frmDeletarProfessor
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
            this.txtDeletarProf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletarProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeletarProf
            // 
            this.txtDeletarProf.Location = new System.Drawing.Point(147, 38);
            this.txtDeletarProf.Name = "txtDeletarProf";
            this.txtDeletarProf.Size = new System.Drawing.Size(100, 20);
            this.txtDeletarProf.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o ID \" Professor\" ->";
            // 
            // btnDeletarProf
            // 
            this.btnDeletarProf.Location = new System.Drawing.Point(147, 78);
            this.btnDeletarProf.Name = "btnDeletarProf";
            this.btnDeletarProf.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarProf.TabIndex = 3;
            this.btnDeletarProf.Text = "Deletar";
            this.btnDeletarProf.UseVisualStyleBackColor = true;
            this.btnDeletarProf.Click += new System.EventHandler(this.btnDeletarProf_Click);
            // 
            // frmDeletarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 143);
            this.Controls.Add(this.txtDeletarProf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletarProf);
            this.Name = "frmDeletarProfessor";
            this.Text = "frmDeletarProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeletarProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeletarProf;
    }
}