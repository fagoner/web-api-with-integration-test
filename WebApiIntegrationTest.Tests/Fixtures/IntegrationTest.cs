using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace WebApiIntegrationTest.Tests.Fixtures
{
  public abstract class IntegrationTests : IClassFixture<CustomWebApplicationFactory>
  {
    protected readonly CustomWebApplicationFactory _factory;
    protected readonly HttpClient _client;
    protected readonly IConfiguration _configuration;

    public IntegrationTests(CustomWebApplicationFactory fixture)
    {
      _factory = fixture;
      _client = fixture.CreateClient();
      
    }
  }
}