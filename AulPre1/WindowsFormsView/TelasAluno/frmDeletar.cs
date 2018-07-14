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

namespace WindowsFormsView.TelasAluno
{
    public partial class frmDeletar : Form
    {
        public frmDeletar()
        {
            InitializeComponent();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Aluno del = new Aluno
            {
                AlunoID = int.Parse(txtDeletar.Text)
            };

            AlunosController alunosController = new AlunosController();
            alunosController.Excluir(del.AlunoID);

            MessageBox.Show("o Id:"+del.AlunoID);
        }
    }
}
