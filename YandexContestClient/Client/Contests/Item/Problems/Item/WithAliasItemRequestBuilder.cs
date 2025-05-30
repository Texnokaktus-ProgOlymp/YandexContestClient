// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using YandexContestClient.Client.Contests.Item.Problems.Item.Statement;
namespace YandexContestClient.Client.Contests.Item.Problems.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \contests\{contestId}\problems\{alias}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithAliasItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The statement property</summary>
        public global::YandexContestClient.Client.Contests.Item.Problems.Item.Statement.StatementRequestBuilder Statement
        {
            get => new global::YandexContestClient.Client.Contests.Item.Problems.Item.Statement.StatementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Item.Problems.Item.WithAliasItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAliasItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/{contestId}/problems/{alias}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Contests.Item.Problems.Item.WithAliasItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAliasItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/contests/{contestId}/problems/{alias}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
