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

        //static async Task<Product> GetProductAsync(string path)
        //{
        //    Product product = null;
        //    HttpResponseMessage response = await httpClient.GetAsync(path);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        product = await response.Content.ReadAsAsync<Product>();
        //    }
        //    return product;
        //}

    }
}
