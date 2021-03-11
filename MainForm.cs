using Capitulo_10_y_12.Capitulo_10;
using Capitulo_10_y_12.Capitulo_12;
using System;
using System.Windows.Forms;

namespace Capitulo_10_y_12
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Capitulo10Button_Click(object sender, EventArgs e)
        {
            var Capitulo10 = new Capitulo10_Ejercicios();
            Capitulo10.Show();
        }

        private void Capitulo12Button_Click(object sender, EventArgs e)
        {
            var Capitulo12 = new Capitulo12_Ejercicios();
            Capitulo12.Show();
        }
    }
}
