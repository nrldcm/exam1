using System;
using System.Xml.Serialization;

namespace exam1.Models
{
	[XmlRoot("current")]
	public class WeatherXmlModel
	{
		[XmlElement("city")] public City City { get; set; }
		[XmlElement("temperature")] public Temperature Temperature { get; set; }
		[XmlElement("humidity")] public Humidity Humidity { get; set; }
		[XmlElement("pressure")] public Pressure Pressure { get; set; }
		[XmlElement("wind")] public WindXml Wind { get; set; }
		[XmlElement("clouds")] public CloudsXml Clouds { get; set; }
		[XmlElement("weather")] public WeatherXml Weather { get; set; }
	}

	public class City
	{
		[XmlAttribute("name")] public string Name { get; set; }
		[XmlElement("coord")] public CoordXml Coord { get; set; }
		[XmlElement("country")] public string Country { get; set; }
	}

	public class CoordXml
	{
		[XmlAttribute("lon")] public double Lon { get; set; }
		[XmlAttribute("lat")] public double Lat { get; set; }
	}

	public class Temperature
	{
		[XmlAttribute("value")] public double Value { get; set; }
		[XmlAttribute("min")] public double Min { get; set; }
		[XmlAttribute("max")] public double Max { get; set; }
	}

	public class Humidity
	{
		[XmlAttribute("value")] public int Value { get; set; }
		[XmlAttribute("unit")] public string Unit { get; set; }
	}

	public class Pressure
	{
		[XmlAttribute("value")] public int Value { get; set; }
		[XmlAttribute("unit")] public string Unit { get; set; }
	}

	public class WindXml
	{
		[XmlElement("speed")] public SpeedXml Speed { get; set; }
		[XmlElement("direction")] public DirectionXml Direction { get; set; }
	}

	public class SpeedXml
	{
		[XmlAttribute("value")] public double Value { get; set; }
		[XmlAttribute("name")] public string Name { get; set; }
	}

	public class DirectionXml
	{
		[XmlAttribute("value")] public int Value { get; set; }
		[XmlAttribute("code")] public string Code { get; set; }
		[XmlAttribute("name")] public string Name { get; set; }
	}

	public class CloudsXml
	{
		[XmlAttribute("value")] public int Value { get; set; }
		[XmlAttribute("name")] public string Name { get; set; }
	}

	public class WeatherXml
	{
		[XmlAttribute("value")] public string Value { get; set; }
		[XmlAttribute("icon")] public string Icon { get; set; }
	}
}
