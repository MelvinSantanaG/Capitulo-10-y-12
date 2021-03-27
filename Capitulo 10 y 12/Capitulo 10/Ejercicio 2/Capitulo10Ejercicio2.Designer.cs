
namespace Capitulo_10_y_12.Capitulo_10.Ejercicio_2
{
    partial class Capitulo10Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capitulo10Ejercicio2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "class Persona",
            "{",
            "   public string cedula;",
            "   public string nombre;",
            "   public string apellido;",
            "}",
            "",
            "public class Persona(string cedula, string nombre, string apellido)",
            "{",
            "     this.cedula = cedula;",
            "     this.nombre = nombre;",
            "     this.apellido = apellido;",
            "}",
            "",
            "public string GetCedula {return cedula;}",
            "",
            "public string GetNombre() {return nombre;}",
            "",
            "public string GetApellido() { return apellido;}",
            "",
            "class Estudiante : Persona ",
            "{",
            "    private string matricula;",
            "    private string carrera; ",
            "}",
            "",
            "public Estudiante(string cedula, string nombre, string apellido, string matricula" +
                ", string carrera) : base (cedula,nombre,apellido)",
            "{",
            "     this.cedula = cedula;",
            "     this.nombre = nombre;",
            "     this.apellido = apellido;",
            "}",
            "",
            "public string GetMatricula() { return matricula;}",
            "",
            "public string GetCarrera() { return carrera;}"});
            this.listBox1.Location = new System.Drawing.Point(11, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(686, 499);
            this.listBox1.TabIndex = 0;
            // 
            // Capitulo10Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(709, 526);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Capitulo10Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}