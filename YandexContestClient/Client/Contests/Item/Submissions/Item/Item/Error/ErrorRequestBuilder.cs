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
namespace YandexContestClient.Client.Contests.Item.Submissions.Item.Item.Error
{
    /// <summary>
    /// Builds and executes requests for operations under \contests\{contestId}\submissions\{submissionId}\{testName}\error
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ErrorRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.Error.ErrorRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ErrorRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/{contestId}/submissions/{submissionId}/{testName}/error{?useReportSettings*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.Error.ErrorRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ErrorRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/{contestId}/submissions/{submissionId}/{testName}/error{?useReportSettings*}", rawUrl)
        {
        }
        /// <summary>
        /// Required scope: &lt;code&gt;submit&lt;/code&gt; or &lt;code&gt;manage&lt;/code&gt;
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task GetAsync(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.Error.ErrorRequestBuilder.ErrorRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task GetAsync(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.Error.ErrorRequestBuilder.ErrorRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Required scope: &lt;code&gt;submit&lt;/code&gt; or &lt;code&gt;manage&lt;/code&gt;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.Error.ErrorRequestBuilder.ErrorRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.Error.ErrorRequestBuilder.ErrorRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.Error.ErrorRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.Error.ErrorRequestBuilder WithUrl(string rawUrl)
        {
            return new global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.Error.ErrorRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Required scope: &lt;code&gt;submit&lt;/code&gt; or &lt;code&gt;manage&lt;/code&gt;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ErrorRequestBuilderGetQueryParameters 
        {
            /// <summary>useReportSettings</summary>
            [QueryParameter("useReportSettings")]
            public bool? UseReportSettings { get; set; }
        }
    }
}
#pragma warning restore CS0618
