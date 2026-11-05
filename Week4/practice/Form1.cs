using System;
using System.IO;
using System.Windows.Forms;

namespace Week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Adapted from Chapter 3, slide 6 (sales > 50000).
        private void bonusButton_Click(object sender, EventArgs e)
        {
            decimal sales;
            if (!decimal.TryParse(salesTextBox.Text, out sales))
            {
                MessageBox.Show("Enter numeric sales.");
                return;
            }

            decimal bonus = 0;
            if (sales > 50000)
            {
                bonus = 500;
            }
            resultLabel.Text = "Bonus: " + bonus.ToString("F2");
        }

        // Adapted from Chapter 3, slides 20-21: parse, then validate.
        private void hoursButton_Click(object sender, EventArgs e)
        {
            int hours;
            if (int.TryParse(textBox1.Text, out hours))
            {
                if (hours > 0 && hours <= 168)
                {
                    resultLabel.Text = "Valid hours.";
                }
                else
                {
                    resultLabel.Text = "Hours must be 1 to 168.";
                }
            }
            else
            {
                resultLabel.Text = "Enter a whole number.";
            }
        }
    }
}
