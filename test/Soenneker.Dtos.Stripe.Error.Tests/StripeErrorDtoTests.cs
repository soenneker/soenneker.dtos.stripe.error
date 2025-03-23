using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Dtos.Stripe.Error.Tests;

[Collection("Collection")]
public class StripeErrorDtoTests : FixturedUnitTest
{
    public StripeErrorDtoTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
