using System;

namespace Heroku
{
	/// <summary>
	/// 
	/// </summary>
	[AttributeUsage(
		AttributeTargets.All,
		AllowMultiple = false,
		Inherited = true)]
	public class HerokuExperimentalAttribute :
		Attribute
	{
		/// <summary>
		/// 
		/// </summary>
		public HerokuExperimentalAttribute() :
			base()
		{ }
	}
}
