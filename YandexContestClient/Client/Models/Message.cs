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
    public partial class Message : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The answers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Answers { get; set; }
#nullable restore
#else
        public List<string> Answers { get; set; }
#endif
        /// <summary>The problem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Problem { get; set; }
#nullable restore
#else
        public string Problem { get; set; }
#endif
        /// <summary>The question property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Question { get; set; }
#nullable restore
#else
        public string Question { get; set; }
#endif
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.Message"/> and sets the default values.
        /// </summary>
        public Message()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.Message"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.Message CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Texnokaktus.ProgOlymp.YandexContestClient.Client.Models.Message();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "answers", n => { Answers = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "problem", n => { Problem = n.GetStringValue(); } },
                { "question", n => { Question = n.GetStringValue(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("answers", Answers);
            writer.WriteStringValue("problem", Problem);
            writer.WriteStringValue("question", Question);
            writer.WriteStringValue("subject", Subject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
