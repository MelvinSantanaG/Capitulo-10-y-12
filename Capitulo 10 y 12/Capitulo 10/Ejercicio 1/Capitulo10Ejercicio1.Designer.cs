
namespace Capitulo_10_y_12.Capitulo_10.Ejercicio_1
{
    partial class Capitulo10Ejercicio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capitulo10Ejercicio1));
            this.InventarioListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // InventarioListBox
            // 
            this.InventarioListBox.FormattingEnabled = true;
            this.InventarioListBox.ItemHeight = 15;
            this.InventarioListBox.Items.AddRange(new object[] {
            "public class Inventario",
            "{",
            "       public int Codigo Producto",
            "       public string Descripcion ",
            "       public int Existencias Iniciales",
            "       public int Entradas",
            "       public int Salidas",
            "       public int Stock",
            "}",
            "",
            "public class Salida",
            "{",
            "       public int No Factura",
            "       public string Fecha",
            "       public int Codigo Producto",
            "       public string Descripcion",
            "       public int Cantidad",
            "}",
            "",
            "public class Entradas",
            "{",
            "       public int No Factura",
            "       public string Fecha",
            "       public int Codigo Producto",
            "       public string Descripcion",
            "       public int Cantidad",
            "}"});
            this.InventarioListBox.Location = new System.Drawing.Point(11, 12);
            this.InventarioListBox.Name = "InventarioListBox";
            this.InventarioListBox.Size = new System.Drawing.Size(296, 424);
            this.InventarioListBox.TabIndex = 0;
            // 
            // Capitulo10Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(319, 449);
            this.Controls.Add(this.InventarioListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Capitulo10Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InventarioListBox;
    }
}