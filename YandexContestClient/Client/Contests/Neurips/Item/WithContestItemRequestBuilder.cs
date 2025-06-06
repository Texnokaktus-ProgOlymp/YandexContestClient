// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using YandexContestClient.Client.Contests.Neurips.Item.Submissions;
namespace YandexContestClient.Client.Contests.Neurips.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \contests\neurips\{contestId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithContestItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The submissions property</summary>
        public global::YandexContestClient.Client.Contests.Neurips.Item.Submissions.SubmissionsRequestBuilder Submissions
        {
            get => new global::YandexContestClient.Client.Contests.Neurips.Item.Submissions.SubmissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Neurips.Item.WithContestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithContestItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/neurips/{contestId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Neurips.Item.WithContestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithContestItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/neurips/{contestId}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
