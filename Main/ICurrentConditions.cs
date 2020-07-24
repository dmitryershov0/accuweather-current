using System.Threading.Tasks;

namespace Accuweather.Current
{
	/// <summary>
	/// Get Current Conditions data for a specific location.
	/// </summary>
	public interface ICurrentConditions
	{
		/// <summary>
		/// Returns current conditions data for a specific location. Current conditions searches require a location key. Please use the Locations API to obtain the location key for your desired location.
		///  By default, a truncated version of the current conditions data is returned. The full object can be obtained by passing "details=true" into the url string.
		/// </summary>
		/// <param name="locationKey">Unique ID to search for a specific location.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns></returns>
		Task<string> Get(int locationKey, bool details = false);

		/// <summary>
		/// Returns current conditions data for the top 50, 100, or 150 cities worldwide, based on rank.
		/// </summary>
		/// <param name="group">Integer that indicates the number to return with the request. Current supported values are 50, 100 and 150.</param>
		/// <returns></returns>
		Task<string> GetTopCities(int group);

		/// <summary>
		/// Returns historical current conditions data for a specific location. Current conditions searches require a location key. Please use the Locations API to obtain the location key for your desired location. 
		/// </summary>
		/// <param name="locationKey">Unique ID to search for a specific location.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns></returns>
		Task<string> GetHistorical24Hours(int locationKey, bool details = false);

		/// <summary>
		/// Returns historical current conditions data for a specific location. Current conditions searches require a location key. Please use the Locations API to obtain the location key for your desired location. 
		/// </summary>
		/// <param name="locationKey">Unique ID to search for a specific location.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns></returns>
		Task<string> GetHistorical6Hours(int locationKey, bool details = false);
	}
}
