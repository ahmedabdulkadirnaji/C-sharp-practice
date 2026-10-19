using System;
using System.Drawing;
using System.Windows.Forms;

namespace FourAssignments
{
    public class CourseForm : Form
    {
        TextBox name = new(), studentId = new(), coursesBox = new();
        ComboBox year = new();
        CheckBox accommodation = new(), transport = new();
        Label result = new();

        public CourseForm()
        {
            Text = "Course Registration Fee System"; StartPosition = FormStartPosition.CenterParent; Size = new Size(630, 600);
            Ui.Title(this, Text); int y = 75;
            Ui.Label(this, "Student Name:", 35, y); name = Ui.TextBox(this, 220, y); y += 45;
            Ui.Label(this, "Student ID:", 35, y); studentId = Ui.TextBox(this, 220, y); y += 45;
            Ui.Label(this, "Number of Courses:", 35, y); coursesBox = Ui.TextBox(this, 220, y); y += 45;
            Ui.Label(this, "Study Level:", 35, y); year = Ui.Combo(this, 220, y, "Year 1", "Year 2", "Year 3", "Year 4"); y += 45;
            accommodation.Text = "Accommodation (+$120)"; accommodation.AutoSize = true; accommodation.Location = new Point(220, y); Controls.Add(accommodation); y += 35;
            transport.Text = "Transport (+$50)"; transport.AutoSize = true; transport.Location = new Point(220, y); Controls.Add(transport); y += 45;
            Ui.Button(this, "Calculate", 35, y, Calculate); Ui.Button(this, "Clear", 165, y, ClearForm); Ui.Button(this, "Exit", 295, y, Close);
            result = Ui.Result(this, y + 55);
        }

        void Calculate()
        {
            if (name.Text.Trim() == "") { Ui.Error("Enter student name."); return; }
            if (studentId.Text.Trim() == "") { Ui.Error("Enter student ID."); return; }
            if (!int.TryParse(coursesBox.Text, out int courses) || courses < 1 || courses > 8) { Ui.Error("Courses must be between 1 and 8."); return; }

            decimal rate = year.SelectedIndex switch { 0 => 40m, 1 => 45m, 2 => 50m, _ => 55m };
            decimal tuition = courses * rate;
            decimal accommodationFee = accommodation.Checked ? 120m : 0m;
            decimal transportFee = transport.Checked ? 50m : 0m;
            decimal discountRate = courses >= 6 ? .10m : 0m;
            if (courses >= 5 && accommodation.Checked && transport.Checked) discountRate += .05m;
            decimal discount = tuition * discountRate;
            decimal total = tuition + accommodationFee + transportFee - discount;
            result.Text = $"Student: {name.Text.Trim()} (ID: {studentId.Text.Trim()})\nLevel: {year.Text} | Courses: {courses}\nTuition: {tuition:C2}\nAccommodation: {accommodationFee:C2}\nTransport: {transportFee:C2}\nDiscount: {discount:C2}\nFINAL FEE: {total:C2}";
        }
        void ClearForm() { name.Clear(); studentId.Clear(); coursesBox.Clear(); year.SelectedIndex = 0; accommodation.Checked = false; transport.Checked = false; result.Text = ""; }
    }
}