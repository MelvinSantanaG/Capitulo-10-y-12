
namespace Capitulo_10_y_12.Capitulo_12.Ejercicio_4
{
    partial class Capitulo12Ejercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capitulo12Ejercicio4));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "int GetInt(int[] array, int index)",
            "{",
            "    try",
            "    {",
            "        return array[index];",
            "    }",
            "    catch (IndexOutOfRangeException e) when (index < 0) ",
            "    {",
            "        throw new ArgumentOutOfRangeException(",
            "            \"Parameter index cannot be negative.\", e);",
            "    }",
            "    catch (IndexOutOfRangeException e)",
            "    {",
            "        throw new ArgumentOutOfRangeException(",
            "            \"Parameter index cannot be greater than the array size.\", e);",
            "    }",
            "    catch (Exception e) when (LogException(e))",
            "    {",
            "    }",
            "    Console.WriteLine(\"Exception must have been handled\");",
            "   catch (UnauthorizedAccessException e)",
            "   {",
            "    // Call a custom error logging procedure.",
            "    LogError(e);",
            "    // Re-throw the error.",
            "    throw;",
            "    }",
            "}"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 439);
            this.listBox1.TabIndex = 0;
            // 
            // Capitulo12Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(391, 461);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Capitulo12Ejercicio4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}