
namespace Capitulo_10_y_12.Capitulo_10.Ejercicio_5
{
    partial class Cap10_Ejercicio5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "public class Poligono()",
            "{",
            "    int Lado;",
            "    int Diagonales;",
            "    int Angulo;",
            "",
            "     // Pedimos los datos",
            "    Console.WriteLine(“Dame el Lado”);",
            "    Lado = Convert.ToInt32(Console.ReadLine());",
            "",
            "    Console.WriteLine(“Dame el Diagonales”);",
            "    Diagonales = Convert.ToInt32(Console.ReadLine());",
            "",
            "    Console.WriteLine(“Dame el Angulo”);",
            "    Angulo = Convert.ToInt32(Console.ReadLine());",
            "}",
            "",
            "public override string ToString()",
            "{",
            "      String mensaje = “”;",
            "      mensaje += “Ancho “ + ancho.ToString() + “ Alto “ + alto.ToString() + “ Esp" +
                "esor “ + espesor.ToString();",
            "      mensaje += “ Area “ + area.ToString() + “ Volumen “ +  volumen.ToString();",
            "      return mensaje;",
            "}"});
            this.listBox1.Location = new System.Drawing.Point(3, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(560, 394);
            this.listBox1.TabIndex = 0;
            // 
            // Cap10_Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 414);
            this.Controls.Add(this.listBox1);
            this.Name = "Cap10_Ejercicio5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cap10_Ejercicio5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}