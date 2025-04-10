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
using YandexContestClient.Client.Contests.Item.Submissions.Item.Full;
using YandexContestClient.Client.Contests.Item.Submissions.Item.Item;
using YandexContestClient.Client.Contests.Item.Submissions.Item.Source;
using YandexContestClient.Client.Models;
namespace YandexContestClient.Client.Contests.Item.Submissions.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \contests\{contestId}\submissions\{submissionId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithSubmissionItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The full property</summary>
        public global::YandexContestClient.Client.Contests.Item.Submissions.Item.Full.FullRequestBuilder Full
        {
            get => new global::YandexContestClient.Client.Contests.Item.Submissions.Item.Full.FullRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The source property</summary>
        public global::YandexContestClient.Client.Contests.Item.Submissions.Item.Source.SourceRequestBuilder Source
        {
            get => new global::YandexContestClient.Client.Contests.Item.Submissions.Item.Source.SourceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the YandexContestClient.Client.contests.item.submissions.item.item collection</summary>
        /// <param name="position">testName</param>
        /// <returns>A <see cref="global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.WithTestNameItemRequestBuilder"/></returns>
        public global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.WithTestNameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("testName", position);
                return new global::YandexContestClient.Client.Contests.Item.Submissions.Item.Item.WithTestNameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Item.Submissions.Item.WithSubmissionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSubmissionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/{contestId}/submissions/{submissionId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Item.Submissions.Item.WithSubmissionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSubmissionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/{contestId}/submissions/{submissionId}", rawUrl)
        {
        }
        /// <summary>
        /// Required scope: &lt;code&gt;submit&lt;/code&gt; or &lt;code&gt;manage&lt;/code&gt;
        /// </summary>
        /// <returns>A <see cref="global::YandexContestClient.Client.Models.BriefRunReport"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::YandexContestClient.Client.Models.BriefRunReport?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::YandexContestClient.Client.Models.BriefRunReport> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::YandexContestClient.Client.Models.BriefRunReport>(requestInfo, global::YandexContestClient.Client.Models.BriefRunReport.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Required scope: &lt;code&gt;submit&lt;/code&gt; or &lt;code&gt;manage&lt;/code&gt;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::YandexContestClient.Client.Contests.Item.Submissions.Item.WithSubmissionItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::YandexContestClient.Client.Contests.Item.Submissions.Item.WithSubmissionItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::YandexContestClient.Client.Contests.Item.Submissions.Item.WithSubmissionItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
