namespace Week2
{
    partial class Form1
    {
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.PictureBox cardBackPictureBox;
        private System.Windows.Forms.PictureBox cardFacePictureBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFaceButton;
        private System.Windows.Forms.Button exitButton;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.Text = "Week 2 - Lesson Practice";
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.SetBounds(20, 20, 670, 30);
            this.answerLabel.Text = "Card face is visible.";
            this.Controls.Add(this.answerLabel);
            this.cardBackPictureBox = new System.Windows.Forms.PictureBox();
            this.cardBackPictureBox.Name = "cardBackPictureBox";
            this.cardBackPictureBox.SetBounds(20, 65, 670, 30);
            this.cardBackPictureBox.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.cardBackPictureBox);
            this.cardFacePictureBox = new System.Windows.Forms.PictureBox();
            this.cardFacePictureBox.Name = "cardFacePictureBox";
            this.cardFacePictureBox.SetBounds(20, 110, 670, 30);
            this.cardFacePictureBox.BackColor = System.Drawing.Color.Goldenrod;
            this.Controls.Add(this.cardFacePictureBox);
            this.clearButton = new System.Windows.Forms.Button();
            this.clearButton.Name = "clearButton";
            this.clearButton.Text = "Clear label";
            this.clearButton.SetBounds(20, 340, 165, 36);
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            this.Controls.Add(this.clearButton);
            this.showBackButton = new System.Windows.Forms.Button();
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Text = "Show back";
            this.showBackButton.SetBounds(200, 340, 165, 36);
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            this.Controls.Add(this.showBackButton);
            this.showFaceButton = new System.Windows.Forms.Button();
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Text = "Show face";
            this.showFaceButton.SetBounds(380, 340, 165, 36);
            this.showFaceButton.Click += new System.EventHandler(this.showFaceButton_Click);
            this.Controls.Add(this.showFaceButton);
            this.exitButton = new System.Windows.Forms.Button();
            this.exitButton.Name = "exitButton";
            this.exitButton.Text = "Exit";
            this.exitButton.SetBounds(560, 340, 165, 36);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.Controls.Add(this.exitButton);
            this.cardBackPictureBox.Visible = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
