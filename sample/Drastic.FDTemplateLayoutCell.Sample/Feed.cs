using System;
using System.Text.Json.Serialization;

namespace Drastic.FDTemplateLayoutCell.Sample
{
    public class Feed
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("imageName")]
        public string ImageName { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }

    }

    public class FeedModel
    {
        [JsonPropertyName("feed")]
        public Feed[] Feed { get; set; }
    }
}