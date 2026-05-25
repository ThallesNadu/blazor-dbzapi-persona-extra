using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BlazorDbzApiPersonaExtra.Models;

public class Personagem
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("race")]
    public string? Race { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }
}