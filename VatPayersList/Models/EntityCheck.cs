using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models;

public class EntityCheck
{
    [JsonPropertyName("accountAssigned")]
    public string? AccountAssigned { get; set; }

    [JsonPropertyName("requestDateTime")]
    public string? RequestDateTime { get; set; }

    [JsonPropertyName("requestId")]
    public string? RequestId { get; set; }
}
