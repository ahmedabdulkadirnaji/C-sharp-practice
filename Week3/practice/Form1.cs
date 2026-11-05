using System;
using System.IO;
using System.Windows.Forms;

namespace Week3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Chapter 2, slide 26: arithmetic and ToString.
        private void addButton_Click(object sender, EventArgs e)
        {
            int x = 5, y = 4;
            MessageBox.Show((x + y).ToString());
        }

        // Chapter 2, slide 27: integer division.
        private void divideButton_Click(object sender, EventArgs e)
        {
            int x = 7, y = 3;
            MessageBox.Show((x / y).ToString());
        }

        // Chapter 2, slide 27: casting preserves the fraction.
        private void fractionButton_Click(object sender, EventArgs e)
        {
            int x = 7, y = 3;
            MessageBox.Show(((double)x / y).ToString());
        }

        // Adapted from slides 28, 30 and 32, with exception handling.
        private void hoursButton_Click(object sender, EventArgs e)
        {
            try
            {
                int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
                const decimal HourlyRate = 10m;
                decimal grossPay = hoursWorked * HourlyRate;
                grossPayLabel.Text = grossPay.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a whole number of hours.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("That number is too large.");
            }
        }
    }
}
