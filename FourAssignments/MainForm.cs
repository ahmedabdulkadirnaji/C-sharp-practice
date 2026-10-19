using System;
using System.Drawing;
using System.Windows.Forms;

namespace FourAssignments
{
    public class MainForm : Form
    {
        public MainForm()
        {
            Text = "Four Windows Forms Assignments";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(560, 440);
            BackColor = Color.WhiteSmoke;
            Controls.Add(new Label { Text = "Windows Forms Assignments", Font = new Font("Segoe UI", 18, FontStyle.Bold), AutoSize = true, Location = new Point(80, 30) });
            AddButton("1. Hotel Booking System", 100, () => new HotelForm().ShowDialog(this));
            AddButton("2. Flight Booking System", 160, () => new FlightForm().ShowDialog(this));
            AddButton("3. Vehicle Rental System", 220, () => new VehicleForm().ShowDialog(this));
            AddButton("4. Course Registration Fee", 280, () => new CourseForm().ShowDialog(this));
        }

        void AddButton(string text, int y, Action action)
        {
            var b = new Button { Text = text, Location = new Point(90, y), Size = new Size(360, 42), Font = new Font("Segoe UI", 11) };
            b.Click += (s, e) => action();
            Controls.Add(b);
        }
    }
}