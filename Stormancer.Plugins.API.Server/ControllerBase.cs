using Stormancer.Plugins;
using System.Threading.Tasks;

namespace Stormancer.Server.API
{
    public abstract class ControllerBase
    {
        public RequestContext<IScenePeerClient> Request { get; internal set; }

        /// <summary>
        /// Handles exceptions uncatched by the route itself.
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns>A task that returns true if the exception was handled, false otherwise.</returns>
        protected internal virtual Task<bool> HandleException(ApiExceptionContext ctx)
        {
            return Task.FromResult(false);
        }
    }
}
