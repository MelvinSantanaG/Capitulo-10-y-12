using Capitulo_10_y_12.Capitulo_10.Ejercicio_1;
using Capitulo_10_y_12.Capitulo_10.Ejercicio_2;
using Capitulo_10_y_12.Capitulo_10.Ejercicio_3;
using Capitulo_10_y_12.Capitulo_10.Ejercicio_4;
using Capitulo_10_y_12.Capitulo_10.Ejercicio_5;
using System;
using System.Windows.Forms;

namespace Capitulo_10_y_12.Capitulo_10
{
    public partial class Capitulo10_Ejercicios : Form
    {
        public Capitulo10_Ejercicios()
        {
            InitializeComponent();
        }

        /*Botones de los Ejercicio2 del Captulo 10*/
        private void Cap10_Ejercicio1_Button_Click(object sender, EventArgs e)
        {
            /*1 Crear el diseño de una clase para llevar el inventario de una tienda.*/
            var Cap10_Ejercicio1 = new Cap10_Ejercicio1();
            Cap10_Ejercicio1.Show();
        }

        private void Cap10_Ejercicio2_Button_Click(object sender, EventArgs e)
        {
            /*2 Crear una clase para llevar la información de los estudiantes de una escuela.*/
            var Cap10_Ejercicio2 = new Cap10_Ejercicio2();
            Cap10_Ejercicio2.Show();
        }

        private void Cap10_Ejercicio3_Button_Click(object sender, EventArgs e)
        {
            /*3 Crear una clase para polígonos con sobrecarga del constructor.*/
            var Cap10_Ejercicio3 = new Cap10_Ejercicio3();
            Cap10_Ejercicio3.Show();
        }

        private void Cap10_Ejercicio4_Button_Click(object sender, EventArgs e)
        {
            /*4 Crear propiedades para la clase polígono que solamente permitan colocar valores válidos.*/
            var Cap10_Ejercicio4 = new Cap10_Ejercicio4();
            Cap10_Ejercicio4.Show();
        }

        private void Cap10_Ejercicio5_Button_Click(object sender, EventArgs e)
        {
            /*5 Programar el método ToString() para la clase polígono.*/
            var Cap10_Ejercicio5 = new Cap10_Ejercicio5();
            Cap10_Ejercicio5.Show();
        }
    }
}
