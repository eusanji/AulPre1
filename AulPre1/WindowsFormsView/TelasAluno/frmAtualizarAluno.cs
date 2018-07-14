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
            alunosController.BuscarPorID(idAluno.AlunoID);

            txtNomeAtt.Text = idAluno.Nome;
           // txtMatriculaAtt.Text = int.Parse(idAluno.Matricula);

            
     
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAtt_Click(object sender, EventArgs e)
        {

        }

        private void btnProcuraMatricula_Click(object sender, EventArgs e)
        {   //Verificar
            Aluno aluno = new Aluno();
            aluno.Matricula = int.Parse(txtMatricula.Text);

            AlunosController alunosController = new AlunosController();
            alunosController.BuscarMatriculaAluno(aluno.Matricula);

            txtNomeAtt.Text = aluno.Nome;
            
            //Verificar
            
        }
    }
}
