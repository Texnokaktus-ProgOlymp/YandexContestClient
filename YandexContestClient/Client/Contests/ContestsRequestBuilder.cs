// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using YandexContestClient.Client.Contests.Item;
using YandexContestClient.Client.Contests.Neurips;
namespace YandexContestClient.Client.Contests
{
    /// <summary>
    /// Builds and executes requests for operations under \contests
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ContestsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The neurips property</summary>
        public global::YandexContestClient.Client.Contests.Neurips.NeuripsRequestBuilder Neurips
        {
            get => new global::YandexContestClient.Client.Contests.Neurips.NeuripsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the YandexContestClient.Client.contests.item collection</summary>
        /// <param name="position">contestId</param>
        /// <returns>A <see cref="global::YandexContestClient.Client.Contests.Item.WithContestItemRequestBuilder"/></returns>
        public global::YandexContestClient.Client.Contests.Item.WithContestItemRequestBuilder this[long position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("contestId", position);
                return new global::YandexContestClient.Client.Contests.Item.WithContestItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.ContestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContestsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.ContestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContestsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
