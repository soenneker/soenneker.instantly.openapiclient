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
    public partial class InboxPlacementTestsPostRequestBody_automations_when : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Condition for automation trigger</summary>
        public global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.InboxPlacementTestsPostRequestBody_automations_when_condition? Condition { get; set; }
        /// <summary>Value for condition, if applicable</summary>
        public double? ConditionValue { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.InboxPlacementTestsPostRequestBody_automations_when"/> and sets the default values.
        /// </summary>
        public InboxPlacementTestsPostRequestBody_automations_when()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.InboxPlacementTestsPostRequestBody_automations_when"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.InboxPlacementTestsPostRequestBody_automations_when CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.InboxPlacementTestsPostRequestBody_automations_when();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "condition", n => { Condition = n.GetEnumValue<global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.InboxPlacementTestsPostRequestBody_automations_when_condition>(); } },
                { "condition_value", n => { ConditionValue = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.InboxPlacementTestsPostRequestBody_automations_when_condition>("condition", Condition);
            writer.WriteDoubleValue("condition_value", ConditionValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
