using System;
using System.IO;
using System.Windows.Forms;

namespace Week5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Chapter 4, slide 5. Close each message to see the next one.
        private void whileButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count < 5)
            {
                MessageBox.Show("Hello");
                count = count + 1;
            }
        }

        // Chapter 4, slide 15.
        private void forButton_Click(object sender, EventArgs e)
        {
            for (int count = 0; count < 5; count++)
            {
                MessageBox.Show("Hello");
            }
        }

        // Chapter 4, slide 19: the body runs once before the test.
        private void doWhileButton_Click(object sender, EventArgs e)
        {
            int number = 1;
            do
            {
                MessageBox.Show(number.ToString());
            } while (number < 0);
        }

        // Practice adaptation of slides 23-24 and 31-37.
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter outputFile =
                            File.CreateText(saveFileDialog.FileName))
                        {
                            outputFile.WriteLine("C# practice");
                            outputFile.WriteLine("Loops and files");
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Cannot write this file.");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Access denied.");
                    }
                }
            }
        }
    }
}
