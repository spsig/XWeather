﻿namespace XWeather.Domain
{
	public abstract class WuObject
	{
		public abstract string WuKey { get; }

		public WuObjectDetail response { get; set; }
	}


	public class WuObjectDetail
	{
		public string version { get; set; }
		public string termsofService { get; set; }
		public WuFeatures features { get; set; }
	}


	public class WuFeatures
	{
		public int almanac { get; set; }
		public int alerts { get; set; }
		public int astronomy { get; set; }
		public int conditions { get; set; }
		public int currenthurricane { get; set; }
		public int forecast { get; set; }
		public int forecast10day { get; set; }
		public int geolookup { get; set; }
		public int history { get; set; }
		public int hourly { get; set; }
		public int hourly10day { get; set; }
		public int planner { get; set; }
		public int rawtide { get; set; }
		public int satellite { get; set; }
		public int tide { get; set; }
		public int webcams { get; set; }
		public int yesterday { get; set; }
	}


	public class WuTxtDate
	{
		public string pretty { get; set; }
		public string year { get; set; }
		public string mon { get; set; }
		public string mday { get; set; }
		public string hour { get; set; }
		public string min { get; set; }
		public string tzname { get; set; }
		public string epoch { get; set; }
	}


	public class WuDate
	{
		public string epoch { get; set; }
		public string pretty { get; set; }
		public int day { get; set; }
		public int month { get; set; }
		public int year { get; set; }
		public int yday { get; set; }
		public int hour { get; set; }
		public string min { get; set; }
		public int sec { get; set; }
		public string isdst { get; set; }
		public string monthname { get; set; }
		public string monthname_short { get; set; }
		public string weekday_short { get; set; }
		public string weekday { get; set; }
		public string ampm { get; set; }
		public string tz_short { get; set; }
		public string tz_long { get; set; }
	}


	public class FCTTIME
	{
		public string hour { get; set; }
		public string hour_padded { get; set; }
		public string min { get; set; }
		public string min_unpadded { get; set; }
		public string sec { get; set; }
		public string year { get; set; }
		public string mon { get; set; }
		public string mon_padded { get; set; }
		public string mon_abbrev { get; set; }
		public string mday { get; set; }
		public string mday_padded { get; set; }
		public string yday { get; set; }
		public string isdst { get; set; }
		public string epoch { get; set; }
		public string pretty { get; set; }
		public string civil { get; set; }
		public string month_name { get; set; }
		public string month_name_abbrev { get; set; }
		public string weekday_name { get; set; }
		public string weekday_name_night { get; set; }
		public string weekday_name_abbrev { get; set; }
		public string weekday_name_unlang { get; set; }
		public string weekday_name_night_unlang { get; set; }
		public string ampm { get; set; }
		public string tz { get; set; }
		public string age { get; set; }
		public string UTCDATE { get; set; }
	}


	public class WuImage
	{
		public string url { get; set; }
		public string title { get; set; }
		public string link { get; set; }
	}


	public class WuLocation
	{
		public string city { get; set; }
		public string state { get; set; }
		public string country { get; set; }
		public string country_iso3166 { get; set; }

		public string lat { get; set; }
		public string lon { get; set; }

		public string latitude { get; set; }
		public string longitude { get; set; }

		public double Latitude => double.Parse (lat ?? latitude ?? "0");
		public double Longitude => double.Parse (lon ?? longitude ?? "0");
	}


	public class Temperature
	{
		public string fahrenheit { get; set; }
		public string celsius { get; set; }

		public string F { get; set; }
		public string C { get; set; }

		public string Fahrenheit => fahrenheit ?? F;
		public string Celsius => celsius ?? C;
	}


	public class Measurement
	{
		public string english { get; set; }
		public string metric { get; set; }
	}


	public class Precipitation
	{
		public double @in { get; set; }
		public double cm { get; set; }
		public int mm { get; set; }
	}


	public class Wind
	{
		public int mph { get; set; }
		public int kph { get; set; }
		public string dir { get; set; }
		public int degrees { get; set; }
	}
}