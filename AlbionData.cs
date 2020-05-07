using System;
using System.Collections.Generic;

using System.Globalization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AlbionMT
{
    public  class AlbionData
    {
        public enum City
        {
            Caerleon,
            Thetford,
            FortSterling,
            Lymhurst,
            Bridgewatch,
            Martlock
        }

        public List<Models.Item> LoadItems()
        {
            using (StreamReader r = new StreamReader("data/items.json"))
            {
                string json = r.ReadToEnd();
                List<Models.Item> items = JsonConvert.DeserializeObject<List<Models.Item>>(json);
                return items;
            }
        }



        public class Models
        {
            public partial class Item
            {
                [JsonProperty("LocalizationNameVariable")]
                public string LocalizationNameVariable { get; set; }

                [JsonProperty("LocalizationDescriptionVariable")]
                public string LocalizationDescriptionVariable { get; set; }

                [JsonProperty("LocalizedNames")]
                public Localized LocalizedNames { get; set; }

                [JsonProperty("LocalizedDescriptions")]
                public Localized LocalizedDescriptions { get; set; }

                [JsonProperty("Index")]
                public long Index { get; set; }

                [JsonProperty("UniqueName")]
                public string UniqueName { get; set; }
            }

            public partial class Localized
            {
                [JsonProperty("EN-US")]
                public string EnUs { get; set; }

                [JsonProperty("DE-DE")]
                public string DeDe { get; set; }

                [JsonProperty("FR-FR")]
                public string FrFr { get; set; }

                [JsonProperty("RU-RU")]
                public string RuRu { get; set; }

                [JsonProperty("PL-PL")]
                public string PlPl { get; set; }

                [JsonProperty("ES-ES")]
                public string EsEs { get; set; }

                [JsonProperty("PT-BR")]
                public string PtBr { get; set; }

                [JsonProperty("ZH-CN")]
                public string ZhCn { get; set; }

                [JsonProperty("KO-KR")]
                public string KoKr { get; set; }
            }

            public partial class World
            {
                [JsonProperty("Index")]
                public string Index { get; set; }

                [JsonProperty("UniqueName")]
                public string UniqueName { get; set; }
            }
        }

    }
}
