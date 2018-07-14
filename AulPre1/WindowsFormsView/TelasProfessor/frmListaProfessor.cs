using Controllers;
using System;
using System.Windows.Forms;

namespace WindowsFormsView.TelasProfessor
{
    public partial class frmListaProfessor : Form
    {
        public frmListaProfessor()
        {
            InitializeComponent();
        }

private void frmListaProfessor_Load(object sender, EventArgs e)
        {
            ProfessoresController professoresController = new ProfessoresController();
            dgvProfessores.DataSource = professoresController.ListarTodosProfessor();
            
        }
    }

}
