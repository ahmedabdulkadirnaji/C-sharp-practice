using System;
using System.IO;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Chapter 1, slide 35: clearing label output.
        private void clearButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "";
        }

        // Chapter 1, slide 39: showing one picture and hiding another.
        private void showBackButton_Click(object sender, EventArgs e)
        {
            cardBackPictureBox.Visible = true;
            cardFacePictureBox.Visible = false;
        }

        // Practice extension: show the face again.
        private void showFaceButton_Click(object sender, EventArgs e)
        {
            cardBackPictureBox.Visible = false;
            cardFacePictureBox.Visible = true;
            answerLabel.Text = "Card face is visible.";
        }

        // Chapter 1, section 2.9.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
