using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models;

public class EntryListResponse
{
    [JsonPropertyName("result")]
    public EntryList? Result { get; set; }
}
