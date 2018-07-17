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
    public partial class frmAtualizarProfessor : Form
    {
        public frmAtualizarProfessor()
        {
            InitializeComponent();
        }

        private void btnProcuraProfessor_Click(object sender, EventArgs e)
        {
            Professor pp = new Professor();
            pp.ProfessorID = int.Parse(txtProfessorid.Text);

            ProfessoresController pc = new ProfessoresController();
            pp = pc.BuscarProfID(pp.ProfessorID);

            txtNomeAttProf.Text = pp.NomeP.ToString();
            txtMatriculaProf.Text= pp.MatriculaP.ToString();

        }

        private void btnAtualizarProfessor_Click(object sender, EventArgs e)
        {
            Professor attProf = new Professor();
            attProf.ProfessorID = int.Parse(txtProfessorid.Text);

            if (attProf.ProfessorID >= 1)
            {
                attProf.NomeP = txtNomeAttProf.Text;
                attProf.MatriculaP = int.Parse(txtMatriculaAttProf.Text);

                ProfessoresController pc = new ProfessoresController();
                pc.AtualizarP(attProf);
                MessageBox.Show("Professor atualizado com sucesso");
                txtProfessorid.Clear(); txtNomeAttProf.Clear(); txtMatriculaAttProf.Clear();
            }
        }
    }
}
