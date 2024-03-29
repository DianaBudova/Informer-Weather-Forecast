﻿using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeatherCity;

public class SupplementalAdminArea
{
    [JsonPropertyName("Level")]
    public int Level { get; set; }

    [JsonPropertyName("LocalizedName")]
    public string LocalizedName { get; set; }

    [JsonPropertyName("EnglishName")]
    public string EnglishName { get; set; }
}
