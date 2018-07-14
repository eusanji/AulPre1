namespace WindowsFormsView
{
    partial class MenuPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizarAluno = new System.Windows.Forms.Button();
            this.btnListarAluno = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeletarProfessor = new System.Windows.Forms.Button();
            this.btnAtualizarProfessor = new System.Windows.Forms.Button();
            this.btnListarAlunos = new System.Windows.Forms.Button();
            this.btnCadastrarProfessor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeletarDisciplina = new System.Windows.Forms.Button();
            this.btnAtualizarDisciplina = new System.Windows.Forms.Button();
            this.btnListarDisciplinas = new System.Windows.Forms.Button();
            this.btnCadDisciplina = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Controls.Add(this.btnAtualizarAluno);
            this.groupBox1.Controls.Add(this.btnListarAluno);
            this.groupBox1.Controls.Add(this.btnCadastrarAluno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(7, 108);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizarAluno
            // 
            this.btnAtualizarAluno.Location = new System.Drawing.Point(6, 79);
            this.btnAtualizarAluno.Name = "btnAtualizarAluno";
            this.btnAtualizarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarAluno.TabIndex = 1;
            this.btnAtualizarAluno.Text = "Atualizar";
            this.btnAtualizarAluno.UseVisualStyleBackColor = true;
            this.btnAtualizarAluno.Click += new System.EventHandler(this.btnAtualizarAluno_Click);
            // 
            // btnListarAluno
            // 
            this.btnListarAluno.Location = new System.Drawing.Point(7, 50);
            this.btnListarAluno.Name = "btnListarAluno";
            this.btnListarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnListarAluno.TabIndex = 1;
            this.btnListarAluno.Text = "Listar";
            this.btnListarAluno.UseVisualStyleBackColor = true;
            this.btnListarAluno.Click += new System.EventHandler(this.btnListarAluno_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(7, 20);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAluno.TabIndex = 0;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeletarProfessor);
            this.groupBox2.Controls.Add(this.btnAtualizarProfessor);
            this.groupBox2.Controls.Add(this.btnListarAlunos);
            this.groupBox2.Controls.Add(this.btnCadastrarProfessor);
            this.groupBox2.Location = new System.Drawing.Point(144, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Professor";
            // 
            // btnDeletarProfessor
            // 
            this.btnDeletarProfessor.Location = new System.Drawing.Point(7, 108);
            this.btnDeletarProfessor.Name = "btnDeletarProfessor";
            this.btnDeletarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarProfessor.TabIndex = 2;
            this.btnDeletarProfessor.Text = "Deletar";
            this.btnDeletarProfessor.UseVisualStyleBackColor = true;
            this.btnDeletarProfessor.Click += new System.EventHandler(this.btnDeletarProfessor_Click);
            // 
            // btnAtualizarProfessor
            // 
            this.btnAtualizarProfessor.Location = new System.Drawing.Point(6, 79);
            this.btnAtualizarProfessor.Name = "btnAtualizarProfessor";
            this.btnAtualizarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarProfessor.TabIndex = 1;
            this.btnAtualizarProfessor.Text = "Atualizar";
            this.btnAtualizarProfessor.UseVisualStyleBackColor = true;
            this.btnAtualizarProfessor.Click += new System.EventHandler(this.btnAtualizarProfessor_Click);
            // 
            // btnListarAlunos
            // 
            this.btnListarAlunos.Location = new System.Drawing.Point(7, 50);
            this.btnListarAlunos.Name = "btnListarAlunos";
            this.btnListarAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnListarAlunos.TabIndex = 1;
            this.btnListarAlunos.Text = "Listar";
            this.btnListarAlunos.UseVisualStyleBackColor = true;
            this.btnListarAlunos.Click += new System.EventHandler(this.btnListarAlunos_Click);
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(7, 20);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarProfessor.TabIndex = 0;
            this.btnCadastrarProfessor.Text = "Cadastrar";
            this.btnCadastrarProfessor.UseVisualStyleBackColor = true;
            this.btnCadastrarProfessor.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeletarDisciplina);
            this.groupBox3.Controls.Add(this.btnAtualizarDisciplina);
            this.groupBox3.Controls.Add(this.btnListarDisciplinas);
            this.groupBox3.Controls.Add(this.btnCadDisciplina);
            this.groupBox3.Location = new System.Drawing.Point(281, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(88, 147);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disciplina";
            // 
            // btnDeletarDisciplina
            // 
            this.btnDeletarDisciplina.Location = new System.Drawing.Point(7, 108);
            this.btnDeletarDisciplina.Name = "btnDeletarDisciplina";
            this.btnDeletarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarDisciplina.TabIndex = 2;
            this.btnDeletarDisciplina.Text = "Deletar";
            this.btnDeletarDisciplina.UseVisualStyleBackColor = true;
            this.btnDeletarDisciplina.Click += new System.EventHandler(this.btnDeletarDisciplina_Click);
            // 
            // btnAtualizarDisciplina
            // 
            this.btnAtualizarDisciplina.Location = new System.Drawing.Point(7, 79);
            this.btnAtualizarDisciplina.Name = "btnAtualizarDisciplina";
            this.btnAtualizarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarDisciplina.TabIndex = 1;
            this.btnAtualizarDisciplina.Text = "Atualizar";
            this.btnAtualizarDisciplina.UseVisualStyleBackColor = true;
            this.btnAtualizarDisciplina.Click += new System.EventHandler(this.btnAtualizarDisciplina_Click);
            // 
            // btnListarDisciplinas
            // 
            this.btnListarDisciplinas.Location = new System.Drawing.Point(7, 50);
            this.btnListarDisciplinas.Name = "btnListarDisciplinas";
            this.btnListarDisciplinas.Size = new System.Drawing.Size(75, 23);
            this.btnListarDisciplinas.TabIndex = 1;
            this.btnListarDisciplinas.Text = "Listar";
            this.btnListarDisciplinas.UseVisualStyleBackColor = true;
            this.btnListarDisciplinas.Click += new System.EventHandler(this.btnListarDisciplinas_Click);
            // 
            // btnCadDisciplina
            // 
            this.btnCadDisciplina.Location = new System.Drawing.Point(7, 20);
            this.btnCadDisciplina.Name = "btnCadDisciplina";
            this.btnCadDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnCadDisciplina.TabIndex = 0;
            this.btnCadDisciplina.Text = "Cadastrar";
            this.btnCadDisciplina.UseVisualStyleBackColor = true;
            this.btnCadDisciplina.Click += new System.EventHandler(this.btnCadDisciplina_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 176);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListarAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Button btnAtualizarAluno;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeletarProfessor;
        private System.Windows.Forms.Button btnAtualizarProfessor;
        private System.Windows.Forms.Button btnListarAlunos;
        private System.Windows.Forms.Button btnCadastrarProfessor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeletarDisciplina;
        private System.Windows.Forms.Button btnAtualizarDisciplina;
        private System.Windows.Forms.Button btnListarDisciplinas;
        private System.Windows.Forms.Button btnCadDisciplina;
    }
}