using Newtonsoft.Json;

namespace Ivvy.API.Invoice
{
    public class ServiceDate
    {
        [JsonProperty("start")]
        public string Start
        {
            get; set;
        }

        [JsonProperty("end")]
        public string End
        {
            get; set;
        }
    }
}