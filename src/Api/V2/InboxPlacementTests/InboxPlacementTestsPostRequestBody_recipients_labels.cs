// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class InboxPlacementTestsPostRequestBody_recipients_labels : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Email Service Provider (ESP) to send emails to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Esp { get; set; }
#nullable restore
#else
        public string Esp { get; set; }
#endif
        /// <summary>The region to send emails to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region { get; set; }
#nullable restore
#else
        public string Region { get; set; }
#endif
        /// <summary>The sub-region to send emails to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubRegion { get; set; }
#nullable restore
#else
        public string SubRegion { get; set; }
#endif
        /// <summary>The type of email to send</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.InboxPlacementTestsPostRequestBody_recipients_labels"/> and sets the default values.
        /// </summary>
        public InboxPlacementTestsPostRequestBody_recipients_labels()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.InboxPlacementTestsPostRequestBody_recipients_labels"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.InboxPlacementTestsPostRequestBody_recipients_labels CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.InboxPlacementTestsPostRequestBody_recipients_labels();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "esp", n => { Esp = n.GetStringValue(); } },
                { "region", n => { Region = n.GetStringValue(); } },
                { "sub_region", n => { SubRegion = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("esp", Esp);
            writer.WriteStringValue("region", Region);
            writer.WriteStringValue("sub_region", SubRegion);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
