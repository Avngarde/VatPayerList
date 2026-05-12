using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models;

public class EntityItem
{
    [JsonPropertyName("subject")]
    public Entity? Subject { get; set; }

    [JsonPropertyName("requestDateTime")]
    public string? RequestDateTime { get; set; }

    [JsonPropertyName("requestId")]
    public string? RequestId { get; set; }
}
