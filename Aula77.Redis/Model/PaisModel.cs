using Newtonsoft.Json;

namespace Aula77.Redis.Model
{
    public class PaisModel
    {
        //public string Name { get; set; }
        //public string Capital { get; set; }
        //public string Region { get; set; }
        //public string SubRegion { get; set; }

        [JsonProperty(propertyName: "name")]
        public string Nome{ get; set; }
        public string Capital { get; set; }

        [JsonProperty(propertyName: "Region")]
        public string Regiao{ get; set; }

        [JsonProperty(propertyName: "SubRegion")]
        public string SubRegiao { get; set; }
    }
}
