// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Texnokaktus.ProgOlymp.YandexContestClient.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class BriefRunReport : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The authorId property</summary>
        public long? AuthorId { get; set; }
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
        /// <summary>The diff property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Diff { get; set; }
#nullable restore
#else
        public string Diff { get; set; }
#endif
        /// <summary>The maxMemoryUsage property</summary>
        public long? MaxMemoryUsage { get; set; }
        /// <summary>The maxTimeUsage property</summary>
        public long? MaxTimeUsage { get; set; }
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
        /// <summary>The runId property</summary>
        public long? RunId { get; set; }
        /// <summary>The score property</summary>
        public double? Score { get; set; }
        /// <summary>The source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>The submissionTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubmissionTime { get; set; }
#nullable restore
#else
        public string SubmissionTime { get; set; }
#endif
        /// <summary>The testNumber property</summary>
        public int? TestNumber { get; set; }
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
        /// Instantiates a new <see cref="global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.BriefRunReport"/> and sets the default values.
        /// </summary>
        public BriefRunReport()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.BriefRunReport"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.BriefRunReport CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.BriefRunReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "authorId", n => { AuthorId = n.GetLongValue(); } },
                { "compileLog", n => { CompileLog = n.GetStringValue(); } },
                { "compiler", n => { Compiler = n.GetStringValue(); } },
                { "diff", n => { Diff = n.GetStringValue(); } },
                { "maxMemoryUsage", n => { MaxMemoryUsage = n.GetLongValue(); } },
                { "maxTimeUsage", n => { MaxTimeUsage = n.GetLongValue(); } },
                { "problemAlias", n => { ProblemAlias = n.GetStringValue(); } },
                { "problemId", n => { ProblemId = n.GetStringValue(); } },
                { "runId", n => { RunId = n.GetLongValue(); } },
                { "score", n => { Score = n.GetDoubleValue(); } },
                { "source", n => { Source = n.GetStringValue(); } },
                { "submissionTime", n => { SubmissionTime = n.GetStringValue(); } },
                { "testNumber", n => { TestNumber = n.GetIntValue(); } },
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
            writer.WriteLongValue("authorId", AuthorId);
            writer.WriteStringValue("compileLog", CompileLog);
            writer.WriteStringValue("compiler", Compiler);
            writer.WriteStringValue("diff", Diff);
            writer.WriteLongValue("maxMemoryUsage", MaxMemoryUsage);
            writer.WriteLongValue("maxTimeUsage", MaxTimeUsage);
            writer.WriteStringValue("problemAlias", ProblemAlias);
            writer.WriteStringValue("problemId", ProblemId);
            writer.WriteLongValue("runId", RunId);
            writer.WriteDoubleValue("score", Score);
            writer.WriteStringValue("source", Source);
            writer.WriteStringValue("submissionTime", SubmissionTime);
            writer.WriteIntValue("testNumber", TestNumber);
            writer.WriteLongValue("timeFromStart", TimeFromStart);
            writer.WriteStringValue("verdict", Verdict);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
