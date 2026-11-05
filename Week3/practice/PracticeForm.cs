using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

public class PracticeForm : Form
{
    const decimal TaxRate = 0.05m;
    TextBox priceBox = new TextBox();
    TextBox quantityBox = new TextBox();
    Label result = new Label();
    int calculations = 0; // A field keeps its value between clicks.
    public PracticeForm()
    {
        Text = "Week 3 - Order Calculator";
        Size = new Size(530, 300);
        Label prompt = new Label();
        prompt.Text = "Unit price (e.g. 12.50)                 Quantity";
        prompt.SetBounds(20, 20, 460, 25);
        priceBox.SetBounds(20, 50, 200, 25);
        quantityBox.SetBounds(250, 50, 200, 25);
        Button calculate = new Button();
        calculate.Text = "Calculate";
        calculate.SetBounds(20, 95, 110, 35);
        calculate.Click += Calculate;
        result.SetBounds(20, 150, 470, 80);
        Controls.AddRange(new Control[]
            { prompt, priceBox, quantityBox, calculate, result });
    }
    void Calculate(object sender, EventArgs e)
    {
        try
        {
            decimal price = decimal.Parse(priceBox.Text,
                CultureInfo.InvariantCulture);
            int quantity = int.Parse(quantityBox.Text);
            if (price < 0 || quantity < 1)
            {
                result.Text = "Use a nonnegative price and positive quantity.";
                return;
            }
            decimal subtotal = price * quantity;
            decimal tax = subtotal * TaxRate;
            decimal total = Math.Round(subtotal + tax, 2);
            calculations++;
            result.Text = "Total: " + total.ToString("F2")
                + "\nCalculations: " + calculations;
        }
        catch (FormatException)
        {
            result.Text = "Enter a numeric price and whole-number quantity.";
        }
        catch (OverflowException)
        {
            result.Text = "The number is too large. Try smaller values.";
        }
    }
    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new PracticeForm());
    }
}