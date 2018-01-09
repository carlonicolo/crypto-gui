using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptoGUI_Tools
{
    public partial class Form1 : Form
    {
        //Array string where to put selection checkbox values
        private List<string> lst_crypto = new List<string>();

        //List of exchange result eur
        private List<double> lst_res_eur = new List<double>();

        //List of exchange result usd
        private List<double> lst_res_usd = new List<double>();

        public Form1()
        {
            InitializeComponent();
            cmbCrypto.SelectedIndex = 0;
            cmbFiat.SelectedIndex = 0;
            textQuantity.Text = "0,0";
        }


        #region UI events

        private void cmdDeserialise2_Click(object sender, EventArgs e)
        {

            string url = @"https://api.coinmarketcap.com/v1/ticker/?convert=EUR";

            //Using System.Net
            var json = new WebClient().DownloadString(url);

            Console.WriteLine("This is the json variable content: " + json);

            var jCrypto = JsonConvert.DeserializeObject<List<jsonCrypto>>(json);

            dataGridView1.DataSource = jCrypto;

            deserialiseJSON(json);
        }

        private void cmdClear2_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
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

            var regex = new Regex(@"^-*[0-9,\.]+$");
            bool isValid = regex.IsMatch(textQuantity.Text);

            if (!isValid)
            {
                string no_quantity = "Insert a numeric value formatted in this way 0,0";
                debugOutput(no_quantity);
            }
            else {

                if (checkSum.Checked)
                {
                    string selectedCrypto = cmbCrypto.SelectedItem.ToString();
                    string selectedFiat = cmbFiat.SelectedItem.ToString();
                    string url = @"https://api.coinmarketcap.com/v1/ticker/" + selectedCrypto + "/?convert=EUR";

                    //string url = @"https://api.coinmarketcap.com/v1/ticker/?convert=EUR";

                    //Using System.Net
                    var json = new WebClient().DownloadString(url);

                    //This function make extract the value and make the computation
                    exchange_sum(json, selectedFiat);
                }
                else
                {
                    string selectedCrypto = cmbCrypto.SelectedItem.ToString();
                    string selectedFiat = cmbFiat.SelectedItem.ToString();
                    string url = @"https://api.coinmarketcap.com/v1/ticker/" + selectedCrypto + "/?convert=EUR";

                    //string url = @"https://api.coinmarketcap.com/v1/ticker/?convert=EUR";

                    //Using System.Net
                    var json = new WebClient().DownloadString(url);

                    //This function make extract the value and make the computation
                    exchange(json, selectedFiat);
                }

            
            }

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
                jCrypto.ForEach(x =>
                {
                    s += "*****************************\r\n";
                    s += "Name: \t" + x.Name + "\r\n";
                    s += "Symbol: \t" + x.symbol + "\r\n";
                    s += "Rank: \t" + x.rank + "\r\n";
                    s += "€ price: \t" + x.price_eur + "\r\n";
                    s += "$ price \t" + x.price_usd + "\r\n";
                    s += "B price \t" + x.price_btc + "\r\n";
                    s += "% 1h \t" + x.percent_change_1h + "\r\n";
                    s += "% 24h \t" + x.percent_change_24h + "\r\n";
                    s += "% 7d \t" + x.percent_change_7d + "\r\n";
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

        private void deserialiseJSONtopten(string strJSON)
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
                jCrypto.ForEach(x =>
                {
                    s += "*****************************\r\n";
                    s += "Name: \t" + x.Name + "\r\n";
                    s += "Symbol: \t" + x.symbol + "\r\n";
                    s += "Rank: \t" + x.rank + "\r\n";
                    s += "€ price: \t" + x.price_eur + "\r\n";
                    s += "$ price \t" + x.price_usd + "\r\n";
                    s += "B price \t" + x.price_btc + "\r\n";
                    s += "% 1h \t" + x.percent_change_1h + "\r\n";
                    s += "% 24h \t" + x.percent_change_24h + "\r\n";
                    s += "% 7d \t" + x.percent_change_7d + "\r\n";
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

        private void exchange(string strJSON, string selecetedFiat)
        {
            var jCrypto = JsonConvert.DeserializeObject<List<jsonCrypto>>(strJSON);
            //debugOutput("This should be equals to the selected crypto ---> " + jCrypto[0].id.ToString());
            //debugOutput("This should be equals to the price_eur ---> " + jCrypto[0].price_eur);
            //debugOutput("This should be equals to the price_usd ---> " + jCrypto[0].price_usd);
            //debugOutput("This should be equqlas to the entire object jcrypto ---> " + jCrypto[0].ToString());

            float amountVal = (float)double.Parse(textQuantity.Text);

            if(selecetedFiat == "EUR")
            {
                float exchange_result_eur = amountVal * jCrypto[0].price_eur;
                Console.WriteLine("Value of exchange_result_eur: " + exchange_result_eur);
                lblResult.Text = String.Format("{0:€#,##0.0000;(€#,##0.0000);Zero}", exchange_result_eur);
                debugOutput(amountVal + " " + jCrypto[0].symbol.ToString() + " = €" + exchange_result_eur);
            }
            else
            {
                float exchange_result_usd = amountVal * jCrypto[0].price_usd;
                Console.WriteLine("Value of exchange_result_usd: " + exchange_result_usd);
                lblResult.Text = String.Format("{0:$#,##0.0000;($#,##0.0000);Zero}", exchange_result_usd);
                debugOutput(amountVal + " " + jCrypto[0].symbol.ToString() + " = $" + exchange_result_usd);
            }

            //float exchange_result_eur = amountVal * jCrypto[0].price_eur;
            //float exchange_result_usd = amountVal * jCrypto[0].price_usd;
            //Console.WriteLine("Value of exchange_result_eur: " + exchange_result_eur);
            //Console.WriteLine("Value of exchange_result_usd: " + exchange_result_usd);
            //lblResult.Text = String.Format("{0:€#,##0.0000;(€#,##0.0000);Zero}", exchange_result_eur);

            //debugOutput(amountVal + " " + jCrypto[0].symbol.ToString() + " = " + exchange_result_eur);
        }


        private void exchange_sum(string strJSON, string selecetedFiat)
        {
            var jCrypto = JsonConvert.DeserializeObject<List<jsonCrypto>>(strJSON);
            //debugOutput("This should be equals to the selected crypto ---> " + jCrypto[0].id.ToString());
            //debugOutput("This should be equals to the price_eur ---> " + jCrypto[0].price_eur);
            //debugOutput("This should be equals to the price_usd ---> " + jCrypto[0].price_usd);
            //debugOutput("This should be equqlas to the entire object jcrypto ---> " + jCrypto[0].ToString());

            double amountVal = double.Parse(textQuantity.Text);

            if (selecetedFiat == "EUR")
            {
                double exchange_result_eur = amountVal * jCrypto[0].price_eur;
                lst_res_eur.Add(exchange_result_eur);

                //Sum all values in the list
                double result_sum = lst_res_eur.Sum();
                

                Console.WriteLine("Value of exchange_result_eur: " + exchange_result_eur);

                //Value of exchange
                lblResult.Text = String.Format("{0:€#,##0.0000;(€#,##0.0000);Zero}", exchange_result_eur);
                lblSum.Text = String.Format("{0:€#,##0.0000;(€#,##0.0000);Zero}", result_sum);

                debugOutput(amountVal + " " + jCrypto[0].symbol.ToString() + " = €" + exchange_result_eur);
                debugOutput("Sum= €" + result_sum + "\r\n");
             
            }
            else
            {
                double exchange_result_usd = amountVal * jCrypto[0].price_usd;
                lst_res_usd.Add(exchange_result_usd);

                //Sum all values in the list
                double result_sum = lst_res_usd.Sum();

                Console.WriteLine("Value of exchange_result_usd: " + exchange_result_usd);

                //Value of exchange
                lblSum.Text = String.Format("{0:$#,##0.0000;(€#,##0.0000);Zero}", result_sum);
                lblResult.Text = String.Format("{0:$#,##0.0000;($#,##0.0000);Zero}", exchange_result_usd);

                debugOutput(amountVal + " " + jCrypto[0].symbol.ToString() + " = $" + exchange_result_usd);
                debugOutput("Sum= $" + result_sum + "\r\n");
            }

            //float exchange_result_eur = amountVal * jCrypto[0].price_eur;
            //float exchange_result_usd = amountVal * jCrypto[0].price_usd;
            //Console.WriteLine("Value of exchange_result_eur: " + exchange_result_eur);
            //Console.WriteLine("Value of exchange_result_usd: " + exchange_result_usd);
            //lblResult.Text = String.Format("{0:€#,##0.0000;(€#,##0.0000);Zero}", exchange_result_eur);

            //debugOutput(amountVal + " " + jCrypto[0].symbol.ToString() + " = " + exchange_result_eur);
        }



        /*
        * Button method for fetching json data of the top 10 crypto currency
        * from https://api.coinmarketcap.com
        * 
        */
        private void btnTopTen_Click(object sender, EventArgs e)
        {
            string url = @"https://api.coinmarketcap.com/v1/ticker/?convert=EUR&limit=10";
            
            //Using System.Net
            var json = new WebClient().DownloadString(url);

            var jCrypto = JsonConvert.DeserializeObject<List<jsonCrypto>>(json);

            dataGridView1.DataSource = jCrypto;

            //This function make extract the value and make the computation
            deserialiseJSONtopten(json);
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

        private void btnCheckBoxSelection_Click(object sender, EventArgs e)
        {
            List<string> crypto_checked = new List<string>();
            if (checkBTC.Checked)
            {
                crypto_checked.Add("bitcoin");
                //string url = @"https://api.coinmarketcap.com/v1/ticker/" + selectedCrypto + "/?convert=EUR";
            }
            if (checkXRP.Checked)
            {
                crypto_checked.Add("ripple");
            }
            if (checkADA.Checked)
            {
                crypto_checked.Add("cardano");
            }
            if (checkTRX.Checked)
            {
                crypto_checked.Add("tron");
            }
            if (checkXLM.Checked)
            {
                crypto_checked.Add("stellar");
            }
            if (checkETH.Checked)
            {
                crypto_checked.Add("ethereum");
            }
            if (checkXVG.Checked)
            {
                crypto_checked.Add("verge");
            }
            if (checkLTC.Checked)
            {
                crypto_checked.Add("litecoin");
            }
            if (checkMIOTA.Checked)
            {
                crypto_checked.Add("iota");
            }
            if (checkDASH.Checked)
            {
                crypto_checked.Add("dash");
            }
            if (checkXRM.Checked)
            {
                crypto_checked.Add("monero");
            }
            if (checkEOS.Checked)
            {
                crypto_checked.Add("eos");
            }
            if (checkBCC.Checked)
            {
                crypto_checked.Add("bitconnect");
            }
            if (checkZEC.Checked)
            {
                crypto_checked.Add("zcash");
            }
            if (checkXDG.Checked)
            {
                crypto_checked.Add("dogecoin");
            }
            if (crypto_checked != null && crypto_checked.Count != 0)
            {
                crypto_checked.ForEach(Print);
                crypto_checked.ForEach(x =>
                {
                    searchCrypto(x);
                });
            }
            else
            {
                string no_check_box_selected = "Please select one or more crypto currencies !";
                debugOutput(no_check_box_selected);
            }

        }


        private void searchCrypto(String x)
        {
            string url = @"https://api.coinmarketcap.com/v1/ticker/" + x + "/?convert=EUR";
            var json = new WebClient().DownloadString(url);

            var jCrypto = JsonConvert.DeserializeObject<List<jsonCrypto>>(json);


            deserialiseJSON(json);
        }


        private static void Print(string s)
        {
            Console.WriteLine(s);
        }

        private void checkSum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSum.Checked)
            {
                debugOutput("Sum tool selected ! Until this checkbox will be active, will be computed not only the exchange for the current value but also the sum with the previous. \r\n");
                lblSum.Visible = true;
                label2.Visible = true;
            }
            else
            {
                lst_res_eur.Clear();
                lst_res_usd.Clear();
                lblSum.Text = "";
                lblSum.Visible = false;
                label2.Visible = false;
            }
            
        }

        private void btnGridView_Click(object sender, EventArgs e)
        {
            string url = @"https://api.coinmarketcap.com/v1/ticker/?convert=EUR";

            //Using System.Net
            var json = new WebClient().DownloadString(url);

            Console.WriteLine("This is the json variable content: " + json);
            var jCrypto = JsonConvert.DeserializeObject<List<jsonCrypto>>(json);

            dataGridView1.DataSource = jCrypto;


        }




        //This method is used for avoiding users inserting non-numeric values
        //private void textQuantity_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}


    }
}
