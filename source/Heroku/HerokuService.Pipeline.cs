using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

using Heroku;
using Heroku.Pipelines;

namespace Heroku
{
	partial class HerokuService :
		IHerokuPipelineService
	{
		/// <inheritdoc/>
		public IHerokuPipelineService Pipelines =>
			this;

		/// <inheritdoc/>
		async Task<ImmutableArray<HerokuPipeline>> IHerokuPipelineService.GetAllAsync(
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<ImmutableArray<HerokuPipeline>>(
					$"pipelines",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuPipeline> IHerokuPipelineService.GetAsync(
			Either<HerokuPipelineId, string> eitherIdOrName,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<HerokuPipeline>(
					$"pipelines/{eitherIdOrName}",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuPipeline> IHerokuPipelineService.CreateAsync(
			HerokuPipelineCreateOptions options,
			CancellationToken cancellationToken)
		{
			Guard.NotNull(
				options,
				nameof(options));

			var httpClientResponse =
				await this.httpClient
					.PostAsJsonAsync(
						$"pipelines",
						options,
						JsonSerializerOptions,
						cancellationToken);

			return await httpClientResponse.Content
				.ReadFromJsonAsync<HerokuPipeline>(
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuPipeline> IHerokuPipelineService.UpdateAsync(
			HerokuPipelineId id,
			HerokuPipelineUpdateOptions options,
			CancellationToken cancellationToken)
		{
			Guard.NotNull(
				options,
				nameof(options));

			var httpClientResponse =
				await this.httpClient
					.PatchAsJsonAsync(
						$"pipelines/{id}",
						options,
						JsonSerializerOptions,
						cancellationToken);

			return await httpClientResponse.Content
				.ReadFromJsonAsync<HerokuPipeline>(
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuPipeline> IHerokuPipelineService.DeleteAsync(
			HerokuPipelineId id,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.DeleteFromJsonAsync<HerokuPipeline>(
					$"pipelines/{id}",
					JsonSerializerOptions,
					cancellationToken);
		}
	}
}
