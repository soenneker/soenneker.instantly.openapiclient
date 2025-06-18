using Soenneker.Instantly.OpenApiClient.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Instantly.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class InstantlyOpenApiClientTests : FixturedUnitTest
{
    private readonly IInstantlyOpenApiClient _kiota;

    public InstantlyOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _kiota = Resolve<IInstantlyOpenApiClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
