using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models;

public class ApiException
{
    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }
}
