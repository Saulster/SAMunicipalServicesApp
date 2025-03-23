using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class LocationSuggestion
{
    public string DisplayName { get; set; } // Full address
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}

public static class LocationSuggestionHelper
{
    private const string OpenCageApiKey = "30bce2ee14364f99b78f367dde3bcd39";

    public static async Task<List<LocationSuggestion>> GetLocationSuggestionsAsync(string query)
    {
        var suggestions = new List<LocationSuggestion>();

        if (string.IsNullOrEmpty(query)) return suggestions;

        string apiUrl = $"https://api.opencagedata.com/geocode/v1/json?q={Uri.EscapeDataString(query)}&key={OpenCageApiKey}&limit=5";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic json = JsonConvert.DeserializeObject(responseBody);

                foreach (var result in json.results)
                {
                    suggestions.Add(new LocationSuggestion
                    {
                        DisplayName = result.formatted,
                        Latitude = result.geometry.lat,
                        Longitude = result.geometry.lng
                    });
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., network issues)
                Console.WriteLine($"Error fetching location suggestions: {ex.Message}");
            }
        }

        return suggestions;
    }
}
