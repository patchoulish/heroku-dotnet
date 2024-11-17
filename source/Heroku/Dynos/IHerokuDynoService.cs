using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

using Heroku;
using Heroku.Apps;

namespace Heroku.Dynos
{
	/// <summary>
	/// 
	/// </summary>
	public interface IHerokuDynoService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherAppIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<ImmutableArray<HerokuDyno>> GetAllForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherAppIdOrName"></param>
		/// <param name="eitherIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuDyno> GetForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			Either<HerokuDynoId, string> eitherIdOrName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherAppIdOrName"></param>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuDyno> CreateForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			HerokuDynoCreateOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherAppIdOrName"></param>
		/// <param name="eitherIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task RestartForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			Either<HerokuDynoId, string> eitherIdOrName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherAppIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task RestartAllForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherAppIdOrName"></param>
		/// <param name="type"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task RestartAllForAppWithTypeAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			string type,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherAppIdOrName"></param>
		/// <param name="eitherIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task StopForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			Either<HerokuDynoId, string> eitherIdOrName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherAppIdOrName"></param>
		/// <param name="type"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task StopAllForAppWithTypeAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			string type,
			CancellationToken cancellationToken = default);
	}
}
