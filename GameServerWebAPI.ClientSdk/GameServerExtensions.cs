// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace GameServerWebAPI.ClientSdk
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GameServer.
    /// </summary>
    public static partial class GameServerExtensions
    {
            /// <summary>
            /// Retrieve a list of online game servers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='limit'>
            /// Maximum number of servers to retrieve.
            /// </param>
            public static IList<GameServerInfo> Get(this IGameServer operations, int limit = 100)
            {
                return operations.GetAsync(limit).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of online game servers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='limit'>
            /// Maximum number of servers to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<GameServerInfo>> GetAsync(this IGameServer operations, int limit = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(limit, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
