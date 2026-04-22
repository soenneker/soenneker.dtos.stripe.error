using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.Stripe.Error.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class StripeErrorDtoTests : HostedUnitTest
{
    public StripeErrorDtoTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
