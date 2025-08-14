using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using exam1.Models;

namespace exam1
{
	public class WeatherService
	{
		private readonly string _apiKey;
		private readonly HttpClient _httpClient;

		public WeatherService(string apiKey)
		{
			_apiKey = apiKey;
			_httpClient = new HttpClient();
		}

		public async Task<dynamic> GetWeatherJsonAsync(string city, string mode = "json")
		{
			try
			{
				var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&mode={mode}&appid={_apiKey}";
				var response = await _httpClient.GetStringAsync(url);
				if(mode == "json")
				{
					var weather = JsonSerializer.Deserialize<WeatherJsonModel>(response);
					return weather ?? throw new Exception("Failed to parse JSON weather data.");
				}
				else
				{
					var serializer = new XmlSerializer(typeof(WeatherXmlModel));
					using var reader = new System.IO.StringReader(response);
					var weather = (WeatherXmlModel)serializer.Deserialize(reader);
					return weather ?? throw new Exception("Failed to parse XML weather data.");
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

	}
}
