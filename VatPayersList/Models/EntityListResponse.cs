using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models;

public class EntityListResponse
{
    [JsonPropertyName("result")]
    public EntityList? Result { get; set; }
}