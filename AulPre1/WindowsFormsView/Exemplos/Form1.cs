using System;
using System.Windows.Forms;

namespace WindowsFormsView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCancelar.Text = "Abrir Form 2";
            btnSalvar.Text = "Ok";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //f2.Show();//Exibe a janela e continua
            f2.ShowDialog();//Exibe as janelas logo a anterior fica travada esperando resolver a que esta no fluxo
            this.Hide();//janela do fluxo anterior fecha
             

        }
    }
}
