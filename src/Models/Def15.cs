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
    /// A custom label for categorizing and managing leads
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Def15 : IParsable
    {
        /// <summary>User ID of the creator of this label</summary>
        public Guid? CreatedBy { get; private set; }
        /// <summary>Detailed description of the custom lead label purpose</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Unique identifier for the custom lead label</summary>
        public Guid? Id { get; private set; }
        /// <summary>Interest status associated with this label. This is generated automatically by us.</summary>
        public double? InterestStatus { get; private set; }
        /// <summary>Interest status label associated with this label</summary>
        public global::Soenneker.Instantly.OpenApiClient.Models.Def15_interest_status_label? InterestStatusLabel { get; set; }
        /// <summary>Display label for the custom lead label</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>Organization ID that owns this custom lead label</summary>
        public Guid? OrganizationId { get; private set; }
        /// <summary>Timestamp when the custom lead label was created</summary>
        public DateTimeOffset? TimestampCreated { get; private set; }
        /// <summary>Whether this label should be used with AI features</summary>
        public bool? UseWithAi { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Models.Def15"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Instantly.OpenApiClient.Models.Def15 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Instantly.OpenApiClient.Models.Def15();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_by", n => { CreatedBy = n.GetGuidValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "interest_status", n => { InterestStatus = n.GetDoubleValue(); } },
                { "interest_status_label", n => { InterestStatusLabel = n.GetEnumValue<global::Soenneker.Instantly.OpenApiClient.Models.Def15_interest_status_label>(); } },
                { "label", n => { Label = n.GetStringValue(); } },
                { "organization_id", n => { OrganizationId = n.GetGuidValue(); } },
                { "timestamp_created", n => { TimestampCreated = n.GetDateTimeOffsetValue(); } },
                { "use_with_ai", n => { UseWithAi = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::Soenneker.Instantly.OpenApiClient.Models.Def15_interest_status_label>("interest_status_label", InterestStatusLabel);
            writer.WriteStringValue("label", Label);
            writer.WriteBoolValue("use_with_ai", UseWithAi);
        }
    }
}
#pragma warning restore CS0618
