using System;
using System.Globalization;
using System.Windows.Forms;

namespace HelloWorldWindow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            var actualName = GetActualName(name);

            MessageBox.Show($"Hello, {actualName}!");
        }

        private string GetActualName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "OOOO";

            var actualName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

            return actualName;
        }


        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = nameTextBox.Text;
            this.Text = text;
        }
    }
}
