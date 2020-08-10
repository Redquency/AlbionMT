using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AlbionMT
{
    public class AlbionOnlineDataProjectAPI
    {
        public const string apiUrl = "https://www.albion-online-data.com/api/v2/stats/";
        public static HttpClient httpClient;

        public AlbionOnlineDataProjectAPI()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(apiUrl);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private string ConstructRequestUrl(string item, int timeScale) => string.Format("{0}/history/{1}?{2}", apiUrl, item, timeScale);


        public async Task<List<ItemPrize>> GetItemPrizes(string itemId, int timeScale)
        {
            var items = new List<ItemPrize>();
            HttpResponseMessage response = await httpClient.GetAsync(ConstructRequestUrl(itemId, timeScale));
            if (response.IsSuccessStatusCode)
            {
                var dsd = await response.Content.ReadAsStreamAsync();
                dsd.
                var stringResponse = await response.Content.ReadAsStreamAsync();
                JsonTextReader reader = new JsonTextReader(System.IO.StreamReader);
                items = JsonSerializer.Deserialize<List<ItemPrize>>(stringResponse);
            }
            return items;
         
        }
        //await JsonSerializer.DeserializeAsync



        public class Datum
        {
            public int item_count { get; set; }
            public int avg_price { get; set; }
            public DateTime timestamp { get; set; }
        }

        public class ItemPrize
        {
            public string location { get; set; }
            public string item_id { get; set; }
            public int quality { get; set; }
            public List<Datum> data { get; set; }
        }

    }
}
