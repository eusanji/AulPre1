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
    public partial class frmCadastroDisciplina : Form
    {
        public frmCadastroDisciplina()
        {
            InitializeComponent();
        }

        private void btnSalvarDisciplina_Click(object sender, EventArgs e)
        {
           Disciplina nd = new Disciplina();
            nd.NomeD = txtDisciplina.Text;
            nd.CargaHoraria = int.Parse(txtCargaHorDisciplina.Text);

            DisciplinaController disciplinaController= new DisciplinaController();
            disciplinaController.InserirDisci(nd);

            txtDisciplina.Text = string.Empty;
            txtCargaHorDisciplina.Text = string.Empty;

            MessageBox.Show("Diciplina Cadastrada com sucesso");
        }

        private void btnCancelarDisciplina_Click(object sender, EventArgs e)
        {
          /**  if (MessageBox.Show("Confirmar para limpar dados?", "Mensagem do sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtDisciplina.Text = string.Empty;
                txtCargaHorDisciplina.Text = string.Empty;
                MessageBox.Show("Dados limpos com sucesso!");

            }
            else
            {
                MessageBox.Show("Continue seu cadastramento da Disciplina!", "Mensagem do sistema");
            }**/
        }
    }
}
