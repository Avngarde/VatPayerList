using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models;

public class EntryError
{
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("error")]
    public ApiException Error { get; set; }
}
