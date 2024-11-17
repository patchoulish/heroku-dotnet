using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

using Heroku;
using Heroku.Apps;
using Heroku.Stacks;

namespace Heroku
{
	partial class HerokuService :
		IHerokuStackService
	{
		/// <inheritdoc/>
		public IHerokuStackService Stacks =>
			this;

		/// <inheritdoc/>
		async Task<ImmutableArray<HerokuStack>> IHerokuStackService.GetAllAsync(
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<ImmutableArray<HerokuStack>>(
					$"stacks",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<ImmutableArray<HerokuStack>> IHerokuStackService.GetAllForAppAsync(
			Either<HerokuAppId, string> eitherAppIdOrName,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<ImmutableArray<HerokuStack>>(
					$"apps/{eitherAppIdOrName}/available-stacks",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuStack> IHerokuStackService.GetAsync(
			Either<HerokuStackId, string> eitherIdOrName,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<HerokuStack>(
					$"stacks/{eitherIdOrName}",
					JsonSerializerOptions,
					cancellationToken);
		}
	}
}
