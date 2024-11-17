using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

using Heroku.Apps;
using Heroku.Teams;
using Heroku.Pipelines;
using Heroku.PipelineCouplings;
using System.Net.Http.Json;

namespace Heroku
{
	partial class HerokuService :
		IHerokuPipelineCouplingService
	{
		/// <inheritdoc/>
		public IHerokuPipelineCouplingService PipelineCouplings =>
			this;

		/// <inheritdoc/>
		async Task<ImmutableArray<HerokuPipelineCoupling>> IHerokuPipelineCouplingService.GetAllAsync(
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<ImmutableArray<HerokuPipelineCoupling>>(
					$"pipeline-couplings",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<ImmutableArray<HerokuPipelineCoupling>> IHerokuPipelineCouplingService.GetAllForPipelineAsync(
			HerokuPipelineId pipelineId,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<ImmutableArray<HerokuPipelineCoupling>>(
					$"pipelines/{pipelineId}/pipeline-couplings",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<ImmutableArray<HerokuPipelineCoupling>> IHerokuPipelineCouplingService.GetAllForCurrentUserAsync(
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<ImmutableArray<HerokuPipelineCoupling>>(
					$"users/~/pipeline-couplings",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<ImmutableArray<HerokuPipelineCoupling>> IHerokuPipelineCouplingService.GetAllForTeamAsync(
			Either<HerokuTeamId, string> eitherTeamIdOrName,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<ImmutableArray<HerokuPipelineCoupling>>(
					$"teams/{eitherTeamIdOrName}/pipeline-couplings",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuPipelineCoupling> IHerokuPipelineCouplingService.GetAsync(
			HerokuPipelineCouplingId id,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<HerokuPipelineCoupling>(
					$"pipeline-couplings/{id}",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuPipelineCoupling> IHerokuPipelineCouplingService.GetForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<HerokuPipelineCoupling>(
					$"apps/{eitherAppIdOrName}/pipeline-couplings",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuPipelineCoupling> IHerokuPipelineCouplingService.CreateAsync(
			HerokuPipelineCouplingCreateOptions options,
			CancellationToken cancellationToken)
		{
			Guard.NotNull(
				options,
				nameof(options));

			var httpClientResponse =
				await this.httpClient
					.PostAsJsonAsync(
						$"pipeline-couplings",
						options,
						JsonSerializerOptions,
						cancellationToken);

			return await httpClientResponse.Content
				.ReadFromJsonAsync<HerokuPipelineCoupling>(
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuPipelineCoupling> IHerokuPipelineCouplingService.UpdateAsync(
			HerokuPipelineCouplingId id,
			HerokuPipelineCouplingUpdateOptions options,
			CancellationToken cancellationToken)
		{
			Guard.NotNull(
				options,
				nameof(options));

			var httpClientResponse =
				await this.httpClient
					.PatchAsJsonAsync(
						$"pipeline-couplings/{id}",
						options,
						JsonSerializerOptions,
						cancellationToken);

			return await httpClientResponse.Content
				.ReadFromJsonAsync<HerokuPipelineCoupling>(
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuPipelineCoupling> IHerokuPipelineCouplingService.DeleteAsync(
			HerokuPipelineCouplingId id,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.DeleteFromJsonAsync<HerokuPipelineCoupling>(
					$"pipeline-couplings/{id}",
					JsonSerializerOptions,
					cancellationToken);
		}
	}
}
