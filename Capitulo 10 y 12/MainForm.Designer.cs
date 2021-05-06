
namespace Capitulo_10_y_12
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Capitulo10Button = new System.Windows.Forms.Button();
            this.Capitulo12Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Capitulo10Button
            // 
            this.Capitulo10Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Capitulo10Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Capitulo10Button.Location = new System.Drawing.Point(15, 10);
            this.Capitulo10Button.Name = "Capitulo10Button";
            this.Capitulo10Button.Size = new System.Drawing.Size(78, 23);
            this.Capitulo10Button.TabIndex = 13;
            this.Capitulo10Button.Text = "Capitulo 10";
            this.Capitulo10Button.UseVisualStyleBackColor = true;
            this.Capitulo10Button.Click += new System.EventHandler(this.Capitulo10Button_Click);
            // 
            // Capitulo12Button
            // 
            this.Capitulo12Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Capitulo12Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Capitulo12Button.Location = new System.Drawing.Point(100, 10);
            this.Capitulo12Button.Name = "Capitulo12Button";
            this.Capitulo12Button.Size = new System.Drawing.Size(83, 23);
            this.Capitulo12Button.TabIndex = 14;
            this.Capitulo12Button.Text = "Capitulo 12";
            this.Capitulo12Button.UseVisualStyleBackColor = true;
            this.Capitulo12Button.Click += new System.EventHandler(this.Capitulo12Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(199, 45);
            this.Controls.Add(this.Capitulo12Button);
            this.Controls.Add(this.Capitulo10Button);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Capitulo10Button;
        private System.Windows.Forms.Button Capitulo12Button;
    }
}

