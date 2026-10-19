using System;
using System.Drawing;
using System.Windows.Forms;

namespace FourAssignments
{
    internal static class Ui
    {
        public static void Title(Form f, string text)
        {
            f.BackColor = Color.WhiteSmoke;
            f.Controls.Add(new Label { Text = text, Font = new Font("Segoe UI", 16, FontStyle.Bold), AutoSize = true, Location = new Point(25, 20) });
        }
        public static void Label(Form f, string text, int x, int y) =>
            f.Controls.Add(new Label { Text = text, AutoSize = true, Location = new Point(x, y + 5), Font = new Font("Segoe UI", 10) });
        public static TextBox TextBox(Form f, int x, int y)
        {
            var t = new TextBox { Location = new Point(x, y), Size = new Size(230, 28), Font = new Font("Segoe UI", 10) };
            f.Controls.Add(t); return t;
        }
        public static ComboBox Combo(Form f, int x, int y, params string[] items)
        {
            var c = new ComboBox { Location = new Point(x, y), Size = new Size(230, 28), DropDownStyle = ComboBoxStyle.DropDownList };
            c.Items.AddRange(items); c.SelectedIndex = 0; f.Controls.Add(c); return c;
        }
        public static void Button(Form f, string text, int x, int y, Action action)
        {
            var b = new Button { Text = text, Location = new Point(x, y), Size = new Size(115, 34) };
            b.Click += (s, e) => action(); f.Controls.Add(b);
        }
        public static Label Result(Form f, int y)
        {
            var l = new Label { Location = new Point(30, y), Size = new Size(f.ClientSize.Width - 60, 160), Font = new Font("Consolas", 9.5f), ForeColor = Color.DarkGreen };
            f.Controls.Add(l); return l;
        }
        public static void Error(string message) => MessageBox.Show(message, "Input validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}