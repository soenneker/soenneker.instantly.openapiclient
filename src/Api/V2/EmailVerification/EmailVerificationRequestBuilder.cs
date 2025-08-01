// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.Item;
using Soenneker.Instantly.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v2\email-verification
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EmailVerificationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Instantly.OpenApiClient.api.v2.emailVerification.item collection</summary>
        /// <param name="position">The email address to verify</param>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.Item.WithEmailItemRequestBuilder"/></returns>
        public global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.Item.WithEmailItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("email", position);
                return new global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.Item.WithEmailItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.EmailVerificationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailVerificationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/email-verification", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.EmailVerificationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailVerificationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/email-verification", rawUrl)
        {
        }
        /// <summary>
        /// If an email takes longer than 10 seconds to verify, the endpoint will return the status as `pending`. In that case, you may use the `/email-verification/:email` endpoint to check the status of the verification job.Alternatively, you can send a `webhook_url` to receive the results instead of polling the status endpoint.Requires one of the following scopes: `email_verifications:create`Requires one of the following scopes: `email_verifications:create`, `email_verifications:all`, `all:create`, `all:all`
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Models.Def3"/></returns>
        /// <param name="body">The Email Verification to create</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.Def3400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.Def3401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.Def3429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Instantly.OpenApiClient.Models.Def3?> PostAsync(global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.EmailVerificationPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Instantly.OpenApiClient.Models.Def3> PostAsync(global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.EmailVerificationPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.Def3400Error.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.Def3401Error.CreateFromDiscriminatorValue },
                { "429", global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.Def3429Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Instantly.OpenApiClient.Models.Def3>(requestInfo, global::Soenneker.Instantly.OpenApiClient.Models.Def3.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// If an email takes longer than 10 seconds to verify, the endpoint will return the status as `pending`. In that case, you may use the `/email-verification/:email` endpoint to check the status of the verification job.Alternatively, you can send a `webhook_url` to receive the results instead of polling the status endpoint.Requires one of the following scopes: `email_verifications:create`Requires one of the following scopes: `email_verifications:create`, `email_verifications:all`, `all:create`, `all:all`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The Email Verification to create</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.EmailVerificationPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.EmailVerificationPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.EmailVerificationRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.EmailVerificationRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Instantly.OpenApiClient.Api.V2.EmailVerification.EmailVerificationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class EmailVerificationRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
