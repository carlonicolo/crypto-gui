using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 [
    {
        "id": "bitcoin", 
        "name": "Bitcoin", 
        "symbol": "BTC", 
        "rank": "1", 
        "price_usd": "15310.7", 
        "price_btc": "1.0", 
        "24h_volume_usd": "15258300000.0", 
        "market_cap_usd": "256590673958", 
        "available_supply": "16758912.0", 
        "total_supply": "16758912.0", 
        "max_supply": "21000000.0", 
        "percent_change_1h": "1.52", 
        "percent_change_24h": "17.21", 
        "percent_change_7d": "-18.86", 
        "last_updated": "1514049555", 
        "price_eur": "12911.7123491", 
        "24h_volume_eur": "12867522747.9", 
        "market_cap_eur": "216386251028"
    }
]
 */

namespace cryptoGUI_Tools
{
    class jsonCrypto
    {
        public string id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public int rank { get; set; }
        public float price_usd { get; set; }
        public float price_btc { get; set; }

        [JsonProperty("24h_volume_usd")]
        public float volume_usd { get; set; }
        public float market_cap_usd { get; set; }
        public float available_supply { get; set; }
        public float total_supply { get; set; } 
        public string max_supply { get; set; } 
        public float percent_change_1h { get; set; }
        public float percent_change_24h { get; set; } 
        public string percent_change_7d { get; set; } 
        public float last_updated { get; set; } 
        public float price_eur { get; set; }

        [JsonProperty("24h_volume_eur")]
        public float volume_eur { get; set; } 
        public float market_cap_eur { get; set; }
        

    }
}
