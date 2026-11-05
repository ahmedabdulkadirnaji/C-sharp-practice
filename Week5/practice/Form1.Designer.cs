namespace Week5
{
    partial class Form1
    {
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button whileButton;
        private System.Windows.Forms.Button forButton;
        private System.Windows.Forms.Button doWhileButton;
        private System.Windows.Forms.Button saveButton;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.Text = "Week 5 - Lesson Practice";
            this.promptLabel = new System.Windows.Forms.Label();
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.SetBounds(20, 20, 670, 30);
            this.promptLabel.Text = "While and For show five messages; Do-while shows one.";
            this.Controls.Add(this.promptLabel);
            this.whileButton = new System.Windows.Forms.Button();
            this.whileButton.Name = "whileButton";
            this.whileButton.Text = "While loop";
            this.whileButton.SetBounds(20, 340, 165, 36);
            this.whileButton.Click += new System.EventHandler(this.whileButton_Click);
            this.Controls.Add(this.whileButton);
            this.forButton = new System.Windows.Forms.Button();
            this.forButton.Name = "forButton";
            this.forButton.Text = "For loop";
            this.forButton.SetBounds(200, 340, 165, 36);
            this.forButton.Click += new System.EventHandler(this.forButton_Click);
            this.Controls.Add(this.forButton);
            this.doWhileButton = new System.Windows.Forms.Button();
            this.doWhileButton.Name = "doWhileButton";
            this.doWhileButton.Text = "Do-while loop";
            this.doWhileButton.SetBounds(380, 340, 165, 36);
            this.doWhileButton.Click += new System.EventHandler(this.doWhileButton_Click);
            this.Controls.Add(this.doWhileButton);
            this.saveButton = new System.Windows.Forms.Button();
            this.saveButton.Name = "saveButton";
            this.saveButton.Text = "Save text";
            this.saveButton.SetBounds(560, 340, 165, 36);
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.Controls.Add(this.saveButton);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
