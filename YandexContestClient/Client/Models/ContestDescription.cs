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
    public partial class ContestDescription : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contestSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestReportSettings? ContestSettings { get; set; }
#nullable restore
#else
        public global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestReportSettings ContestSettings { get; set; }
#endif
        /// <summary>Contest duration, in seconds</summary>
        public long? Duration { get; set; }
        /// <summary>Contest freeze time, in seconds from start</summary>
        public long? FreezeTime { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Contest start time, UTC</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartTime { get; set; }
#nullable restore
#else
        public string StartTime { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestDescription_type? Type { get; set; }
        /// <summary>Upsolving settings - `ALLOWED_AFTER_PARTICIPATION_ENDS` — participant can upsolve after their participation ends - `ALLOWED_AFTER_CONTEST_ENDS` — participant can upsolve after contest is finished for everyone - `PROHIBITED` — participant can not upsolve</summary>
        public global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestDescription_upsolvingAllowance? UpsolvingAllowance { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestDescription"/> and sets the default values.
        /// </summary>
        public ContestDescription()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestDescription"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestDescription CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestDescription();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "contestSettings", n => { ContestSettings = n.GetObjectValue<global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestReportSettings>(global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestReportSettings.CreateFromDiscriminatorValue); } },
                { "duration", n => { Duration = n.GetLongValue(); } },
                { "freezeTime", n => { FreezeTime = n.GetLongValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "startTime", n => { StartTime = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestDescription_type>(); } },
                { "upsolvingAllowance", n => { UpsolvingAllowance = n.GetEnumValue<global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestDescription_upsolvingAllowance>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestReportSettings>("contestSettings", ContestSettings);
            writer.WriteLongValue("duration", Duration);
            writer.WriteLongValue("freezeTime", FreezeTime);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("startTime", StartTime);
            writer.WriteEnumValue<global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestDescription_type>("type", Type);
            writer.WriteEnumValue<global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.ContestDescription_upsolvingAllowance>("upsolvingAllowance", UpsolvingAllowance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
