using System;
using System.Text.Json.Serialization;

namespace VatPayersList.Models
{
    public enum VatStatus
    {
        Czynny,
        Zwolniony,
        Niezarejestrowany
    }

    public class Entity
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nip")]
        public string? Nip { get; set; }

        [JsonPropertyName("statusVat")]
        public VatStatus? StatusVat { get; set; }

        [JsonPropertyName("regon")]
        public string? Regon { get; set; }

        [JsonPropertyName("pesel")]
        public string? Pesel { get; set; }

        [JsonPropertyName("krs")]
        public string? Krs { get; set; }

        [JsonPropertyName("residenceAddress")]
        public string? ResidenceAddress { get; set; }

        [JsonPropertyName("workingAddress")]
        public string? WorkingAddress { get; set; }

        [JsonPropertyName("representatives")]
        public List<EntityPerson>? Representatives { get; set; }

        [JsonPropertyName("authorizedClerks")]
        public List<EntityPerson>? AuthorizedClerks { get; set; }

        [JsonPropertyName("partners")]
        public List<EntityPerson>? Partners { get; set; }

        [JsonPropertyName("registrationLegalDate")]
        public DateTime? RegistrationLegalDate { get; set; }

        [JsonPropertyName("registrationDenialDate")]
        public DateTime? RegistrationDenialDate { get; set; }

        [JsonPropertyName("registrationDenialBasis")]
        public string? RegistrationDenialBasis { get; set; }

        [JsonPropertyName("restorationDate")]
        public DateTime? RestorationDate { get; set; }

        [JsonPropertyName("restorationBasis")]
        public string? RestorationBasis { get; set; }

        [JsonPropertyName("removalDate")]
        public DateTime? RemovalDate { get; set; }

        [JsonPropertyName("exemptionSmeDate")]
        public DateTime? ExemptionSmeDate { get; set; }

        [JsonPropertyName("removalBasis")]
        public string? RemovalBasis { get; set; }

        [JsonPropertyName("accountNumbers")]
        public List<string>? AccountNumbers { get; set; }

        [JsonPropertyName("hasVirtualAccounts")]
        public bool? HasVirtualAccounts { get; set; }
    }
}