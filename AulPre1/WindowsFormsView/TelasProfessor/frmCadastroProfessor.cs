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

namespace WindowsFormsView.TelasProfessor
{
    public partial class frmCadastroProfessor : Form
    {
        public frmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void btnSalvarProfessor_Click(object sender, EventArgs e)
        {
            Professor novoProf = new Professor();
            novoProf.NomeP = txtNomeProfessor.Text;
            novoProf.MatriculaP = int.Parse(txtMatriculaProfessor.Text);

            ProfessoresController professoresController = new ProfessoresController();
            professoresController.InserirProf(novoProf);

            txtNomeProfessor.Text = string.Empty;
            txtMatriculaProfessor.Text = string.Empty;

            MessageBox.Show("Professor Cadastrado com sucesso");

        }

        private void btnCancelarProfessor_Click(object sender, EventArgs e)
        {
           /** if (MessageBox.Show("Confirmar para limpar dados?", "Mensagem do sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtNomeProfessor.Text = string.Empty;
                txtMatriculaProfessor.Text = string.Empty;
                MessageBox.Show("Dados limpos com sucesso!");

            }
            else
            {
                MessageBox.Show("Continue seu cadastramento do Professor!", "Mensagem do sistema");
            }**/
        }
    }
}
