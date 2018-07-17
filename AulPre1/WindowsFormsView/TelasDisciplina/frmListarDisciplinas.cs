using Controllers;
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
    public partial class frmListarDisciplinas : Form
    {
        public frmListarDisciplinas()
        {
            InitializeComponent();
        }

        private void frmListarDisciplinas_Load(object sender, EventArgs e)
        {
           DisciplinaController disciplinaController = new DisciplinaController();
            dgvDisciplinas.DataSource = disciplinaController.ListarDisciplinas();
        }
    }
}
