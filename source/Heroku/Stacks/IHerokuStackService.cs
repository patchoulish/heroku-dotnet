using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

using Heroku;
using Heroku.Apps;

namespace Heroku.Stacks
{
	/// <summary>
	/// 
	/// </summary>
	public interface IHerokuStackService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<ImmutableArray<HerokuStack>> GetAllAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherAppIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<ImmutableArray<HerokuStack>> GetAllForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuStack> GetAsync(
			Either<HerokuStackId, string> eitherIdOrName,
			CancellationToken cancellationToken = default);
	}
}
