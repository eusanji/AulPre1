using Models;
using Controllers;
using System;
using System.Windows.Forms;

namespace WindowsFormsView.TelasAluno
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar para limpar dados?", "Mensagem do sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtNome.Text = string.Empty;
                txtMatricula.Text = string.Empty;
                MessageBox.Show("Dados limpos com sucesso!");

            } else {
                MessageBox.Show("Continue seu cadastramento de Aluno!", "Mensagem do sistema");
            }
           

            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno novoAluno = new Aluno();
            novoAluno.Nome = txtNome.Text;
            novoAluno.Matricula = int.Parse(txtMatricula.Text);

            AlunosController alunosController = new AlunosController();
            alunosController.Inserir(novoAluno);

            txtNome.Text = string.Empty;
            txtMatricula.Text = string.Empty;

            MessageBox.Show("Aluno Cadastrado com sucesso");



        }
                
    }
}
