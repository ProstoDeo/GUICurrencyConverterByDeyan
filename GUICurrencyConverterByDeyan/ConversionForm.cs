using System;
using System.Windows.Forms;

namespace GUICurrencyConverterByDeyan
{
    public partial class ConversionForm : Form
    {
        private readonly decimal[] conversionCoefficients = { 1.0m, 0.509795m, 0.55214m }; 

        public ConversionForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ConversionForm_KeyDown);

            comboBoxCurrency.Items.Add("BGN");
            comboBoxCurrency.Items.Add("EUR");
            comboBoxCurrency.Items.Add("USD");
            comboBoxCurrency.SelectedIndex = 0; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConvertCurrency(object sender, EventArgs e)
        {
            int selectedCurrencyIndex = comboBoxCurrency.SelectedIndex;
            decimal conversionCoefficient = conversionCoefficients[selectedCurrencyIndex];

            decimal amountBGN = numericUpDownAmount.Value;
            decimal amountCurrency = amountBGN * conversionCoefficient;

            string currencyCode = comboBoxCurrency.SelectedItem?.ToString() ?? string.Empty;
            if (!string.IsNullOrEmpty(currencyCode))
            {
                this.resultLabel.Text = $"{amountBGN} BGN = {amountCurrency:f2} {currencyCode}";
            }
        }

        private void ConversionForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConvertCurrency(sender, e);
            }
        }
        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
