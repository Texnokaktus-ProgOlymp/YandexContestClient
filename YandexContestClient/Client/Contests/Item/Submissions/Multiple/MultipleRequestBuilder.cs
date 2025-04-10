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
using YandexContestClient.Client.Models;
namespace YandexContestClient.Client.Contests.Item.Submissions.Multiple
{
    /// <summary>
    /// Builds and executes requests for operations under \contests\{contestId}\submissions\multiple
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MultipleRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Item.Submissions.Multiple.MultipleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MultipleRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/{contestId}/submissions/multiple?runIds={runIds}{&locale*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Item.Submissions.Multiple.MultipleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MultipleRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/{contestId}/submissions/multiple?runIds={runIds}{&locale*}", rawUrl)
        {
        }
        /// <summary>
        /// Required scope: &lt;code&gt;submit&lt;/code&gt; or &lt;code&gt;manage&lt;/code&gt;
        /// </summary>
        /// <returns>A List&lt;global::YandexContestClient.Client.Models.MultiRunReport&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::YandexContestClient.Client.Models.MultiRunReport>?> GetAsync(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Submissions.Multiple.MultipleRequestBuilder.MultipleRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::YandexContestClient.Client.Models.MultiRunReport>> GetAsync(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Submissions.Multiple.MultipleRequestBuilder.MultipleRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::YandexContestClient.Client.Models.MultiRunReport>(requestInfo, global::YandexContestClient.Client.Models.MultiRunReport.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Required scope: &lt;code&gt;submit&lt;/code&gt; or &lt;code&gt;manage&lt;/code&gt;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Submissions.Multiple.MultipleRequestBuilder.MultipleRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Submissions.Multiple.MultipleRequestBuilder.MultipleRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::YandexContestClient.Client.Contests.Item.Submissions.Multiple.MultipleRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::YandexContestClient.Client.Contests.Item.Submissions.Multiple.MultipleRequestBuilder WithUrl(string rawUrl)
        {
            return new global::YandexContestClient.Client.Contests.Item.Submissions.Multiple.MultipleRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Required scope: &lt;code&gt;submit&lt;/code&gt; or &lt;code&gt;manage&lt;/code&gt;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MultipleRequestBuilderGetQueryParameters 
        {
            /// <summary>locale</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("locale")]
            public string? Locale { get; set; }
#nullable restore
#else
            [QueryParameter("locale")]
            public string Locale { get; set; }
#endif
            /// <summary>runIds</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("runIds")]
            public long?[]? RunIds { get; set; }
#nullable restore
#else
            [QueryParameter("runIds")]
            public long?[] RunIds { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
