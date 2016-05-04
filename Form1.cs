using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneNumberConversion
{
    public partial class Form1 : Form
    {
        private PhoneNumberConverter convert = new PhoneNumberConverter();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string convertedNumber;

            if (string.IsNullOrEmpty(txtNumberToConvert.Text))
            {
                MessageBox.Show("Please enter a phone number to convert");
            }
            else
            {
                try
                {
                    convertedNumber = convert.ConvertNumber(txtNumberToConvert.Text);
                    txtConvertedNumber.Text = convertedNumber;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message +
                                    "\nThe format can be either XXX-XXX-XXXX or (XXX)XXX-XXXX");
                }
            }
        }
    }
}