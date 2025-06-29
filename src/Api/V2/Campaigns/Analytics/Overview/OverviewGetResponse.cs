// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Instantly.OpenApiClient.Api.V2.Campaigns.Analytics.Overview
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class OverviewGetResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of bounced leads</summary>
        public int? BouncedCount { get; set; }
        /// <summary>The number of leads that the campaign was completed for</summary>
        public int? CompletedCount { get; set; }
        /// <summary>The total number of sent emails</summary>
        public int? EmailsSentCount { get; set; }
        /// <summary>The number of links that got clicked</summary>
        public int? LinkClickCount { get; set; }
        /// <summary>The number of links that got clicked (for the first time)</summary>
        public int? LinkClickCountUnique { get; set; }
        /// <summary>The unique number of links that got clicked, per step (counted once per lead, step, and campaign)</summary>
        public int? LinkClickCountUniqueByStep { get; set; }
        /// <summary>The total number of new leads contacted</summary>
        public int? NewLeadsContactedCount { get; set; }
        /// <summary>The total number of times the emails were opened, including duplicates</summary>
        public int? OpenCount { get; set; }
        /// <summary>The number of emails that got opened (for the first time only)</summary>
        public int? OpenCountUnique { get; set; }
        /// <summary>The unique number of times the emails were opened (counted once per lead, step, and campaign)</summary>
        public int? OpenCountUniqueByStep { get; set; }
        /// <summary>The number of leads that replied to at least one email</summary>
        public int? ReplyCount { get; set; }
        /// <summary>The number of leads that replied to at least one email (for the first time only)</summary>
        public int? ReplyCountUnique { get; set; }
        /// <summary>The unique number of leads that replied to at least one email, per step (counted once per lead, step, and campaign)</summary>
        public int? ReplyCountUniqueByStep { get; set; }
        /// <summary>The total number of closed opportunities created</summary>
        public int? TotalClosed { get; set; }
        /// <summary>The total number of interested opportunities created</summary>
        public int? TotalInterested { get; set; }
        /// <summary>The total number of meeting booked opportunities created</summary>
        public int? TotalMeetingBooked { get; set; }
        /// <summary>The total number of meeting completed opportunities created</summary>
        public int? TotalMeetingCompleted { get; set; }
        /// <summary>The total number of unique opportunities created</summary>
        public int? TotalOpportunities { get; set; }
        /// <summary>The total value of opportunities created</summary>
        public double? TotalOpportunityValue { get; set; }
        /// <summary>The number of unsubscribed leads</summary>
        public int? UnsubscribedCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Campaigns.Analytics.Overview.OverviewGetResponse"/> and sets the default values.
        /// </summary>
        public OverviewGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Campaigns.Analytics.Overview.OverviewGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Instantly.OpenApiClient.Api.V2.Campaigns.Analytics.Overview.OverviewGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Instantly.OpenApiClient.Api.V2.Campaigns.Analytics.Overview.OverviewGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bounced_count", n => { BouncedCount = n.GetIntValue(); } },
                { "completed_count", n => { CompletedCount = n.GetIntValue(); } },
                { "emails_sent_count", n => { EmailsSentCount = n.GetIntValue(); } },
                { "link_click_count", n => { LinkClickCount = n.GetIntValue(); } },
                { "link_click_count_unique", n => { LinkClickCountUnique = n.GetIntValue(); } },
                { "link_click_count_unique_by_step", n => { LinkClickCountUniqueByStep = n.GetIntValue(); } },
                { "new_leads_contacted_count", n => { NewLeadsContactedCount = n.GetIntValue(); } },
                { "open_count", n => { OpenCount = n.GetIntValue(); } },
                { "open_count_unique", n => { OpenCountUnique = n.GetIntValue(); } },
                { "open_count_unique_by_step", n => { OpenCountUniqueByStep = n.GetIntValue(); } },
                { "reply_count", n => { ReplyCount = n.GetIntValue(); } },
                { "reply_count_unique", n => { ReplyCountUnique = n.GetIntValue(); } },
                { "reply_count_unique_by_step", n => { ReplyCountUniqueByStep = n.GetIntValue(); } },
                { "total_closed", n => { TotalClosed = n.GetIntValue(); } },
                { "total_interested", n => { TotalInterested = n.GetIntValue(); } },
                { "total_meeting_booked", n => { TotalMeetingBooked = n.GetIntValue(); } },
                { "total_meeting_completed", n => { TotalMeetingCompleted = n.GetIntValue(); } },
                { "total_opportunities", n => { TotalOpportunities = n.GetIntValue(); } },
                { "total_opportunity_value", n => { TotalOpportunityValue = n.GetDoubleValue(); } },
                { "unsubscribed_count", n => { UnsubscribedCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("bounced_count", BouncedCount);
            writer.WriteIntValue("completed_count", CompletedCount);
            writer.WriteIntValue("emails_sent_count", EmailsSentCount);
            writer.WriteIntValue("link_click_count", LinkClickCount);
            writer.WriteIntValue("link_click_count_unique", LinkClickCountUnique);
            writer.WriteIntValue("link_click_count_unique_by_step", LinkClickCountUniqueByStep);
            writer.WriteIntValue("new_leads_contacted_count", NewLeadsContactedCount);
            writer.WriteIntValue("open_count", OpenCount);
            writer.WriteIntValue("open_count_unique", OpenCountUnique);
            writer.WriteIntValue("open_count_unique_by_step", OpenCountUniqueByStep);
            writer.WriteIntValue("reply_count", ReplyCount);
            writer.WriteIntValue("reply_count_unique", ReplyCountUnique);
            writer.WriteIntValue("reply_count_unique_by_step", ReplyCountUniqueByStep);
            writer.WriteIntValue("total_closed", TotalClosed);
            writer.WriteIntValue("total_interested", TotalInterested);
            writer.WriteIntValue("total_meeting_booked", TotalMeetingBooked);
            writer.WriteIntValue("total_meeting_completed", TotalMeetingCompleted);
            writer.WriteIntValue("total_opportunities", TotalOpportunities);
            writer.WriteDoubleValue("total_opportunity_value", TotalOpportunityValue);
            writer.WriteIntValue("unsubscribed_count", UnsubscribedCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
