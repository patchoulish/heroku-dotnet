using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

namespace Heroku.Regions
{
	/// <summary>
	/// 
	/// </summary>
	public interface IHerokuRegionService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<ImmutableArray<HerokuRegion>> GetAllAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuRegion> GetAsync(
			Either<HerokuRegionId, string> eitherIdOrName,
			CancellationToken cancellationToken = default);
	}
}
