using exam1.Models;
using System;
using System.Threading.Tasks;

namespace exam1
{
	class Program
	{
		static async Task Main(string[] args)
		{
			Console.Write("Enter city name: ");
			string city = Console.ReadLine();

			var apiKey = "b42f3d2f3ebbf01ee8b820985e550dc5"; 
			var service = new WeatherService(apiKey);

			try
			{
				Console.WriteLine("\n--- JSON FORMAT ---");
				var jsonWeather = (WeatherJsonModel) await service.GetWeatherJsonAsync(city, mode: "json");
				Console.WriteLine($"City: {jsonWeather.name}");
				Console.WriteLine($"Temperature: {jsonWeather.main.temp}");
				Console.WriteLine($"Description: {jsonWeather.weather?.FirstOrDefault()?.description}");

				Console.WriteLine("\n--- XML FORMAT ---");
				var jsonWeatherXML = (WeatherXmlModel) await service.GetWeatherJsonAsync(city, mode: "xml");
				Console.WriteLine($"City: {jsonWeatherXML.City.Name}");
				Console.WriteLine($"Temperature: {jsonWeatherXML.Temperature.Value}");
				Console.WriteLine($"Description: {jsonWeatherXML.Weather.Value}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}
	}
}
