using System;
using System.Drawing;
using System.Windows.Forms;

namespace FourAssignments
{
    public class HotelForm : Form
    {
        TextBox name = new(), ageBox = new(), nightsBox = new(), guestsBox = new();
        ComboBox room = new();
        CheckBox breakfast = new();
        Label result = new();

        public HotelForm()
        {
            Text = "Hotel Booking System"; StartPosition = FormStartPosition.CenterParent; Size = new Size(600, 570);
            Ui.Title(this, Text); int y = 75;
            Ui.Label(this, "Guest Name:", 35, y); name = Ui.TextBox(this, 190, y); y += 45;
            Ui.Label(this, "Guest Age:", 35, y); ageBox = Ui.TextBox(this, 190, y); y += 45;
            Ui.Label(this, "Number of Nights:", 35, y); nightsBox = Ui.TextBox(this, 190, y); y += 45;
            Ui.Label(this, "Number of Guests:", 35, y); guestsBox = Ui.TextBox(this, 190, y); y += 45;
            Ui.Label(this, "Room Type:", 35, y); room = Ui.Combo(this, 190, y, "Standard", "Normal", "Hight"); y += 45;
            breakfast.Text = "Breakfast ($10 per guest/night)"; breakfast.AutoSize = true; breakfast.Location = new Point(190, y); Controls.Add(breakfast); y += 45;
            Ui.Button(this, "Calculate", 35, y, Calculate); Ui.Button(this, "Clear", 165, y, ClearForm); Ui.Button(this, "Exit", 295, y, Close);
            result = Ui.Result(this, y + 55);
        }

        void Calculate()
        {
            if (name.Text.Trim() == "") { Ui.Error("Enter guest name."); return; }
            if (!int.TryParse(ageBox.Text, out int age) || age < 18 || age > 90) { Ui.Error("Age must be between 18 and 90."); return; }
            if (!int.TryParse(nightsBox.Text, out int nights) || nights < 1 || nights > 30) { Ui.Error("Nights must be between 1 and 30."); return; }
            if (!int.TryParse(guestsBox.Text, out int guests) || guests < 1 || guests > 6) { Ui.Error("Guests must be between 1 and 6."); return; }

            // The handout's room names and capacity names differ; these are the assumed matching capacities.
            int max = room.Text == "Standard" ? 2 : room.Text == "Normal" ? 4 : 6;
            if (guests > max) { Ui.Error($"This room allows up to {max} guests."); return; }
            decimal rate = room.Text == "Standard" ? 50m : room.Text == "Normal" ? 80m : 130m;
            decimal basic = rate * nights;
            decimal discount = basic * (nights >= 10 ? .12m : nights >= 5 ? .05m : 0m);
            decimal breakfastCost = breakfast.Checked ? 10m * guests * nights : 0m;
            decimal service = guests > 4 ? (basic - discount + breakfastCost) * .05m : 0m;
            decimal senior = age >= 60 ? (basic - discount) * .05m : 0m;
            decimal total = basic - discount + breakfastCost + service - senior;
            result.Text = $"Booking approved: {name.Text.Trim()}\nRoom: {room.Text} | Nights: {nights} | Guests: {guests}\nRoom cost: {basic:C2}\nNight discount: {discount:C2}\nBreakfast: {breakfastCost:C2}\nService surcharge: {service:C2}\nSenior discount: {senior:C2}\nTOTAL: {total:C2}";
        }
        void ClearForm() { name.Clear(); ageBox.Clear(); nightsBox.Clear(); guestsBox.Clear(); room.SelectedIndex = 0; breakfast.Checked = false; result.Text = ""; }
    }
}