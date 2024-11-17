using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

using Heroku;
using Heroku.Apps;
using Heroku.Dynos;

namespace Heroku
{
	partial class HerokuService :
		IHerokuDynoService
	{
		/// <inheritdoc/>
		public IHerokuDynoService Dynos =>
			this;

		/// <inheritdoc/>
		async Task<ImmutableArray<HerokuDyno>> IHerokuDynoService.GetAllForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<ImmutableArray<HerokuDyno>>(
					$"apps/{eitherAppIdOrName}/dynos",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuDyno> IHerokuDynoService.GetForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			Either<HerokuDynoId, string> eitherIdOrName,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<HerokuDyno>(
					$"apps/{eitherAppIdOrName}/dynos/{eitherIdOrName}",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuDyno> IHerokuDynoService.CreateForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			HerokuDynoCreateOptions options,
			CancellationToken cancellationToken)
		{
			Guard.NotNull(
				options,
				nameof(options));

			var httpClientResponse =
				await this.httpClient
					.PostAsJsonAsync(
						$"apps/{eitherAppIdOrName}/dynos",
						options,
						JsonSerializerOptions,
						cancellationToken);

			return await httpClientResponse.Content
				.ReadFromJsonAsync<HerokuDyno>(
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task IHerokuDynoService.RestartAllForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			CancellationToken cancellationToken)
		{
			await this.httpClient
				.DeleteAsync(
					$"apps/{eitherAppIdOrName}/dynos",
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task IHerokuDynoService.RestartAllForAppWithTypeAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			string type,
			CancellationToken cancellationToken)
		{
			await this.httpClient
				.DeleteAsync(
					$"apps/{eitherAppIdOrName}/formations/{type}",
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task IHerokuDynoService.RestartForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			Either<HerokuDynoId, string> eitherIdOrName,
			CancellationToken cancellationToken)
		{
			await this.httpClient
				.DeleteAsync(
					$"apps/{eitherAppIdOrName}/dynos/{eitherIdOrName}",
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task IHerokuDynoService.StopAllForAppWithTypeAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			string type,
			CancellationToken cancellationToken)
		{
			await this.httpClient
				.PostAsync(
					$"apps/{eitherAppIdOrName}/formations/{type}/actions/stop",
					new StringContent(
						String.Empty,
						Encoding.UTF8),
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task IHerokuDynoService.StopForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			Either<HerokuDynoId, string> eitherIdOrName,
			CancellationToken cancellationToken)
		{
			await this.httpClient
				.PostAsync(
					$"apps/{eitherAppIdOrName}/dynos/{eitherIdOrName}/actions/stop",
					new StringContent(
						String.Empty,
						Encoding.UTF8),
					cancellationToken);
		}
	}
}
