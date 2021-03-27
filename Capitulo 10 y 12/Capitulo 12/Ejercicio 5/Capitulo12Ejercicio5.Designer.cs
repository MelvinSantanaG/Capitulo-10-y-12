
namespace Capitulo_10_y_12.Capitulo_12.Ejercicio_5
{
    partial class Capitulo12Ejercicio5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capitulo12Ejercicio5));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "using System;",
            "using System.Collections.Generic;",
            "using System.Text;",
            "",
            "namespace Cap12_2",
            "",
            "public class Program {",
            "          static void Main(string[] args){",
            "          int a = 5;",
            "          int b = 10;",
            "          int c = 0;",
            "          int r = 0;",
            "      ",
            "         Console.WriteLine(“Dame el valor del divisior”);",
            "         a = Convert.ToInt32(Console.ReadLine());",
            "         try",
            "         {",
            "                  r = b / a;",
            "          }",
            "          catch (Exception e)",
            "           {",
            "                  Console.WriteLine(“No es posible dividir entre cero”);",
            "                   r = 0;",
            "           }",
            "          finally",
            "          {",
            "                    Console.WriteLine(“El resultado es {0}”, r);",
            "          }",
            "",
            "         for (int n = 0; n < 5; n++){",
            "                    Console.WriteLine(“El resultado es {0}”, r);",
            "         }",
            "}"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 499);
            this.listBox1.TabIndex = 0;
            // 
            // Capitulo12Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(384, 520);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Capitulo12Ejercicio5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea 5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}