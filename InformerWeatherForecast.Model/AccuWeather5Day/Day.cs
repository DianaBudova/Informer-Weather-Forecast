﻿using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather5Day;

public class Day
{
    [JsonPropertyName("Icon")]
    public int Icon { get; set; }

    [JsonPropertyName("IconPhrase")]
    public string IconPhrase { get; set; }

    [JsonPropertyName("HasPrecipitation")]
    public bool HasPrecipitation { get; set; }

    [JsonPropertyName("PrecipitationType")]
    public string PrecipitationType { get; set; }

    [JsonPropertyName("PrecipitationIntensity")]
    public string PrecipitationIntensity { get; set; }
}
