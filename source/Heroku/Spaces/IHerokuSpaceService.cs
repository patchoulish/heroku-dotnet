using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

namespace Heroku.Spaces
{
	/// <summary>
	/// 
	/// </summary>
	public interface IHerokuSpaceService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<ImmutableArray<HerokuSpace>> GetAllAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuSpace> GetAsync(
			Either<HerokuSpaceId, string> eitherIdOrName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuSpace> CreateAsync(
			HerokuSpaceCreateOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherIdOrName"></param>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuSpace> UpdateAsync(
			Either<HerokuSpaceId, string> eitherIdOrName,
			HerokuSpaceUpdateOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuSpace> DeleteAsync(
			Either<HerokuSpaceId, string> eitherIdOrName,
			CancellationToken cancellationToken = default);
	}
}
