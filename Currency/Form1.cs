using System;
using System.Windows.Forms;

namespace Currency
{
    public partial class Form1 : Form
    {
        double one;
        double ConvertedCurrency;
        double transactionFee;
        double subtotal;
        double totalCost;

        public Form1()
        {
            //Currencies list
            InitializeComponent();
            currencyfrom.Items.Add("British Pound (GBP)");
            currencyfrom.Items.Add("United States Dollar (USD)");
            currencyfrom.Items.Add("Euro (EUR)");
            currencyfrom.Items.Add("Australian Dollar (AUD)");
            currencyfrom.Items.Add("Japanese Yen");
        }

        //below: Original Currency Combo Box
        private void currencyfrom_SelectedIndexChanged(object sender, EventArgs e)

        {
            //If currencyfrom = Pound
            if (currencyfrom.Text == "British Pound (GBP)")
            {
                currencyto.Items.Clear();
                currencyto.Items.Add("United States Dollar (USD)");
                currencyto.Items.Add("Euro (EUR)");
                currencyto.Items.Add("Australian Dollar (AUD)");
                currencyto.Items.Add("Japanese Yen");
            }
            //if currecnyfrom = USD
            if (currencyfrom.Text == "United States Dollar (USD)")
            {
                currencyto.Items.Clear();
                currencyto.Items.Add("British Pound (GBP)");
                currencyto.Items.Add("Euro (EUR)");
                currencyto.Items.Add("Australian Dollar (AUD)");
                currencyto.Items.Add("Japanese Yen");
            }
            //If currencyfrom = EUR
            if (currencyfrom.Text == "Euro (EUR)")
            {
                currencyto.Items.Clear();
                currencyto.Items.Add("British Pound (GBP)");
                currencyto.Items.Add("United States Dollar (USD)");
                currencyto.Items.Add("Australian Dollar (AUD)");
                currencyto.Items.Add("Japanese Yen");
            }
            //If currencyfrom = AUD
            if (currencyfrom.Text == "Australian Dollar (AUD)")
            {
                currencyto.Items.Clear();
                currencyto.Items.Add("British Pound (GBP)");
                currencyto.Items.Add("United States Dollar (USD)");
                currencyto.Items.Add("Euro (EUR)");
                currencyto.Items.Add("Japanese Yen");
            }
            //If currencyfrom = Yen
            if (currencyfrom.Text == "Japanese Yen")
            {
                currencyto.Items.Clear();
                currencyto.Items.Add("British Pound (GBP)");
                currencyto.Items.Add("United States Dollar (USD)");
                currencyto.Items.Add("Euro (EUR)");
                currencyto.Items.Add("Australian Dollar (AUD)");
            }

        }

        private void OriginalCur_TextChanged(object sender, EventArgs e)
        {

        }

        private void DestiCur_TextChanged(object sender, EventArgs e)
        {

        }


        //Convert Button:
        private void convertbut_Click(object sender, EventArgs e)
        {

            double one = Convert.ToDouble(OriginalCur.Text);
            one = Math.Round(one, 2);

            if (one < 1)
            {
                MessageBox.Show(" Min conversion is 1");
                one = 0;
            }

            if (one > 2500)
            {
                MessageBox.Show("Maximum conversion is 2500");
                one = 0;
            }

            //if currency from is conversion calcs
            //From Pound:

            if (currencyfrom.Text == "British Pound (GBP)")
            {
                if (currencyto.Text == "United States Dollar (USD)")
                {
                    ConvertedCurrency = Math.Round(one * 1.28, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Euro (EUR)")
                {
                    ConvertedCurrency = Math.Round(one * 1.17, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Australian Dollar (AUD)")
                {
                    ConvertedCurrency = Math.Round(one * 1.89, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Japanese Yen")
                {
                    ConvertedCurrency = Math.Round(one * 139.51, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));

                }
            }
            //From American Dollar
            if (currencyfrom.Text == "United States Dollar (USD)")
            {
                if (currencyto.Text == "British Pound (GBP)")
                {
                    ConvertedCurrency = Math.Round(one * 0.78, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Euro (EUR)")
                {
                    ConvertedCurrency = Math.Round(one * 0.91, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Australian Dollar (AUD)")
                {
                    ConvertedCurrency = Math.Round(one * 1.48, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Japanese Yen")
                {
                    ConvertedCurrency = Math.Round(one * 108.64, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }
            }
            //From Euro
            if (currencyfrom.Text == "Euro (EUR)")
            {
                if (currencyto.Text == "British Pound (GBP)")
                {
                    ConvertedCurrency = Math.Round(one * 0.86, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "United States Dollar (USD)")
                {
                    ConvertedCurrency = Math.Round(one * 1.10, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Australian Dollar (AUD)")
                {
                    ConvertedCurrency = Math.Round(one * 1.62, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Japanese Yen")
                {
                    ConvertedCurrency = Math.Round(one * 119.44, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

            }
            //From AUD
            if (currencyfrom.Text == "Australian Dollar (AUD)")
            {
                if (currencyto.Text == "British Pound (GBP)")
                {
                    ConvertedCurrency = Math.Round(one * 0.53, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "United States Dollar (USD)")
                {
                    ConvertedCurrency = Math.Round(one * 0.86, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Euro (EUR)")
                {
                    ConvertedCurrency = Math.Round(one * 0.62, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Japanese Yen")
                {
                    ConvertedCurrency = Math.Round(one * 73.63, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

            }
            //From Yen
            if (currencyfrom.Text == "Japanese Yen")
            {
                if (currencyto.Text == "British Pound (GBP)")
                {
                    ConvertedCurrency = Math.Round(one * 0.0072, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "United States Dollar (USD)")
                {
                    ConvertedCurrency = Math.Round(one * 0.0082, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Euro (EUR)")
                {
                    ConvertedCurrency = Math.Round(one * 0.0084, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }

                if (currencyto.Text == "Australian Dollar (AUD)")
                {
                    ConvertedCurrency = Math.Round(one * 0.014, 2);
                    ConvertedCur.Text = Convert.ToString((ConvertedCurrency));
                }



            }

        }
    }
}




