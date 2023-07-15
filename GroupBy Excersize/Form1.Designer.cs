namespace GroupBy_Excersize
{
    partial class Form1
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
            this.TestBtn = new System.Windows.Forms.Button();
            this.OutputTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TestBtn
            // 
            this.TestBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TestBtn.Location = new System.Drawing.Point(0, 0);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(800, 23);
            this.TestBtn.TabIndex = 0;
            this.TestBtn.Text = "&Test";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // OutputTB
            // 
            this.OutputTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputTB.Location = new System.Drawing.Point(0, 23);
            this.OutputTB.Multiline = true;
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTB.Size = new System.Drawing.Size(800, 427);
            this.OutputTB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputTB);
            this.Controls.Add(this.TestBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.TextBox OutputTB;
    }
}

