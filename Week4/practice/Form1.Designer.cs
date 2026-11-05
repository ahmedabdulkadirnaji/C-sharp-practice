namespace Week4
{
    partial class Form1
    {
        private System.Windows.Forms.Label salesPrompt;
        private System.Windows.Forms.TextBox salesTextBox;
        private System.Windows.Forms.Label hoursPrompt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button bonusButton;
        private System.Windows.Forms.Button hoursButton;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.Text = "Week 4 - Lesson Practice";
            this.salesPrompt = new System.Windows.Forms.Label();
            this.salesPrompt.Name = "salesPrompt";
            this.salesPrompt.SetBounds(20, 20, 670, 30);
            this.salesPrompt.Text = "Sales";
            this.Controls.Add(this.salesPrompt);
            this.salesTextBox = new System.Windows.Forms.TextBox();
            this.salesTextBox.Name = "salesTextBox";
            this.salesTextBox.SetBounds(20, 65, 670, 30);
            this.salesTextBox.Text = "";
            this.Controls.Add(this.salesTextBox);
            this.hoursPrompt = new System.Windows.Forms.Label();
            this.hoursPrompt.Name = "hoursPrompt";
            this.hoursPrompt.SetBounds(20, 110, 670, 30);
            this.hoursPrompt.Text = "Hours (1-168)";
            this.Controls.Add(this.hoursPrompt);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox1.Name = "textBox1";
            this.textBox1.SetBounds(20, 155, 670, 30);
            this.textBox1.Text = "";
            this.Controls.Add(this.textBox1);
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.SetBounds(20, 200, 670, 30);
            this.resultLabel.Text = "Result appears here.";
            this.Controls.Add(this.resultLabel);
            this.bonusButton = new System.Windows.Forms.Button();
            this.bonusButton.Name = "bonusButton";
            this.bonusButton.Text = "Check bonus";
            this.bonusButton.SetBounds(20, 340, 165, 36);
            this.bonusButton.Click += new System.EventHandler(this.bonusButton_Click);
            this.Controls.Add(this.bonusButton);
            this.hoursButton = new System.Windows.Forms.Button();
            this.hoursButton.Name = "hoursButton";
            this.hoursButton.Text = "Validate hours";
            this.hoursButton.SetBounds(200, 340, 165, 36);
            this.hoursButton.Click += new System.EventHandler(this.hoursButton_Click);
            this.Controls.Add(this.hoursButton);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
