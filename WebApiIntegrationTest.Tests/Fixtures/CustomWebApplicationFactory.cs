using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApiIntegrationTest.Tests.Fixtures
{
  public class CustomWebApplicationFactory : WebApplicationFactory<WebApiIntegrationTest.Startup>
  {
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
      
    }
  }
}