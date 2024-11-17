using System;
using System.Collections.Immutable;
using System.Threading;
using System.Threading.Tasks;

using Heroku;
using Heroku.Apps;
using Heroku.Pipelines;
using Heroku.Teams;

namespace Heroku.PipelineCouplings
{
	/// <summary>
	/// 
	/// </summary>
	public interface IHerokuPipelineCouplingService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<ImmutableArray<HerokuPipelineCoupling>> GetAllAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="pipelineId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<ImmutableArray<HerokuPipelineCoupling>> GetAllForPipelineAsync(
			HerokuPipelineId pipelineId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<ImmutableArray<HerokuPipelineCoupling>> GetAllForCurrentUserAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherTeamIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<ImmutableArray<HerokuPipelineCoupling>> GetAllForTeamAsync(
			Either<HerokuTeamId, string> eitherTeamIdOrName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuPipelineCoupling> GetAsync(
			HerokuPipelineCouplingId id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherAppIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuPipelineCoupling> GetForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuPipelineCoupling> CreateAsync(
			HerokuPipelineCouplingCreateOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuPipelineCoupling> UpdateAsync(
			HerokuPipelineCouplingId id,
			HerokuPipelineCouplingUpdateOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuPipelineCoupling> DeleteAsync(
			HerokuPipelineCouplingId id,
			CancellationToken cancellationToken = default);
	}
}
