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
    public partial class frmDeletarDisciplina : Form
    {
        public frmDeletarDisciplina()
        {
            InitializeComponent();
        }

        private void btnDeletarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina delD = new Disciplina
            {
                DisciplinaID = int.Parse(txtDeletarDisciplina.Text)
            };

            DisciplinaController disciplinasController = new DisciplinaController();
            disciplinasController.ExcluirD(delD.DisciplinaID);

            MessageBox.Show("o Id:" + delD.DisciplinaID);
        }
    }
}
