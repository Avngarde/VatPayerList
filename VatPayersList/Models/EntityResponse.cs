using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models;

public class EntityResponse
{
    [JsonPropertyName("result")]
    public EntityItem? Result { get; set; }
}
