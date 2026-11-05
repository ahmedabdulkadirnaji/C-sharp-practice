using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class PracticeForm : Form
{
    ListBox numbers = new ListBox();
    Label result = new Label();
    Random random = new Random();
    public PracticeForm()
    {
        Text = "Week 5 - Dice and Files";
        Size = new Size(520, 400);
        numbers.SetBounds(20, 20, 180, 220);
        result.SetBounds(20, 260, 470, 60);
        Controls.Add(numbers);
        Controls.Add(result);
        AddButton("Roll 5 dice", 20, RollDice);
        AddButton("Save", 80, SaveNumbers);
        AddButton("Open", 140, OpenNumbers);
        Load += delegate { result.Text = "Ready to roll five dice."; };
    }
    void AddButton(string text, int y, EventHandler handler)
    {
        Button button = new Button();
        button.Text = text;
        button.SetBounds(240, y, 160, 40);
        button.Click += handler;
        Controls.Add(button);
    }
    void RollDice(object sender, EventArgs e)
    {
        numbers.Items.Clear();
        int total = 0;
        for (int i = 0; i < 5; i++)
        {
            int value = random.Next(1, 7); // Upper bound is exclusive.
            numbers.Items.Add(value);
            total += value;
        }
        int countdown = 3;
        do { countdown--; } while (countdown > 0);
        result.Text = "Total: " + total + "; countdown: " + countdown;
    }
    void SaveNumbers(object sender, EventArgs e)
    {
        using (SaveFileDialog dialog = new SaveFileDialog())
        {
            dialog.Filter = "Text files|*.txt";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (StreamWriter output = File.CreateText(dialog.FileName))
                {
                    for (int i = 0; i < numbers.Items.Count; i++)
                        output.WriteLine(numbers.Items[i]);
                }
                result.Text = "Numbers saved.";
            }
            catch (IOException) { result.Text = "Cannot write this file."; }
            catch (UnauthorizedAccessException) { result.Text = "Access denied."; }
        }
    }
    void OpenNumbers(object sender, EventArgs e)
    {
        using (OpenFileDialog dialog = new OpenFileDialog())
        {
            dialog.Filter = "Text files|*.txt";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (StreamReader input = File.OpenText(dialog.FileName))
                {
                    numbers.Items.Clear();
                    while (!input.EndOfStream)
                        numbers.Items.Add(input.ReadLine());
                }
                result.Text = "Loaded lines: " + numbers.Items.Count;
            }
            catch (IOException) { result.Text = "Cannot read this file."; }
            catch (UnauthorizedAccessException) { result.Text = "Access denied."; }
        }
    }
    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new PracticeForm());
    }
}