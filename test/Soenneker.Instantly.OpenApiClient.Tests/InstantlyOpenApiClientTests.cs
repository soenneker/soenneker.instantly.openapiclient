using Soenneker.Tests.HostedUnit;

namespace Soenneker.Instantly.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class InstantlyOpenApiClientTests : HostedUnitTest
{
    public InstantlyOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
