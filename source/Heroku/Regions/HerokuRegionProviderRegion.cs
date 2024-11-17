using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Regions
{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(
		typeof(JsonStringEnumConverter<HerokuRegionProviderRegion>))]
	public enum HerokuRegionProviderRegion
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"ap-south-1")]
		AsiaPacificSouth1,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"eu-west-1")]
		EuropeWest1,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"ap-southeast-1")]
		AsiaPacificSoutheast1,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"ap-southeast-2")]
		AsiaPacificSoutheast2,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"eu-central-1")]
		EuropeCentral1,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"eu-west-2")]
		EuropeWest2,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"ap-northeast-2")]
		AsiaPacificNortheast2,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"ap-northeast-1")]
		AsiaPacificNortheast1,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"us-east-1")]
		UnitedStatesEast1,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"sa-east-1")]
		SouthAmericaEast1,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"us-west-1")]
		UnitedStatesWest1,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"us-west-2")]
		UnitedStatesWest2,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"ca-central-1")]
		CanadaCentral1,
	}
}
