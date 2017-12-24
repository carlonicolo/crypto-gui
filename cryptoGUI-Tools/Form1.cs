using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptoGUI_Tools
{
    public partial class Form1 : Form
    {
        //Array string where to put selection checkbox values
        private List<string> lst_crypto = new List<string>();

        public Form1()
        {
            InitializeComponent();
            cmbCrypto.SelectedIndex = 0;
            cmbFiat.SelectedIndex = 0;
            textQuantity.Text = "0";
        }


        #region UI events

        private void cmdDeserialise2_Click(object sender, EventArgs e)
        {

            string url = @"https://api.coinmarketcap.com/v1/ticker/?convert=EUR";

            //Using System.Net
            var json = new WebClient().DownloadString(url);

            Console.WriteLine("This is the json variable content: " + json);
            deserialiseJSON(json);
        }

        private void cmdClear2_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;
        }

        /*
         * Button method for fetching json data from https://api.coinmarketcap.com
         * 
         * Inside this method we create the right URL for getting json data, putting as 
         * crypto the crypto selected in the combobox. In this way we will retrieve the 
         * corresponding json info related to the crypto value chosen in the combobox.
         * 
         * Example:
         * string selectedCrypto = cmbCrypto.SelectedItem.ToString(); // Bitcoin
         * string url = @"https://api.coinmarketcap.com/v1/ticker/" + selectedCrypto + "/?convert=EUR";
         * url= https://api.coinmarketcap.com/v1/ticker/Bitcoin/?convert=EUR
         * 
         */
        private void button6_Click(object sender, EventArgs e)
        {
            //lblResult.Text = cmbCrypto.SelectedItem.ToString();
            //float amountVal = (float)double.Parse(textQuantity.Text);

            //Console.WriteLine("Value of amountVal: " + amountVal);
            //Console.WriteLine("Type of amountVal: " + amountVal.GetType());

            string selectedCrypto = cmbCrypto.SelectedItem.ToString();
            string url = @"https://api.coinmarketcap.com/v1/ticker/" + selectedCrypto + "/?convert=EUR";

            //string url = @"https://api.coinmarketcap.com/v1/ticker/?convert=EUR";
        
            //Using System.Net
            var json = new WebClient().DownloadString(url);

            //This function make extract the value and make the computation
            exchange(json);

        }
        #endregion


        #region json functions

        private void deserialiseJSON(string strJSON)
        {
            try
            {
                //var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                //debugOutput("Here's our JSON Object " + jPerson.ToString());
                //debugOutput("Here's the id: " + jPerson[1].id);

                //
                var jCrypto = JsonConvert.DeserializeObject<List<jsonCrypto>>(strJSON);

                //debugOutput("Here's our JSON Object " + jCrypto.GetType());
                //debugOutput("This should be equals to bitcoin ---> " + jCrypto[0].id.ToString());
                //debugOutput("Here's the id: " + jCrypto.id);

                // 
                String s = "";
                jCrypto.ForEach(x => {
                    s += "*****************************\r\n";
                    s += "Name: " + x.name + "\r\n";
                    s += "Symbol: " + x.symbol + "\r\n";
                    s += "Rank: " + x.rank + "\r\n";
                    s += "€ price: " + x.price_eur + "\r\n";
                    s += "$ price " + x.price_usd + "\r\n";
                    s += "BTC price " + x.price_btc + "\r\n";
                    s += "% 1h " + x.percent_change_1h + "\r\n";
                    s += "% 24h " + x.percent_change_24h + "\r\n";
                    s += "% 7d " + x.percent_change_7d + "\r\n";
                    s += "*****************************\r\n";
                });

                Console.WriteLine(s);



                debugOutput(s);



            }
            catch (Exception ex)
            {
                debugOutput("We had a problem: " + ex.Message.ToString());
            }
        }

        #endregion




        #region Debug Output

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                txtDebugOutput.SelectionStart = txtDebugOutput.TextLength;
                txtDebugOutput.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }

        }

        #endregion


        #region button methods

        private void exchange(string strJSON)
        {
            var jCrypto = JsonConvert.DeserializeObject<List<jsonCrypto>>(strJSON);
            //debugOutput("This should be equals to the selected crypto ---> " + jCrypto[0].id.ToString());
            //debugOutput("This should be equals to the price_eur ---> " + jCrypto[0].price_eur);
            //debugOutput("This should be equals to the price_usd ---> " + jCrypto[0].price_usd);
            //debugOutput("This should be equqlas to the entire object jcrypto ---> " + jCrypto[0].ToString());

            float amountVal = (float)double.Parse(textQuantity.Text);

            float exchange_result_eur = amountVal * jCrypto[0].price_eur;
            float exchange_result_usd = amountVal * jCrypto[0].price_usd;
            Console.WriteLine("Value of exchange_result_eur: " + exchange_result_eur);
            Console.WriteLine("Value of exchange_result_usd: " + exchange_result_usd);
            lblResult.Text = String.Format("{0:€#,##0.0000;(€#,##0.0000);Zero}", exchange_result_eur);

            debugOutput(amountVal + " " + jCrypto[0].symbol.ToString() + " = " + exchange_result_eur);
        }




        /*
        * Button method for fetching json data of the top 10 crypto currency
        * from https://api.coinmarketcap.com
        * 
        */
        private void btnTopTen_Click(object sender, EventArgs e)
        {
            string url = @"https://api.coinmarketcap.com/v1/ticker/?limit=10";
            
            //Using System.Net
            var json = new WebClient().DownloadString(url);

            //This function make extract the value and make the computation
            deserialiseJSON(json);
        }







        #endregion

        #region checkbox controll



        #endregion

        private void checkBTC_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBTC.Checked)
            {
                lst_crypto.Add("Bitcoin");
                //Console.WriteLine("This is the state of checkBTC.CheckState: " + checkBTC.CheckState);
                Console.WriteLine("Value of lst_crypto: " + lst_crypto[0]);
            }
            else
            {
                Console.WriteLine("This is the state of checkBTC.CheckState: " + checkBTC.CheckState);
            }
        }
    }
}
