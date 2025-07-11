// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Instantly.OpenApiClient.Models
{
    /// <summary>
    /// Account Campaign Mapping
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Def10 : IParsable
    {
        /// <summary>The campaign_id property</summary>
        public Guid? CampaignId { get; set; }
        /// <summary>The campaign_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CampaignName { get; set; }
#nullable restore
#else
        public string CampaignName { get; set; }
#endif
        /// <summary>Campaign Status</summary>
        public double? Status { get; set; }
        /// <summary>Timestamp when the campaign was created</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimestampCreated { get; private set; }
#nullable restore
#else
        public string TimestampCreated { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Models.Def10"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Instantly.OpenApiClient.Models.Def10 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Instantly.OpenApiClient.Models.Def10();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "campaign_id", n => { CampaignId = n.GetGuidValue(); } },
                { "campaign_name", n => { CampaignName = n.GetStringValue(); } },
                { "status", n => { Status = n.GetDoubleValue(); } },
                { "timestamp_created", n => { TimestampCreated = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("campaign_id", CampaignId);
            writer.WriteStringValue("campaign_name", CampaignName);
            writer.WriteDoubleValue("status", Status);
        }
    }
}
#pragma warning restore CS0618
