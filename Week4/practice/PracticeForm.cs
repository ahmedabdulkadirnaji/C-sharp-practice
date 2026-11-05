using System;
using System.Drawing;
using System.Windows.Forms;

public class PracticeForm : Form
{
    TextBox scoreBox = new TextBox();
    RadioButton fullTime = new RadioButton();
    RadioButton partTime = new RadioButton();
    CheckBox scholarship = new CheckBox();
    ListBox courses = new ListBox();
    Label result = new Label();
    public PracticeForm()
    {
        Text = "Week 4 - Student Result";
        Size = new Size(550, 430);
        Label prompt = new Label();
        prompt.Text = "Score (0-100)";
        prompt.SetBounds(20, 15, 200, 25);
        scoreBox.SetBounds(20, 45, 180, 25);
        fullTime.Text = "Full time";
        fullTime.SetBounds(20, 85, 110, 25);
        fullTime.Checked = true;
        partTime.Text = "Part time";
        partTime.SetBounds(150, 85, 110, 25);
        scholarship.Text = "Scholarship requested";
        scholarship.SetBounds(20, 120, 240, 25);
        courses.SetBounds(20, 160, 200, 70);
        courses.Items.Add("C#");
        courses.Items.Add("Database");
        Button check = new Button();
        check.Text = "Check result";
        check.SetBounds(20, 245, 140, 35);
        check.Click += CheckResult;
        result.SetBounds(20, 295, 490, 80);
        Controls.AddRange(new Control[] { prompt, scoreBox, fullTime,
            partTime, scholarship, courses, check, result });
    }
    void CheckResult(object sender, EventArgs e)
    {
        int score;
        if (!int.TryParse(scoreBox.Text, out score)
            || score < 0 || score > 100)
        {
            result.Text = "Enter a whole-number score from 0 to 100.";
            return;
        }
        if (courses.SelectedIndex == -1)
        {
            result.Text = "Select a course first.";
            return;
        }
        string grade;
        if (score >= 90) grade = "A";
        else if (score >= 80) grade = "B";
        else if (score >= 70) grade = "C";
        else if (score >= 60) grade = "D";
        else grade = "F";
        string course = courses.SelectedItem.ToString();
        string advice;
        switch (course)
        {
            case "C#": advice = "Review event handlers."; break;
            case "Database": advice = "Review table design."; break;
            default: advice = "Review your notes."; break;
        }
        bool eligible = scholarship.Checked && score >= 80;
        string mode = fullTime.Checked ? "Full time" : "Part time";
        result.Text = course + " - Grade: " + grade + " - " + mode
            + "\nScholarship eligible: " + eligible + "\n" + advice;
    }
    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new PracticeForm());
    }
}