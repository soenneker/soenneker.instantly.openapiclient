// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v2\inbox-placement-tests\email-service-provider-options
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EmailServiceProviderOptionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailServiceProviderOptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/inbox-placement-tests/email-service-provider-options", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailServiceProviderOptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/inbox-placement-tests/email-service-provider-options", rawUrl)
        {
        }
        /// <summary>
        /// Provides a list of available email service providers for inbox placement tests.
        /// </summary>
        /// <returns>A List&lt;global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptions&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptions401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptions429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptions>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptions>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptions401Error.CreateFromDiscriminatorValue },
                { "429", global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptions429Error.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptions>(requestInfo, global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptions.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Provides a list of available email service providers for inbox placement tests.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Instantly.OpenApiClient.Api.V2.InboxPlacementTests.EmailServiceProviderOptions.EmailServiceProviderOptionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class EmailServiceProviderOptionsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
