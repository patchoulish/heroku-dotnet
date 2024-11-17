using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Immutable;

using Heroku;
using Heroku.Regions;

namespace Heroku
{
	partial class HerokuService :
		IHerokuRegionService
	{
		/// <inheritdoc/>
		public IHerokuRegionService Regions =>
			this;

		/// <inheritdoc/>
		async Task<ImmutableArray<HerokuRegion>> IHerokuRegionService.GetAllAsync(
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<ImmutableArray<HerokuRegion>>(
					$"regions",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <inheritdoc/>
		async Task<HerokuRegion> IHerokuRegionService.GetAsync(
			Either<HerokuRegionId, string> eitherIdOrName,
			CancellationToken cancellationToken)
		{
			return await this.httpClient
				.GetFromJsonAsync<HerokuRegion>(
					$"regions/{eitherIdOrName}",
					JsonSerializerOptions,
					cancellationToken);
		}
	}
}
