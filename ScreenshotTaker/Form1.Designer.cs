namespace ScreenshotTaker
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
            this.pickDirButton = new System.Windows.Forms.Button();
            this.ssLabel = new System.Windows.Forms.Label();
            this.lastSSLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pickDirButton
            // 
            this.pickDirButton.Location = new System.Drawing.Point(12, 28);
            this.pickDirButton.Name = "pickDirButton";
            this.pickDirButton.Size = new System.Drawing.Size(102, 23);
            this.pickDirButton.TabIndex = 0;
            this.pickDirButton.Text = "Choose Directory";
            this.pickDirButton.UseVisualStyleBackColor = true;
            this.pickDirButton.Click += new System.EventHandler(this.pickDirButton_Click);
            // 
            // ssLabel
            // 
            this.ssLabel.AutoSize = true;
            this.ssLabel.Location = new System.Drawing.Point(12, 9);
            this.ssLabel.Name = "ssLabel";
            this.ssLabel.Size = new System.Drawing.Size(209, 13);
            this.ssLabel.TabIndex = 1;
            this.ssLabel.Text = "Pick a directory to start saving screenshots";
            // 
            // lastSSLabel
            // 
            this.lastSSLabel.AutoSize = true;
            this.lastSSLabel.Location = new System.Drawing.Point(12, 58);
            this.lastSSLabel.Name = "lastSSLabel";
            this.lastSSLabel.Size = new System.Drawing.Size(0, 13);
            this.lastSSLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 99);
            this.Controls.Add(this.lastSSLabel);
            this.Controls.Add(this.ssLabel);
            this.Controls.Add(this.pickDirButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pickDirButton;
        private System.Windows.Forms.Label ssLabel;
        private System.Windows.Forms.Label lastSSLabel;
    }
}

