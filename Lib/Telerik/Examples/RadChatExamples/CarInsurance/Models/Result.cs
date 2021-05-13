using Newtonsoft.Json;
using System;

namespace RadChatExamples.CarInsurance
{
    [JsonObject]
    public class Result
    {
        [JsonProperty("fulfillment")]
        public Fulfillment Fulfillment { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}