using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using Heroku;
using Heroku.Accounts;

namespace Heroku.Pipelines
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuAccountPipelineOwner :
		HerokuPipelineOwner
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"id")]
		public HerokuAccountId Id { get; init; }

		/// <summary>
		/// 
		/// </summary>
		public HerokuAccountPipelineOwner() :
			base()
		{
			Type = HerokuPipelineOwnerType.Account;
		}
	}
}
