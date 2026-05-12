using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models;

public class EntryList
{
    [JsonPropertyName("entries")]
    public List<object>? Entries { get; set; }

    [JsonPropertyName("requestDateTime")]
    public string? RequestDateTime { get; set; }

    [JsonPropertyName("requestId")]
    public string? RequestId { get; set; }
}
