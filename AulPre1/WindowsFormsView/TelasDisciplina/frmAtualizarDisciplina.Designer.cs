namespace WindowsFormsView.TelasDisciplina
{
    partial class frmAtualizarDisciplina
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
            this.btnProcuraDisciplina = new System.Windows.Forms.Button();
            this.txtDisciplinaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarAttDisciplina = new System.Windows.Forms.Button();
            this.btnAtualizarDisciplina = new System.Windows.Forms.Button();
            this.txtCargaHorariaAtt = new System.Windows.Forms.TextBox();
            this.txtDisciplinaAtt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcuraDisciplina
            // 
            this.btnProcuraDisciplina.Location = new System.Drawing.Point(184, 12);
            this.btnProcuraDisciplina.Name = "btnProcuraDisciplina";
            this.btnProcuraDisciplina.Size = new System.Drawing.Size(101, 23);
            this.btnProcuraDisciplina.TabIndex = 24;
            this.btnProcuraDisciplina.Text = "Procurar por ID";
            this.btnProcuraDisciplina.UseVisualStyleBackColor = true;
            this.btnProcuraDisciplina.Click += new System.EventHandler(this.btnProcuraDisciplina_Click);
            // 
            // txtDisciplinaID
            // 
            this.txtDisciplinaID.Location = new System.Drawing.Point(116, 12);
            this.txtDisciplinaID.Name = "txtDisciplinaID";
            this.txtDisciplinaID.Size = new System.Drawing.Size(59, 20);
            this.txtDisciplinaID.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Digite a DisciplinaID ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Carga Horaria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Disciplina:";
            // 
            // btnCancelarAttDisciplina
            // 
            this.btnCancelarAttDisciplina.Location = new System.Drawing.Point(184, 147);
            this.btnCancelarAttDisciplina.Name = "btnCancelarAttDisciplina";
            this.btnCancelarAttDisciplina.Size = new System.Drawing.Size(119, 23);
            this.btnCancelarAttDisciplina.TabIndex = 19;
            this.btnCancelarAttDisciplina.Text = "Cancelar";
            this.btnCancelarAttDisciplina.UseVisualStyleBackColor = true;
            this.btnCancelarAttDisciplina.Click += new System.EventHandler(this.btnCancelarAttDisciplina_Click);
            // 
            // btnAtualizarDisciplina
            // 
            this.btnAtualizarDisciplina.Location = new System.Drawing.Point(43, 147);
            this.btnAtualizarDisciplina.Name = "btnAtualizarDisciplina";
            this.btnAtualizarDisciplina.Size = new System.Drawing.Size(116, 23);
            this.btnAtualizarDisciplina.TabIndex = 18;
            this.btnAtualizarDisciplina.Text = "Atualizar";
            this.btnAtualizarDisciplina.UseVisualStyleBackColor = true;
            this.btnAtualizarDisciplina.Click += new System.EventHandler(this.btnAtualizarDisciplina_Click);
            // 
            // txtCargaHorariaAtt
            // 
            this.txtCargaHorariaAtt.Location = new System.Drawing.Point(83, 110);
            this.txtCargaHorariaAtt.Name = "txtCargaHorariaAtt";
            this.txtCargaHorariaAtt.Size = new System.Drawing.Size(214, 20);
            this.txtCargaHorariaAtt.TabIndex = 17;
            // 
            // txtDisciplinaAtt
            // 
            this.txtDisciplinaAtt.Location = new System.Drawing.Point(83, 85);
            this.txtDisciplinaAtt.Name = "txtDisciplinaAtt";
            this.txtDisciplinaAtt.Size = new System.Drawing.Size(214, 20);
            this.txtDisciplinaAtt.TabIndex = 16;
            // 
            // frmAtualizarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 210);
            this.Controls.Add(this.btnProcuraDisciplina);
            this.Controls.Add(this.txtDisciplinaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarAttDisciplina);
            this.Controls.Add(this.btnAtualizarDisciplina);
            this.Controls.Add(this.txtCargaHorariaAtt);
            this.Controls.Add(this.txtDisciplinaAtt);
            this.Name = "frmAtualizarDisciplina";
            this.Text = "frmAtualizarDisciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcuraDisciplina;
        private System.Windows.Forms.TextBox txtDisciplinaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarAttDisciplina;
        private System.Windows.Forms.Button btnAtualizarDisciplina;
        private System.Windows.Forms.TextBox txtCargaHorariaAtt;
        private System.Windows.Forms.TextBox txtDisciplinaAtt;
    }
}