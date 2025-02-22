﻿using Newtonsoft.Json;

namespace EmmaSharper
{
    public class WebhookEvents
    {
        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("webhook_event_id")]
        public int? WebhookEventId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
