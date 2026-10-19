using System;
using System.Drawing;
using System.Windows.Forms;

namespace FourAssignments
{
    public class VehicleForm : Form
    {
        TextBox name = new(), ageBox = new(), daysBox = new(), experienceBox = new();
        ComboBox vehicle = new(), insurance = new();
        Label result = new();

        public VehicleForm()
        {
            Text = "Vehicle Rental Management System"; StartPosition = FormStartPosition.CenterParent; Size = new Size(630, 600);
            Ui.Title(this, Text); int y = 75;
            Ui.Label(this, "Customer Name:", 35, y); name = Ui.TextBox(this, 220, y); y += 45;
            Ui.Label(this, "Age:", 35, y); ageBox = Ui.TextBox(this, 220, y); y += 45;
            Ui.Label(this, "Rental Days:", 35, y); daysBox = Ui.TextBox(this, 220, y); y += 45;
            Ui.Label(this, "Driving Experience (years):", 35, y); experienceBox = Ui.TextBox(this, 220, y); y += 45;
            Ui.Label(this, "Vehicle Type:", 35, y); vehicle = Ui.Combo(this, 220, y, "Economy", "SUV", "Luxury"); y += 45;
            Ui.Label(this, "Insurance:", 35, y); insurance = Ui.Combo(this, 220, y, "No", "Yes"); y += 45;
            Ui.Button(this, "Calculate", 35, y, Calculate); Ui.Button(this, "Clear", 165, y, ClearForm); Ui.Button(this, "Exit", 295, y, Close);
            result = Ui.Result(this, y + 55);
        }

        void Calculate()
        {
            if (name.Text.Trim() == "") { Ui.Error("Enter customer name."); return; }
            if (!int.TryParse(ageBox.Text, out int age) || age < 18 || age > 80) { Ui.Error("Age must be between 18 and 80."); return; }
            if (!int.TryParse(daysBox.Text, out int days) || days < 1 || days > 30) { Ui.Error("Rental days must be between 1 and 30."); return; }
            if (!int.TryParse(experienceBox.Text, out int experience) || experience < 0) { Ui.Error("Experience must be zero or more."); return; }
            if (age < 21) { Ui.Error("Customer must be at least 21."); return; }
            if (experience < 1) { Ui.Error("At least one year of driving experience is required."); return; }
            if (vehicle.Text == "Luxury" && (age < 25 || experience < 3)) { Ui.Error("Luxury requires age 25+ and at least 3 years of experience."); return; }

            decimal rate = vehicle.Text == "Economy" ? 35m : vehicle.Text == "SUV" ? 60m : 100m;
            decimal basic = rate * days;
            decimal discount = basic * (days >= 14 ? .10m : days >= 7 ? .05m : 0m);
            decimal insuranceCost = insurance.Text == "Yes" ? 15m * days : 0m;
            decimal youngFee = age <= 24 ? (basic - discount) * .10m : 0m;
            decimal total = basic - discount + insuranceCost + youngFee;
            result.Text = $"Rental approved: {name.Text.Trim()}\nVehicle: {vehicle.Text} | Days: {days}\nBasic cost: {basic:C2}\nDiscount: {discount:C2}\nInsurance: {insuranceCost:C2}\nYoung driver surcharge: {youngFee:C2}\nTOTAL: {total:C2}";
        }
        void ClearForm() { name.Clear(); ageBox.Clear(); daysBox.Clear(); experienceBox.Clear(); vehicle.SelectedIndex = 0; insurance.SelectedIndex = 0; result.Text = ""; }
    }
}