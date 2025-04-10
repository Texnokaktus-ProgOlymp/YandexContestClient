// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using Texnokaktus.ProgOlymp.YandexContestClient.Client.Participants.Item.Stats;
namespace Texnokaktus.ProgOlymp.YandexContestClient.Client.Participants.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \participants\{participantId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithParticipantItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The stats property</summary>
        public global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Participants.Item.Stats.StatsRequestBuilder Stats
        {
            get => new global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Participants.Item.Stats.StatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Participants.Item.WithParticipantItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithParticipantItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/participants/{participantId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Participants.Item.WithParticipantItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithParticipantItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/participants/{participantId}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
