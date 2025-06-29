// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Ctd;
using Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Item;
using Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Test;
using Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.WarmupAnalytics;
using Soenneker.Instantly.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Instantly.OpenApiClient.Api.V2.Accounts
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v2\accounts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AccountsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The ctd property</summary>
        public global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Ctd.CtdRequestBuilder Ctd
        {
            get => new global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Ctd.CtdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The test property</summary>
        public global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Test.TestRequestBuilder Test
        {
            get => new global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Test.TestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The warmupAnalytics property</summary>
        public global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.WarmupAnalytics.WarmupAnalyticsRequestBuilder WarmupAnalytics
        {
            get => new global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.WarmupAnalytics.WarmupAnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Instantly.OpenApiClient.api.v2.accounts.item collection</summary>
        /// <param name="position">The email of the account to get</param>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Item.WithEmailItemRequestBuilder"/></returns>
        public global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Item.WithEmailItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("email", position);
                return new global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Item.WithEmailItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/accounts{?limit*,provider_code*,search*,starting_after*,status*,tag_ids*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/accounts{?limit*,provider_code*,search*,starting_after*,status*,tag_ids*}", rawUrl)
        {
        }
        /// <summary>
        /// Requires one of the following scopes: `accounts:read`, `accounts:all`, `all:read`, `all:all`
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Accounts401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Accounts429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsGetResponse?> GetAsAccountsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsGetResponse> GetAsAccountsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Accounts401Error.CreateFromDiscriminatorValue },
                { "429", global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Accounts429Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsGetResponse>(requestInfo, global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Requires one of the following scopes: `accounts:read`, `accounts:all`, `all:read`, `all:all`
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Accounts401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Accounts429Error">When receiving a 429 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsAccountsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Accounts401Error.CreateFromDiscriminatorValue },
                { "429", global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Accounts429Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsResponse>(requestInfo, global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Requires one of the following scopes: `accounts:create`, `accounts:all`, `all:create`, `all:all`
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Models.Def0"/></returns>
        /// <param name="body">The Account to create</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Def0400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Def0401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Def0429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Instantly.OpenApiClient.Models.Def0?> PostAsync(global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Instantly.OpenApiClient.Models.Def0> PostAsync(global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Def0400Error.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Def0401Error.CreateFromDiscriminatorValue },
                { "429", global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.Def0429Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Instantly.OpenApiClient.Models.Def0>(requestInfo, global::Soenneker.Instantly.OpenApiClient.Models.Def0.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Requires one of the following scopes: `accounts:read`, `accounts:all`, `all:read`, `all:all`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Requires one of the following scopes: `accounts:create`, `accounts:all`, `all:create`, `all:all`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The Account to create</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Requires one of the following scopes: `accounts:read`, `accounts:all`, `all:read`, `all:all`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccountsRequestBuilderGetQueryParameters 
        {
            /// <summary>The number of items to return</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            [QueryParameter("provider_code")]
            public double? ProviderCode { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("search")]
            public string Search { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("starting_after")]
            public string? StartingAfter { get; set; }
#nullable restore
#else
            [QueryParameter("starting_after")]
            public string StartingAfter { get; set; }
#endif
            [QueryParameter("status")]
            public double? Status { get; set; }
            /// <summary>Filter accounts by tag ids. Returns accounts that have any of the specified tags assigned. You can specify multiple tag ids by separating them with a comma.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tag_ids")]
            public string? TagIds { get; set; }
#nullable restore
#else
            [QueryParameter("tag_ids")]
            public string TagIds { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccountsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Instantly.OpenApiClient.Api.V2.Accounts.AccountsRequestBuilder.AccountsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccountsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
