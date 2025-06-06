// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace YandexContestClient.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class FullRunReport : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The checkerLog property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::YandexContestClient.Client.Models.TestLog>? CheckerLog { get; set; }
#nullable restore
#else
        public List<global::YandexContestClient.Client.Models.TestLog> CheckerLog { get; set; }
#endif
        /// <summary>The compileLog property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompileLog { get; set; }
#nullable restore
#else
        public string CompileLog { get; set; }
#endif
        /// <summary>The compiler property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Compiler { get; set; }
#nullable restore
#else
        public string Compiler { get; set; }
#endif
        /// <summary>The contestId property</summary>
        public long? ContestId { get; set; }
        /// <summary>The contestName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContestName { get; set; }
#nullable restore
#else
        public string ContestName { get; set; }
#endif
        /// <summary>The diff property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Diff { get; set; }
#nullable restore
#else
        public string Diff { get; set; }
#endif
        /// <summary>The finalScore property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FinalScore { get; set; }
#nullable restore
#else
        public string FinalScore { get; set; }
#endif
        /// <summary>The globalError property</summary>
        public global::YandexContestClient.Client.Models.FullRunReport_globalError? GlobalError { get; set; }
        /// <summary>The ip property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ip { get; set; }
#nullable restore
#else
        public string Ip { get; set; }
#endif
        /// <summary>The maxMemoryUsage property</summary>
        public long? MaxMemoryUsage { get; set; }
        /// <summary>The maxTimeUsage property</summary>
        public long? MaxTimeUsage { get; set; }
        /// <summary>The participantInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::YandexContestClient.Client.Models.ParticipantInfo? ParticipantInfo { get; set; }
#nullable restore
#else
        public global::YandexContestClient.Client.Models.ParticipantInfo ParticipantInfo { get; set; }
#endif
        /// <summary>The precompileChecks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::YandexContestClient.Client.Models.AdditionalSolutionCheckResult>? PrecompileChecks { get; set; }
#nullable restore
#else
        public List<global::YandexContestClient.Client.Models.AdditionalSolutionCheckResult> PrecompileChecks { get; set; }
#endif
        /// <summary>The preliminaryScore property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreliminaryScore { get; set; }
#nullable restore
#else
        public string PreliminaryScore { get; set; }
#endif
        /// <summary>The problemAlias property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProblemAlias { get; set; }
#nullable restore
#else
        public string ProblemAlias { get; set; }
#endif
        /// <summary>The problemId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProblemId { get; set; }
#nullable restore
#else
        public string ProblemId { get; set; }
#endif
        /// <summary>The problemName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProblemName { get; set; }
#nullable restore
#else
        public string ProblemName { get; set; }
#endif
        /// <summary>The runId property</summary>
        public long? RunId { get; set; }
        /// <summary>The source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>The status property</summary>
        public global::YandexContestClient.Client.Models.FullRunReport_status? Status { get; set; }
        /// <summary>The submissionTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubmissionTime { get; set; }
#nullable restore
#else
        public string SubmissionTime { get; set; }
#endif
        /// <summary>The testFileType property</summary>
        public global::YandexContestClient.Client.Models.FullRunReport_testFileType? TestFileType { get; set; }
        /// <summary>The timeFromStart property</summary>
        public long? TimeFromStart { get; set; }
        /// <summary>The verdict property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Verdict { get; set; }
#nullable restore
#else
        public string Verdict { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::YandexContestClient.Client.Models.FullRunReport"/> and sets the default values.
        /// </summary>
        public FullRunReport()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::YandexContestClient.Client.Models.FullRunReport"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::YandexContestClient.Client.Models.FullRunReport CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::YandexContestClient.Client.Models.FullRunReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "checkerLog", n => { CheckerLog = n.GetCollectionOfObjectValues<global::YandexContestClient.Client.Models.TestLog>(global::YandexContestClient.Client.Models.TestLog.CreateFromDiscriminatorValue)?.AsList(); } },
                { "compileLog", n => { CompileLog = n.GetStringValue(); } },
                { "compiler", n => { Compiler = n.GetStringValue(); } },
                { "contestId", n => { ContestId = n.GetLongValue(); } },
                { "contestName", n => { ContestName = n.GetStringValue(); } },
                { "diff", n => { Diff = n.GetStringValue(); } },
                { "finalScore", n => { FinalScore = n.GetStringValue(); } },
                { "globalError", n => { GlobalError = n.GetEnumValue<global::YandexContestClient.Client.Models.FullRunReport_globalError>(); } },
                { "ip", n => { Ip = n.GetStringValue(); } },
                { "maxMemoryUsage", n => { MaxMemoryUsage = n.GetLongValue(); } },
                { "maxTimeUsage", n => { MaxTimeUsage = n.GetLongValue(); } },
                { "participantInfo", n => { ParticipantInfo = n.GetObjectValue<global::YandexContestClient.Client.Models.ParticipantInfo>(global::YandexContestClient.Client.Models.ParticipantInfo.CreateFromDiscriminatorValue); } },
                { "precompileChecks", n => { PrecompileChecks = n.GetCollectionOfObjectValues<global::YandexContestClient.Client.Models.AdditionalSolutionCheckResult>(global::YandexContestClient.Client.Models.AdditionalSolutionCheckResult.CreateFromDiscriminatorValue)?.AsList(); } },
                { "preliminaryScore", n => { PreliminaryScore = n.GetStringValue(); } },
                { "problemAlias", n => { ProblemAlias = n.GetStringValue(); } },
                { "problemId", n => { ProblemId = n.GetStringValue(); } },
                { "problemName", n => { ProblemName = n.GetStringValue(); } },
                { "runId", n => { RunId = n.GetLongValue(); } },
                { "source", n => { Source = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::YandexContestClient.Client.Models.FullRunReport_status>(); } },
                { "submissionTime", n => { SubmissionTime = n.GetStringValue(); } },
                { "testFileType", n => { TestFileType = n.GetEnumValue<global::YandexContestClient.Client.Models.FullRunReport_testFileType>(); } },
                { "timeFromStart", n => { TimeFromStart = n.GetLongValue(); } },
                { "verdict", n => { Verdict = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::YandexContestClient.Client.Models.TestLog>("checkerLog", CheckerLog);
            writer.WriteStringValue("compileLog", CompileLog);
            writer.WriteStringValue("compiler", Compiler);
            writer.WriteLongValue("contestId", ContestId);
            writer.WriteStringValue("contestName", ContestName);
            writer.WriteStringValue("diff", Diff);
            writer.WriteStringValue("finalScore", FinalScore);
            writer.WriteEnumValue<global::YandexContestClient.Client.Models.FullRunReport_globalError>("globalError", GlobalError);
            writer.WriteStringValue("ip", Ip);
            writer.WriteLongValue("maxMemoryUsage", MaxMemoryUsage);
            writer.WriteLongValue("maxTimeUsage", MaxTimeUsage);
            writer.WriteObjectValue<global::YandexContestClient.Client.Models.ParticipantInfo>("participantInfo", ParticipantInfo);
            writer.WriteCollectionOfObjectValues<global::YandexContestClient.Client.Models.AdditionalSolutionCheckResult>("precompileChecks", PrecompileChecks);
            writer.WriteStringValue("preliminaryScore", PreliminaryScore);
            writer.WriteStringValue("problemAlias", ProblemAlias);
            writer.WriteStringValue("problemId", ProblemId);
            writer.WriteStringValue("problemName", ProblemName);
            writer.WriteLongValue("runId", RunId);
            writer.WriteStringValue("source", Source);
            writer.WriteEnumValue<global::YandexContestClient.Client.Models.FullRunReport_status>("status", Status);
            writer.WriteStringValue("submissionTime", SubmissionTime);
            writer.WriteEnumValue<global::YandexContestClient.Client.Models.FullRunReport_testFileType>("testFileType", TestFileType);
            writer.WriteLongValue("timeFromStart", TimeFromStart);
            writer.WriteStringValue("verdict", Verdict);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
