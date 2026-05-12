using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models;

public class EntityList
{
    [JsonPropertyName("subjects")]
    public List<Entity>? Subjects { get; set; }

    [JsonPropertyName("requestDateTime")]
    public string? RequestDateTime { get; set; }

    [JsonPropertyName("requestId")]
    public string? RequestId { get; set; }
}