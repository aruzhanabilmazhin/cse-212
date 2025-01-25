using System.Net.Http;
using System.Text.Json;

public class EarthquakeData
{
    public class Feature
    {
        public Properties properties { get; set; }
    }

    public class Properties
    {
        public string place { get; set; }
        public double mag { get; set; }
    }

    public class FeatureCollection
    {
        public List<Feature> features { get; set; }
    }

    public async Task<List<string>> EarthquakeDailySummary()
    {
        var client = new HttpClient();
        var response = await client.GetStringAsync("https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson");

        var data = JsonSerializer.Deserialize<FeatureCollection>(response);

        return data.features.Select(f => $"{f.properties.place} - Mag {f.properties.mag:F2}").ToList();
    }
}
