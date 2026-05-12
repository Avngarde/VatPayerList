using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models;

public class EntityPerson
{
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }

    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }

    [JsonPropertyName("pesel")]
    public string? Pesel { get; set; }

    [JsonPropertyName("nip")]
    public string? Nip { get; set; }
}
