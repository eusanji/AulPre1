namespace WindowsFormsView.TelasDisciplina
{
    partial class frmCadastroDisciplina
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
            this.btnCancelarDisciplina = new System.Windows.Forms.Button();
            this.btnSalvarDisciplina = new System.Windows.Forms.Button();
            this.txtCargaHorDisciplina = new System.Windows.Forms.TextBox();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarDisciplina
            // 
            this.btnCancelarDisciplina.Location = new System.Drawing.Point(153, 92);
            this.btnCancelarDisciplina.Name = "btnCancelarDisciplina";
            this.btnCancelarDisciplina.Size = new System.Drawing.Size(119, 23);
            this.btnCancelarDisciplina.TabIndex = 17;
            this.btnCancelarDisciplina.Text = "Cancelar";
            this.btnCancelarDisciplina.UseVisualStyleBackColor = true;
            this.btnCancelarDisciplina.Click += new System.EventHandler(this.btnCancelarDisciplina_Click);
            // 
            // btnSalvarDisciplina
            // 
            this.btnSalvarDisciplina.Location = new System.Drawing.Point(12, 92);
            this.btnSalvarDisciplina.Name = "btnSalvarDisciplina";
            this.btnSalvarDisciplina.Size = new System.Drawing.Size(116, 23);
            this.btnSalvarDisciplina.TabIndex = 16;
            this.btnSalvarDisciplina.Text = "Salvar";
            this.btnSalvarDisciplina.UseVisualStyleBackColor = true;
            this.btnSalvarDisciplina.Click += new System.EventHandler(this.btnSalvarDisciplina_Click);
            // 
            // txtCargaHorDisciplina
            // 
            this.txtCargaHorDisciplina.Location = new System.Drawing.Point(77, 39);
            this.txtCargaHorDisciplina.Name = "txtCargaHorDisciplina";
            this.txtCargaHorDisciplina.Size = new System.Drawing.Size(214, 20);
            this.txtCargaHorDisciplina.TabIndex = 15;
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Location = new System.Drawing.Point(77, 13);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(214, 20);
            this.txtDisciplina.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Carga Horaria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Disciplina:";
            // 
            // frmCadastroDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 136);
            this.Controls.Add(this.btnCancelarDisciplina);
            this.Controls.Add(this.btnSalvarDisciplina);
            this.Controls.Add(this.txtCargaHorDisciplina);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroDisciplina";
            this.Text = "frmCadastroDisciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarDisciplina;
        private System.Windows.Forms.Button btnSalvarDisciplina;
        private System.Windows.Forms.TextBox txtCargaHorDisciplina;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}