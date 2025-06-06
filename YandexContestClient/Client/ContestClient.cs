// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using YandexContestClient.Client.Competitions;
using YandexContestClient.Client.Compilers;
using YandexContestClient.Client.Contests;
using YandexContestClient.Client.Groups;
using YandexContestClient.Client.Participants;
using YandexContestClient.Client.Problems;
using YandexContestClient.Client.Service;
using YandexContestClient.Client.Submissions;
using YandexContestClient.Client.Teams;
using YandexContestClient.Client.User;
namespace YandexContestClient.Client
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ContestClient : BaseRequestBuilder
    {
        /// <summary>The competitions property</summary>
        public global::YandexContestClient.Client.Competitions.CompetitionsRequestBuilder Competitions
        {
            get => new global::YandexContestClient.Client.Competitions.CompetitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The compilers property</summary>
        public global::YandexContestClient.Client.Compilers.CompilersRequestBuilder Compilers
        {
            get => new global::YandexContestClient.Client.Compilers.CompilersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contests property</summary>
        public global::YandexContestClient.Client.Contests.ContestsRequestBuilder Contests
        {
            get => new global::YandexContestClient.Client.Contests.ContestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groups property</summary>
        public global::YandexContestClient.Client.Groups.GroupsRequestBuilder Groups
        {
            get => new global::YandexContestClient.Client.Groups.GroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The participants property</summary>
        public global::YandexContestClient.Client.Participants.ParticipantsRequestBuilder Participants
        {
            get => new global::YandexContestClient.Client.Participants.ParticipantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The problems property</summary>
        public global::YandexContestClient.Client.Problems.ProblemsRequestBuilder Problems
        {
            get => new global::YandexContestClient.Client.Problems.ProblemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The service property</summary>
        public global::YandexContestClient.Client.Service.ServiceRequestBuilder Service
        {
            get => new global::YandexContestClient.Client.Service.ServiceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The submissions property</summary>
        public global::YandexContestClient.Client.Submissions.SubmissionsRequestBuilder Submissions
        {
            get => new global::YandexContestClient.Client.Submissions.SubmissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public global::YandexContestClient.Client.Teams.TeamsRequestBuilder Teams
        {
            get => new global::YandexContestClient.Client.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The user property</summary>
        public global::YandexContestClient.Client.User.UserRequestBuilder User
        {
            get => new global::YandexContestClient.Client.User.UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.ContestClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContestClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "https://api.contest.yandex.net/api/public/v2";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
#pragma warning restore CS0618
