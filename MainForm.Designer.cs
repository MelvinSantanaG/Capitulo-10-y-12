
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
            this.Cap10_Button = new System.Windows.Forms.Button();
            this.Capitulo12_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cap10_Button
            // 
            this.Cap10_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cap10_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cap10_Button.Location = new System.Drawing.Point(26, 12);
            this.Cap10_Button.Name = "Cap10_Button";
            this.Cap10_Button.Size = new System.Drawing.Size(78, 23);
            this.Cap10_Button.TabIndex = 13;
            this.Cap10_Button.Text = "Capitulo 10";
            this.Cap10_Button.UseVisualStyleBackColor = true;
            this.Cap10_Button.Click += new System.EventHandler(this.Capitulo10Button_Click);
            // 
            // Capitulo12_Button
            // 
            this.Capitulo12_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Capitulo12_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Capitulo12_Button.Location = new System.Drawing.Point(110, 12);
            this.Capitulo12_Button.Name = "Capitulo12_Button";
            this.Capitulo12_Button.Size = new System.Drawing.Size(83, 23);
            this.Capitulo12_Button.TabIndex = 14;
            this.Capitulo12_Button.Text = "Capitulo 12";
            this.Capitulo12_Button.UseVisualStyleBackColor = true;
            this.Capitulo12_Button.Click += new System.EventHandler(this.Capitulo12Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(219, 45);
            this.Controls.Add(this.Capitulo12_Button);
            this.Controls.Add(this.Cap10_Button);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Cap10_Button;
        private System.Windows.Forms.Button Capitulo12_Button;
    }
}

