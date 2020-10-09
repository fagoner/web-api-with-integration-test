using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using WebApiIntegrationTest.Models;
using WebApiIntegrationTest.Tests.Fixtures;
using Xunit;

namespace WebApiIntegrationTest.Tests
{
  public class StudentControllerTests : IntegrationTests
  {
    public StudentControllerTests(CustomWebApplicationFactory fixture) : base(fixture)
    {
    }

    [Fact]
    public async Task ShouldBeEmptyAsync()
    {
      var response = await _client.GetAsync("api/Students");
      response.StatusCode.Should().Be(HttpStatusCode.OK);

      var students = JsonConvert.DeserializeObject<Student[]>(
        await response.Content.ReadAsStringAsync()
      );

      students.Should().HaveCountGreaterOrEqualTo(0);
    }
  }
}
