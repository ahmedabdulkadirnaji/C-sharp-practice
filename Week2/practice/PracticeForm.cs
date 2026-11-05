using System;
using System.Drawing;
using System.Windows.Forms;

public class PracticeForm : Form
{
    Label result = new Label();
    PictureBox picture = new PictureBox();
    public PracticeForm()
    {
        Text = "Week 2 - Forms and Events";
        Size = new Size(520, 340);
        result.SetBounds(20, 20, 460, 40);
        result.Text = "Click Show to update this label.";
        picture.SetBounds(20, 70, 100, 70);
        picture.BackColor = Color.SteelBlue;
        picture.SizeMode = PictureBoxSizeMode.Zoom;
        Controls.Add(result);
        Controls.Add(picture);
        AddButton("Show", 20, ShowMessage);
        AddButton("Toggle", 140, TogglePicture);
        AddButton("Clear", 260, ClearLabel);
        AddButton("Exit", 380, ExitForm);
    }
    void AddButton(string text, int x, EventHandler handler)
    {
        Button button = new Button();
        button.Text = text;
        button.SetBounds(x, 180, 100, 35);
        button.Click += handler;
        Controls.Add(button);
    }
    void ShowMessage(object sender, EventArgs e)
    {
        // Assignment changes the label's Text property.
        result.Text = "Welcome to C# practice!";
    }
    void TogglePicture(object sender, EventArgs e)
    {
        // A coloured placeholder avoids needing an external image.
        picture.Visible = !picture.Visible;
    }
    void ClearLabel(object sender, EventArgs e)
    {
        result.Text = string.Empty;
    }
    void ExitForm(object sender, EventArgs e)
    {
        Close();
    }
    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new PracticeForm());
    }
}