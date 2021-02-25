
namespace Capitulo_10_y_12.Capitulo_12.Ejercicio_2
{
    partial class Cap12_Ejercicio2
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
            "using System;",
            "using System.IO;",
            "using System.Diagnostics;",
            "",
            "class TestDebug",
            "{",
            "    static void Main()",
            "    {",
            "        // Create a new stream object for an output file named TestFile.txt.",
            "        using (FileStream myFileStream =",
            "            new FileStream(\"TestFile.txt\", FileMode.Append))",
            "        {",
            "            // Add the stream object to the trace listeners.",
            "            TextWriterTraceListener myTextListener =",
            "                new TextWriterTraceListener(myFileStream);",
            "            Debug.Listeners.Add(myTextListener);",
            "",
            "            // Write output to the file.",
            "            Debug.WriteLine(\"Test output\");",
            "",
            "            // Flush and close the output stream.",
            "            Debug.Flush();",
            "            Debug.Close();",
            "        }",
            "    }",
            "}"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(362, 394);
            this.listBox1.TabIndex = 0;
            // 
            // Cap12_Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 412);
            this.Controls.Add(this.listBox1);
            this.Name = "Cap12_Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cap12_Ejercicio2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}