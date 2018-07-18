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
            Disciplina idDisciplina = new Disciplina();
            idDisciplina.DisciplinaID = int.Parse(txtDisciplinaID.Text);

            DisciplinaController dc = new DisciplinaController();
            idDisciplina = dc.BuscarDiscID(idDisciplina.DisciplinaID);
            if (idDisciplina == null)
            {
                MessageBox.Show("Identificação da disciplina não existe, \n não pode ser 0 ou Negativo");
            }
            else if (idDisciplina.DisciplinaID >= 1)
            {
                txtDisciplinaAtt.Text = idDisciplina.NomeD;
                txtCargaHorariaAtt.Text = idDisciplina.CargaHoraria.ToString();
            }

        }

        private void btnAtualizarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = new Disciplina();
            disciplina.DisciplinaID = int.Parse(txtDisciplinaID.Text);

            if (disciplina.DisciplinaID >= 1)
            {
                disciplina.NomeD = txtDisciplinaAtt.Text;
                disciplina.CargaHoraria = int.Parse(txtCargaHorariaAtt.Text);
                

              DisciplinaController dc = new DisciplinaController();
              dc.AtualizarD(disciplina);
              MessageBox.Show("Disciplina atualizada");
              txtDisciplinaID.Clear(); txtDisciplinaAtt.Clear(); txtCargaHorariaAtt.Clear();
            }
        }

        private void btnCancelarAttDisciplina_Click(object sender, EventArgs e)
        {
            txtDisciplinaID.Clear(); txtCargaHorariaAtt.Clear();txtDisciplinaAtt.Clear();
        }
    }
}
