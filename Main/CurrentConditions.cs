using Accuweather.Core.Helpers;
using Accuweather.Core;
using System.Threading.Tasks;

namespace Accuweather.Current
{
	/// <summary>
	///	Accuweather Current Conditions Api
	/// </summary>
	public class CurrentConditions : AccuweatherApiCore, ICurrentConditions
	{
		private const string _baseUrl = "http://dataservice.accuweather.com/currentconditions/v1/";

		/// <summary>
		/// 
		/// </summary>
		/// <param name="apiKey">Api key accuweather.</param>
		/// <param name="language">Language.</param>
		/// <returns></returns>
		public CurrentConditions(string apiKey, string language = "en-us") : base(apiKey, language)
		{

		}
		
		public async Task<string> Get(int locationKey, bool details = false)
		{
			var obj = new
			{
				language = _language,
				details
			};
			var url = $"{_baseUrl}{locationKey}?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		public async Task<string> GetTopCities(int group)
		{
			var obj = new
			{
				language = _language
			};
			var url = $"{_baseUrl}topcities/{group}?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		public async Task<string> GetHistorical24Hours(int locationKey, bool details = false)
		{
			var obj = new
			{
				language = _language,
				details
			};
			var url = $"{_baseUrl}{locationKey}/historical/24?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		public async Task<string> GetHistorical6Hours(int locationKey, bool details = false)
		{
			var obj = new
			{
				language = _language,
				details
			};
			var url = $"{_baseUrl}{locationKey}/historical?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}
	}
}