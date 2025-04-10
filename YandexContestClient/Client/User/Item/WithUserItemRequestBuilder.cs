// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using YandexContestClient.Client.User.Item.GeneratePassword;
namespace YandexContestClient.Client.User.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \user\{userId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithUserItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The generatePassword property</summary>
        public global::YandexContestClient.Client.User.Item.GeneratePassword.GeneratePasswordRequestBuilder GeneratePassword
        {
            get => new global::YandexContestClient.Client.User.Item.GeneratePassword.GeneratePasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.User.Item.WithUserItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUserItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/{userId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.User.Item.WithUserItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUserItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/{userId}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
