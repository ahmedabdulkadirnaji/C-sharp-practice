using System;
using System.Drawing;
using System.Windows.Forms;

namespace FourAssignments
{
    public class FlightForm : Form
    {
        TextBox ageBox = new(), ticketsBox = new(), baggageBox = new(), priceBox = new();
        ComboBox flightClass = new();
        CheckBox insurance = new();
        Label result = new();

        public FlightForm()
        {
            Text = "Flight Booking System"; StartPosition = FormStartPosition.CenterParent; Size = new Size(620, 610);
            Ui.Title(this, Text); int y = 75;
            Ui.Label(this, "Passenger Age:", 35, y); ageBox = Ui.TextBox(this, 210, y); y += 45;
            Ui.Label(this, "Number of Tickets:", 35, y); ticketsBox = Ui.TextBox(this, 210, y); y += 45;
            Ui.Label(this, "Baggage (kg/passenger):", 35, y); baggageBox = Ui.TextBox(this, 210, y); y += 45;
            Ui.Label(this, "Ticket Price ($):", 35, y); priceBox = Ui.TextBox(this, 210, y); priceBox.Text = "200"; y += 45;
            Ui.Label(this, "Class:", 35, y); flightClass = Ui.Combo(this, 210, y, "Economy", "Business", "First Class"); y += 45;
            insurance.Text = "Travel insurance (+$25 per ticket)"; insurance.AutoSize = true; insurance.Location = new Point(210, y); Controls.Add(insurance); y += 45;
            Ui.Button(this, "Calculate", 35, y, Calculate); Ui.Button(this, "Clear", 165, y, ClearForm); Ui.Button(this, "Exit", 295, y, Close);
            result = Ui.Result(this, y + 55);
        }

        void Calculate()
        {
            if (!int.TryParse(ageBox.Text, out int age) || age < 1 || age > 100) { Ui.Error("Age must be between 1 and 100."); return; }
            if (!int.TryParse(ticketsBox.Text, out int tickets) || tickets < 1 || tickets > 5) { Ui.Error("Tickets must be between 1 and 5."); return; }
            if (!decimal.TryParse(baggageBox.Text, out decimal baggage) || baggage < 0 || baggage > 50) { Ui.Error("Baggage must be between 0 and 50 kg."); return; }
            if (!decimal.TryParse(priceBox.Text, out decimal price) || price <= 0) { Ui.Error("Enter a valid ticket price."); return; }
            if (age < 12 && flightClass.Text == "First Class") { Ui.Error("Passengers under 12 cannot book First Class."); return; }

            decimal basic = price * tickets;
            decimal ticketDiscount = basic * (tickets == 5 ? .10m : tickets >= 3 ? .05m : 0m);
            decimal ageDiscount = age < 12 ? basic * .20m : age >= 60 ? basic * .10m : 0m;
            decimal insuranceCost = insurance.Checked ? 25m * tickets : 0m;
            decimal total = basic - ticketDiscount - ageDiscount + insuranceCost;
            result.Text = $"Booking approved\nAge: {age} | Class: {flightClass.Text} | Tickets: {tickets}\nBaggage: {baggage:0.##} kg per passenger\nBasic cost: {basic:C2}\nTicket discount: {ticketDiscount:C2}\nAge discount: {ageDiscount:C2}\nInsurance: {insuranceCost:C2}\nTOTAL: {total:C2}\nNo excess-baggage fee was specified.";
        }
        void ClearForm() { ageBox.Clear(); ticketsBox.Clear(); baggageBox.Clear(); priceBox.Text = "200"; flightClass.SelectedIndex = 0; insurance.Checked = false; result.Text = ""; }
    }
}