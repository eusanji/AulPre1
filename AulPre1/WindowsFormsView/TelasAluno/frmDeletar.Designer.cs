namespace WindowsFormsView.TelasAluno
{
    partial class frmDeletar
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
            this.btnDeletar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeletar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(55, 53);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 0;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o ID ->";
            // 
            // txtDeletar
            // 
            this.txtDeletar.Location = new System.Drawing.Point(88, 10);
            this.txtDeletar.Name = "txtDeletar";
            this.txtDeletar.Size = new System.Drawing.Size(100, 20);
            this.txtDeletar.TabIndex = 2;
            // 
            // frmDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 105);
            this.Controls.Add(this.txtDeletar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletar);
            this.Name = "frmDeletar";
            this.Text = "frmDeletar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeletar;
    }
}