namespace Week3
{
    partial class Form1
    {
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button fractionButton;
        private System.Windows.Forms.Button hoursButton;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.Text = "Week 3 - Lesson Practice";
            this.promptLabel = new System.Windows.Forms.Label();
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.SetBounds(20, 20, 670, 30);
            this.promptLabel.Text = "Hours worked (whole number)";
            this.Controls.Add(this.promptLabel);
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.SetBounds(20, 65, 670, 30);
            this.hoursWorkedTextBox.Text = "";
            this.Controls.Add(this.hoursWorkedTextBox);
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.SetBounds(20, 110, 670, 30);
            this.grossPayLabel.Text = "Pay appears here.";
            this.Controls.Add(this.grossPayLabel);
            this.addButton = new System.Windows.Forms.Button();
            this.addButton.Name = "addButton";
            this.addButton.Text = "Add 5 + 4";
            this.addButton.SetBounds(20, 340, 165, 36);
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.Controls.Add(this.addButton);
            this.divideButton = new System.Windows.Forms.Button();
            this.divideButton.Name = "divideButton";
            this.divideButton.Text = "Divide 7 / 3";
            this.divideButton.SetBounds(200, 340, 165, 36);
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            this.Controls.Add(this.divideButton);
            this.fractionButton = new System.Windows.Forms.Button();
            this.fractionButton.Name = "fractionButton";
            this.fractionButton.Text = "Double division";
            this.fractionButton.SetBounds(380, 340, 165, 36);
            this.fractionButton.Click += new System.EventHandler(this.fractionButton_Click);
            this.Controls.Add(this.fractionButton);
            this.hoursButton = new System.Windows.Forms.Button();
            this.hoursButton.Name = "hoursButton";
            this.hoursButton.Text = "Calculate pay";
            this.hoursButton.SetBounds(560, 340, 165, 36);
            this.hoursButton.Click += new System.EventHandler(this.hoursButton_Click);
            this.Controls.Add(this.hoursButton);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
