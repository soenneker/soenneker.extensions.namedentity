using Soenneker.Tests.FixturedUnit;
using Xunit;


namespace Soenneker.Extensions.NamedEntity.Tests;

[Collection("Collection")]
public class NamedEntityExtensionTests : FixturedUnitTest
{
    public NamedEntityExtensionTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }
}
