using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

namespace Heroku.Pipelines
{
	/// <summary>
	/// 
	/// </summary>
	public interface IHerokuPipelineService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<ImmutableArray<HerokuPipeline>> GetAllAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eitherIdOrName"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuPipeline> GetAsync(
			Either<HerokuPipelineId, string> eitherIdOrName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuPipeline> CreateAsync(
			HerokuPipelineCreateOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuPipeline> UpdateAsync(
			HerokuPipelineId id,
			HerokuPipelineUpdateOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<HerokuPipeline> DeleteAsync(
			HerokuPipelineId id,
			CancellationToken cancellationToken = default);
	}
}
