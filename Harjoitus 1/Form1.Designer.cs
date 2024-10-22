namespace Harjoitus_1
{
    partial class Form1
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
            this.VaihdaBT = new System.Windows.Forms.Button();
            this.otsikko = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VaihdaBT
            // 
            this.VaihdaBT.Location = new System.Drawing.Point(161, 138);
            this.VaihdaBT.Name = "VaihdaBT";
            this.VaihdaBT.Size = new System.Drawing.Size(75, 23);
            this.VaihdaBT.TabIndex = 0;
            this.VaihdaBT.Text = "button1";
            this.VaihdaBT.UseVisualStyleBackColor = true;
            this.VaihdaBT.Click += new System.EventHandler(this.VaihdaBT_Click);
            // 
            // otsikko
            // 
            this.otsikko.AutoSize = true;
            this.otsikko.Location = new System.Drawing.Point(112, 52);
            this.otsikko.Name = "otsikko";
            this.otsikko.Size = new System.Drawing.Size(54, 15);
            this.otsikko.TabIndex = 1;
            this.otsikko.Text = "Moi pyry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.otsikko);
            this.Controls.Add(this.VaihdaBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button VaihdaBT;
        private Label otsikko;
    }
}