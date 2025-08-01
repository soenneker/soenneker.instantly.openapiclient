// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Soenneker.Instantly.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Instantly.OpenApiClient.Api.V2.AccountCampaignMappings.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WithEmailGetResponse : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The items property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Instantly.OpenApiClient.Models.Def10>? Items { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Instantly.OpenApiClient.Models.Def10> Items { get; set; }
#endif
        /// <summary>The filter for getting the next items after this one, this could either be a UUID, a MongoDB ID, a timestamp, on an email depending on the specific API</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextStartingAfter { get; set; }
#nullable restore
#else
        public string NextStartingAfter { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.AccountCampaignMappings.Item.WithEmailGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Instantly.OpenApiClient.Api.V2.AccountCampaignMappings.Item.WithEmailGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Instantly.OpenApiClient.Api.V2.AccountCampaignMappings.Item.WithEmailGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::Soenneker.Instantly.OpenApiClient.Models.Def10>(global::Soenneker.Instantly.OpenApiClient.Models.Def10.CreateFromDiscriminatorValue)?.AsList(); } },
                { "next_starting_after", n => { NextStartingAfter = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Soenneker.Instantly.OpenApiClient.Models.Def10>("items", Items);
            writer.WriteStringValue("next_starting_after", NextStartingAfter);
        }
    }
}
#pragma warning restore CS0618
