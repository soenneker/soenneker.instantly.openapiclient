[![](https://img.shields.io/nuget/v/soenneker.instantly.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.instantly.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.instantly.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.instantly.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.instantly.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.instantly.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.instantly.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.instantly.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Instantly.OpenApiClient

Call Instantly endpoints through a Kiota-generated client with typed request builders and models.

## Install

```bash
dotnet add package Soenneker.Instantly.OpenApiClient
```

## Create a client

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Instantly.OpenApiClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.instantly.ai/")
};
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new InstantlyOpenApiClient(adapter);
```

The `HttpClient` supplies authentication, so the Kiota adapter uses anonymous authentication. Reuse the transport rather than constructing one per request, and dispose it when its owning application component shuts down.

For application registration, lazy client reuse, optional HTTP logging, and coordinated transport ownership, use `Soenneker.Instantly.ClientUtil` instead of constructing the generated client directly.

## Call an endpoint

```csharp
using Soenneker.Instantly.OpenApiClient.Models;

ListAccount200Response? accounts = await client.Api.V2.Accounts.GetAsync(
    config => config.QueryParameters.Limit = 10,
    cancellationToken);
```

The generated surface follows the OpenAPI document. Start with `client.Api.V2`, then follow request builders for resources such as `Accounts`, `Campaigns`, `Leads`, and `DfyEmailAccountOrders`. Types under `Soenneker.Instantly.OpenApiClient.Models` represent request and response bodies.

HTTP failures are surfaced through Kiota exceptions. Nullable results indicate that an endpoint returned no response body.

This repository contains generated code. Put reusable helpers and behavior changes in a separate package so regeneration does not overwrite them.
