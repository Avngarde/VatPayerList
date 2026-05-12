using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models;

public class Entry
{
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    [JsonPropertyName("subjects")]
    public List<Entity>? Subjects { get; set; }
}
