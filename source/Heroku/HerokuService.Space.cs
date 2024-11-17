using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

using Heroku;
using Heroku.Spaces;

namespace Heroku
{
	partial class HerokuService :
		IHerokuSpaceService
	{
		/// <inheritdoc/>
		public IHerokuSpaceService Spaces =>
			this;

		/// <inheritdoc/>
		async Task<ImmutableArray<HerokuSpace>> IHerokuSpaceService.GetAllAsync(
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<ImmutableArray<HerokuSpace>>(
					$"spaces",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuSpace> IHerokuSpaceService.GetAsync(
			Either<HerokuSpaceId, string> eitherIdOrName,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<HerokuSpace>(
					$"spaces/{eitherIdOrName}",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuSpace> IHerokuSpaceService.CreateAsync(
			HerokuSpaceCreateOptions options,
			CancellationToken cancellationToken)
		{
			Guard.NotNull(
				options,
				nameof(options));

			var httpClientResponse =
				await this.httpClient
					.PostAsJsonAsync(
						$"spaces",
						options,
						JsonSerializerOptions,
						cancellationToken);

			return await httpClientResponse.Content
				.ReadFromJsonAsync<HerokuSpace>(
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuSpace> IHerokuSpaceService.UpdateAsync(
			Either<HerokuSpaceId, string> eitherIdOrName,
			HerokuSpaceUpdateOptions options,
			CancellationToken cancellationToken)
		{
			Guard.NotNull(
				options,
				nameof(options));

			var httpClientResponse =
				await this.httpClient
					.PatchAsJsonAsync(
						$"spaces/{eitherIdOrName}",
						options,
						JsonSerializerOptions,
						cancellationToken);

			return await httpClientResponse.Content
				.ReadFromJsonAsync<HerokuSpace>(
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuSpace> IHerokuSpaceService.DeleteAsync(
			Either<HerokuSpaceId, string> eitherIdOrName,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.DeleteFromJsonAsync<HerokuSpace>(
					$"spaces/{eitherIdOrName}",
					JsonSerializerOptions,
					cancellationToken);
		}
	}
}
