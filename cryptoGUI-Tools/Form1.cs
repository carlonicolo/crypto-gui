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
        public Form1()
        {
            InitializeComponent();
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

                debugOutput("Here's our JSON Object " + jCrypto.GetType());
                debugOutput("This should be equals to bitcoin ---> " + jCrypto[0].id.ToString());
                //debugOutput("Here's the id: " + jCrypto.id);


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

        private void button6_Click(object sender, EventArgs e)
        {
            lblResult.Text = cmbCrypto.SelectedItem.ToString();
            float amountVal = (float)double.Parse(textQuantity.Text);
            Console.WriteLine("Value of amountVal: " + amountVal);
            Console.WriteLine("Type of amountVal: " + amountVal.GetType());
            //string url = @"https://api.coinmarketcap.com/v1/ticker/?convert=EUR";

            ////Using System.Net
            //var json = new WebClient().DownloadString(url);

            //Console.WriteLine("This is the json variable content: " + json);
            //deserialiseJSON(json);
        }
    }
}
