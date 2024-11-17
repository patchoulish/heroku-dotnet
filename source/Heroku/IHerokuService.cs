using System;

using Heroku;
using Heroku.Dynos;
using Heroku.Spaces;
using Heroku.Stacks;
using Heroku.Regions;
using Heroku.Pipelines;
using Heroku.PipelineCouplings;

namespace Heroku
{
	/// <summary>
	/// 
	/// </summary>
	public interface IHerokuService
	{
		/// <summary>
		/// 
		/// </summary>
		public IHerokuDynoService Dynos { get; }

		/// <summary>
		/// 
		/// </summary>
		public IHerokuSpaceService Spaces { get; }

		/// <summary>
		/// 
		/// </summary>
		public IHerokuStackService Stacks { get; }

		/// <summary>
		/// 
		/// </summary>
		public IHerokuRegionService Regions { get; }

		/// <summary>
		/// 
		/// </summary>
		public IHerokuPipelineService Pipelines { get; }

		/// <summary>
		/// 
		/// </summary>
		public IHerokuPipelineCouplingService PipelineCouplings { get; }
	}
}
