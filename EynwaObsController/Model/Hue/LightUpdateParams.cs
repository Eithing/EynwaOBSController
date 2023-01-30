using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EynwaObsController.Model.Hue
{
    public class LightUpdateParams
    {
        [JsonProperty("on")]
        public bool On { get; set; }

        [JsonProperty("sat")]
        public int Sat { get; set; }

        [JsonProperty("bri")]
        public int Bri { get; set; }

        [JsonProperty("hue")]
        public int Hue { get; set; }
    }
}
