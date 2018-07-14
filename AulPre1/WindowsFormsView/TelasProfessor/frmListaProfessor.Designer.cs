namespace WindowsFormsView.TelasProfessor
{
    partial class frmListaProfessor
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
            this.dgvProfessores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfessores
            // 
            this.dgvProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessores.Location = new System.Drawing.Point(38, 27);
            this.dgvProfessores.Name = "dgvProfessores";
            this.dgvProfessores.Size = new System.Drawing.Size(433, 380);
            this.dgvProfessores.TabIndex = 1;
            // 
            // frmListaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 444);
            this.Controls.Add(this.dgvProfessores);
            this.Name = "frmListaProfessor";
            this.Text = "frmListaProfessor";
            this.Load += new System.EventHandler(this.frmListaProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfessores;
    }
}