﻿using Controllers;
using System.Windows.Forms;

namespace WindowsFormsView.TelasAluno
{
    public partial class frmListaAlunos : Form
    {
        public frmListaAlunos()
        {
            InitializeComponent();
        }

        private void formListaAlunos_Load(object sender, System.EventArgs e)
        {
            AlunosController alunoscontroller = new AlunosController();
            dgvAlunos.DataSource = alunoscontroller.ListarTodos();
        }
    }
}
