using System;

using Microsoft;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Heroku
{
	/// <summary>
	/// 
	/// </summary>
	[TestClass]
	public sealed partial class HerokuServiceTests
	{
		private IHerokuService heroku;

		/// <summary>
		/// 
		/// </summary>
		[TestInitialize]
		public void Initialize()
		{
			this.heroku =
				new HerokuService(
					Environment.GetEnvironmentVariable(
						"HEROKU_API_KEY"));
		}
	}
}
