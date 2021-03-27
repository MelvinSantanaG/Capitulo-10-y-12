using Capitulo_10_y_12.Capitulo_12.Ejercicio_1;
using Capitulo_10_y_12.Capitulo_12.Ejercicio_2;
using Capitulo_10_y_12.Capitulo_12.Ejercicio_3;
using Capitulo_10_y_12.Capitulo_12.Ejercicio_4;
using Capitulo_10_y_12.Capitulo_12.Ejercicio_5;
using System;
using System.Windows.Forms;

namespace Capitulo_10_y_12.Capitulo_12
{
    public partial class Capitulo12EjerciciosForm : Form
    {
        public Capitulo12EjerciciosForm()
        {
            InitializeComponent();
        }

        /*Botones de los Ejercicios del Captulo 12*/

        private void Capitulo12Ejercicio1Button_Click(object sender, EventArgs e)
        {
            /*1 Usar la depuración paso a paso para observar cómo cambia el valor de la variable en el programa del factorial.*/
            var Capitulo12Ejercicio1 = new Capitulo12Ejercicio1();
            Capitulo12Ejercicio1.Show();
        }

        private void Capitulo12Ejercicio2Button_Click(object sender, EventArgs e)
        {
            /*2 Utilizar el método WriteLine() de la clase Debug para que las funciones nos indiquen cuando entramos y salimos de ellas.*/
            var Capitulo12Ejercicio2 = new Capitulo12Ejercicio2();
            Capitulo12Ejercicio2.Show();
        }

        private void Capitulo12Ejercicio3Button_Click(object sender, EventArgs e)
        {
            /*3 Buscar en MSDN cuáles son las excepciones que pueden ocurrir con los arreglos.*/
            var Capitulo12Ejercicio3 = new Capitulo12Ejercicio3();
            Capitulo12Ejercicio3.Show();
        }

        private void Capitulo12Ejercicio4Button_Click(object sender, EventArgs e)
        {
            /*4 Buscar en MSDN cuáles son las excepciones que pueden ocurrir con los streams.*/
            var Capitulo12Ejercicio4 = new Capitulo12Ejercicio4();
            Capitulo12Ejercicio4.Show();
        }

        private void Capitulo12Ejercicio5Button_Click(object sender, EventArgs e)
        {
            /*5 Buscar en MSDN cuáles son las excepciones que pueden ocurrir con el método WriteLine().*/
            var Capitulo12Ejercicio5 = new Capitulo12Ejercicio5();
            Capitulo12Ejercicio5.Show();
        }
    }
}
