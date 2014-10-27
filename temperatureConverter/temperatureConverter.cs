using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperatureConverter
{
    public partial class temperatureConverterForm : Form
    {
        RadioButton selectedRadioButton = null;


        public temperatureConverterForm()
        {
            InitializeComponent();
        }

        private void temperatureConverterForm_Load(object sender, EventArgs e)
        {
            temperatureTextBox.Select();
            temperatureTextBox.Focus();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            decimal temperatureDecimal = 0m;
            decimal temperatureConvertedDecimal = 0m;

            try
            {
                temperatureDecimal = decimal.Parse(temperatureTextBox.Text);

                if (!celsiusRadioButton.Checked && !fahrenheitRadioButton.Checked)
                {
                    MessageBox.Show("Either Celsius or Fahrenheit MUST be chosen", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                    switch (selectedRadioButton.Name)
                    {
                      case "celsiusRadioButton": temperatureConvertedDecimal = Decimal.Round((Decimal.Multiply(temperatureDecimal,1.8m)) + 32, 2);
                            temperatureInFahrenheitTextBox.Text = temperatureConvertedDecimal.ToString();
                           break;
                      case "fahrenheitRadioButton": temperatureConvertedDecimal = Decimal.Round(Decimal.Divide((temperatureDecimal - 32),1.8m), 2);
                           temperatureInCelsiusTextBox.Text = temperatureConvertedDecimal.ToString();
                            break;
                            Double.
                    }

                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Temperature value MUST be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult returnDialogResult;

            returnDialogResult = MessageBox.Show("Are you SURE you want to clear the results?", "Clear Results?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (returnDialogResult == DialogResult.Yes) { 
                // Reset all textboxes and radio buttons to default
                celsiusRadioButton.Checked = false;
                fahrenheitRadioButton.Checked = false;
                temperatureInFahrenheitTextBox.Clear();
                temperatureInCelsiusTextBox.Clear();
                temperatureTextBox.Clear();
                temperatureTextBox.Select();
                temperatureTextBox.Focus();
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the program
            this.Close();
        }

        private void changedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadioButton = (RadioButton)sender;
        }
    }
}
