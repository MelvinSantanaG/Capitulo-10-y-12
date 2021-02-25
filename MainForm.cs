using Capitulo_10_y_12.Capitulo_10.Ejercicio_1;
using Capitulo_10_y_12.Capitulo_10.Ejercicio_2;
using Capitulo_10_y_12.Capitulo_10.Ejercicio_3;
using Capitulo_10_y_12.Capitulo_10.Ejercicio_4;
using Capitulo_10_y_12.Capitulo_10.Ejercicio_5;
using Capitulo_10_y_12.Capitulo_12.Ejercicio_1;
using Capitulo_10_y_12.Capitulo_12.Ejercicio_2;
using Capitulo_10_y_12.Capitulo_12.Ejercicio_3;
using Capitulo_10_y_12.Capitulo_12.Ejercicio_4;
using Capitulo_10_y_12.Capitulo_12.Ejercicio_5;
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

        /*Botones de los Ejercicios del Captulo 12*/
        private void Cap12_Ejercicio1_Button_Click(object sender, EventArgs e)
        {
            /*1 Usar la depuración paso a paso para observar cómo cambia el valor de la variable en el programa del factorial.*/
            var Cap12_Ejercicio1 = new Cap12_Ejercicio1();
            Cap12_Ejercicio1.Show();
        }

        private void Cap12_Ejercicio2_Button_Click(object sender, EventArgs e)
        {
            /*2 Utilizar el método WriteLine() de la clase Debug para que las funciones nos indiquen cuando entramos y salimos de ellas.*/
            var Cap12_Ejercicio2 = new Cap12_Ejercicio2();
            Cap12_Ejercicio2.Show();
        }

        private void Cap12_Ejercicio3_Button_Click(object sender, EventArgs e)
        {
            /*3 Buscar en MSDN cuáles son las excepciones que pueden ocurrir con los arreglos.*/
            var Cap12_Ejercicio3 = new Cap12_Ejercicio3();
            Cap12_Ejercicio3.Show();
        }

        private void Cap12_Ejercicio4_Button_Click(object sender, EventArgs e)
        {
            /*4 Buscar en MSDN cuáles son las excepciones que pueden ocurrir con los streams.*/
            var Cap12_Ejercicio4 = new Cap12_Ejercicio4();
            Cap12_Ejercicio4.Show();
        }

        private void Cap12_Ejercicio5_Button_Click(object sender, EventArgs e)
        {
            /*5 Buscar en MSDN cuáles son las excepciones que pueden ocurrir con el método WriteLine().*/
            var Cap12_Ejercicio5 = new Cap12_Ejercicio5();
            Cap12_Ejercicio5.Show();
        }
    }
}
