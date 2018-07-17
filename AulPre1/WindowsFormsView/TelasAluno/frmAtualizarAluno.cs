using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsView.TelasAluno
{
    public partial class frmAtualizarAluno : Form
    {
        public frmAtualizarAluno()
        {
            InitializeComponent();
        }

        private void btnProcuraAluno_Click(object sender, EventArgs e)
        {
            
            Aluno idAluno = new Aluno();
            idAluno.AlunoID = int.Parse(txtAlunoid.Text);

            AlunosController alunosController = new AlunosController();
            idAluno = alunosController.BuscarPorID(idAluno.AlunoID);

            if (idAluno == null )
            {                              
                MessageBox.Show("ID não cadastrado, digitado: " + int.Parse(txtAlunoid.Text) + "\nO valor não pode ser Zero (0)" + "\nNumero digitado não pode estar negativo");
            }
            else if (idAluno.AlunoID >= 1)
            {              
                txtNomeAtt.Text = idAluno.Nome;
                txtMatriculaAtt.Text = idAluno.Matricula.ToString();              
            }            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            Aluno attAluno = new Aluno();
            attAluno.AlunoID = int.Parse(txtAlunoid.Text);
           
            if (attAluno.AlunoID >= 1)  {                        
                attAluno.Nome = txtNomeAtt.Text;
                attAluno.Matricula = int.Parse(txtMatriculaAtt.Text);

                AlunosController alunosController = new AlunosController();
                alunosController.Atualizar(attAluno);
                MessageBox.Show("Aluno atualizado com sucesso");
                txtAlunoid.Clear(); txtNomeAtt.Clear(); txtMatriculaAtt.Clear();
            }
           

        }

        private void btnCancelarAtt_Click(object sender, EventArgs e)
        {

        }

        private void btnProcuraMatricula_Click(object sender, EventArgs e)
        {   //Verificar
           Aluno matricula = new Aluno();
           matricula.Matricula = int.Parse(txtMatricula.Text);

            AlunosController alunosController = new AlunosController();
            matricula = alunosController.BuscarMatriculaAluno(matricula.Matricula);

           txtNomeAtt.Text = matricula.Nome;
           txtMatriculaAtt.Text = matricula.Matricula.ToString();
    
            //Verificar
            
        }
    }
}
