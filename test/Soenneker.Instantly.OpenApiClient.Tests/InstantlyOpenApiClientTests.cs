using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Instantly.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class InstantlyOpenApiClientTests : FixturedUnitTest
{
    public InstantlyOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
