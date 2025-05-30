// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
using YandexContestClient.Client.Contests.Item.Standings.My;
using YandexContestClient.Client.Models;
namespace YandexContestClient.Client.Contests.Item.Standings
{
    /// <summary>
    /// Builds and executes requests for operations under \contests\{contestId}\standings
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class StandingsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The my property</summary>
        public global::YandexContestClient.Client.Contests.Item.Standings.My.MyRequestBuilder My
        {
            get => new global::YandexContestClient.Client.Contests.Item.Standings.My.MyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Item.Standings.StandingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StandingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/{contestId}/standings{?forJudge*,locale*,page*,pageSize*,participantSearch*,showExternal*,showVirtual*,userGroupId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Item.Standings.StandingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StandingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/{contestId}/standings{?forJudge*,locale*,page*,pageSize*,participantSearch*,showExternal*,showVirtual*,userGroupId*}", rawUrl)
        {
        }
        /// <summary>
        /// Required scope: &lt;code&gt;submit&lt;/code&gt; or &lt;code&gt;manage&lt;/code&gt;
        /// </summary>
        /// <returns>A <see cref="global::YandexContestClient.Client.Models.ContestStandings"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::YandexContestClient.Client.Models.ContestStandings?> GetAsync(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Standings.StandingsRequestBuilder.StandingsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::YandexContestClient.Client.Models.ContestStandings> GetAsync(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Standings.StandingsRequestBuilder.StandingsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::YandexContestClient.Client.Models.ContestStandings>(requestInfo, global::YandexContestClient.Client.Models.ContestStandings.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Required scope: &lt;code&gt;submit&lt;/code&gt; or &lt;code&gt;manage&lt;/code&gt;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Standings.StandingsRequestBuilder.StandingsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Standings.StandingsRequestBuilder.StandingsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::YandexContestClient.Client.Contests.Item.Standings.StandingsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::YandexContestClient.Client.Contests.Item.Standings.StandingsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::YandexContestClient.Client.Contests.Item.Standings.StandingsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Required scope: &lt;code&gt;submit&lt;/code&gt; or &lt;code&gt;manage&lt;/code&gt;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class StandingsRequestBuilderGetQueryParameters 
        {
            [QueryParameter("forJudge")]
            public bool? ForJudge { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("locale")]
            public string? Locale { get; set; }
#nullable restore
#else
            [QueryParameter("locale")]
            public string Locale { get; set; }
#endif
            [QueryParameter("page")]
            public int? Page { get; set; }
            [QueryParameter("pageSize")]
            public int? PageSize { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("participantSearch")]
            public string? ParticipantSearch { get; set; }
#nullable restore
#else
            [QueryParameter("participantSearch")]
            public string ParticipantSearch { get; set; }
#endif
            [QueryParameter("showExternal")]
            public bool? ShowExternal { get; set; }
            [QueryParameter("showVirtual")]
            public bool? ShowVirtual { get; set; }
            [QueryParameter("userGroupId")]
            public long? UserGroupId { get; set; }
        }
    }
}
#pragma warning restore CS0618
