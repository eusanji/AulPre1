using System;
using System.Windows.Forms;
using WindowsFormsView.TelasAluno;
using WindowsFormsView.TelasDisciplina;
using WindowsFormsView.TelasProfessor;

namespace WindowsFormsView
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            frmCadastroAluno cadAluno = new frmCadastroAluno();
            cadAluno.Show();
        }

        private void btnListarAluno_Click(object sender, EventArgs e)
        {
            frmListaAlunos listaAlunos = new frmListaAlunos();
            listaAlunos.Show();
            

        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        {
            frmAtualizarAluno atualizarAluno = new frmAtualizarAluno();
            atualizarAluno.Show();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            frmDeletar delAluno = new frmDeletar();
            delAluno.Show();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            frmCadastroProfessor cadProf = new frmCadastroProfessor();
            cadProf.Show();
        }

        private void btnListarAlunos_Click(object sender, EventArgs e)
        {
            frmListaProfessor listaProfessor = new frmListaProfessor();
            listaProfessor.Show();
            

        }

        private void btnAtualizarProfessor_Click(object sender, EventArgs e)
        {
            frmAtualizarProfessor atualizarProfessor = new frmAtualizarProfessor();
            atualizarProfessor.Show();

        }

        private void btnDeletarProfessor_Click(object sender, EventArgs e)
        {
            frmDeletarProfessor delP = new frmDeletarProfessor();
            delP.Show();
        }

        private void btnCadDisciplina_Click(object sender, EventArgs e)
        {
            frmCadastroDisciplina cadDisciplina = new frmCadastroDisciplina();
            cadDisciplina.Show();
        
        }

        private void btnListarDisciplinas_Click(object sender, EventArgs e)
        {
            frmListarDisciplinas listarDisciplinas = new frmListarDisciplinas();
            listarDisciplinas.Show();
        }

        private void btnAtualizarDisciplina_Click(object sender, EventArgs e)
        {
            frmAtualizarDisciplina atualizarDisciplina = new frmAtualizarDisciplina();
            atualizarDisciplina.Show();
        }

        private void btnDeletarDisciplina_Click(object sender, EventArgs e)
        {
            frmDeletarDisciplina deletarDisciplina = new frmDeletarDisciplina();
            deletarDisciplina.Show();

        }
    }
}
