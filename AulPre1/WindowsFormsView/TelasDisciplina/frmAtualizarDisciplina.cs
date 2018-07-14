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

namespace WindowsFormsView.TelasDisciplina
{
    public partial class frmAtualizarDisciplina : Form
    {
        public frmAtualizarDisciplina()
        {
            InitializeComponent();
        }

        private void btnProcuraDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina DisciplinaId = new Disciplina();
            DisciplinaId.DisciplinaID = int.Parse(txtDisciplinaAtt.Text);

            DisciplinaController disciplinaController = new DisciplinaController();
            disciplinaController.BuscarDiscID(DisciplinaId.DisciplinaID);

            txtDisciplinaAtt.Text = DisciplinaId.NomeD;
            // txtMatriculaAtt.Text = int.Parse(idAluno.Matricula);
        }

        private void btnAtualizarDisciplina_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAttDisciplina_Click(object sender, EventArgs e)
        {

        }
    }
}
