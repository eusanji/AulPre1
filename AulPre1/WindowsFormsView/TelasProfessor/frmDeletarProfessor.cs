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
    public partial class frmDeletarProfessor : Form
    {
        public frmDeletarProfessor()
        {
            InitializeComponent();
        }

        private void btnDeletarProf_Click(object sender, EventArgs e)
        {
            Professor delP = new Professor
            {
                ProfessorID = int.Parse(txtDeletarProf.Text)
            };

            ProfessoresController professoresController = new ProfessoresController();
            professoresController.ExcluirP(delP.ProfessorID);
            txtDeletarProf.Clear();

            MessageBox.Show("o Id do professor:" + delP.ProfessorID);
        }
    }
}
