## Some commands

```bash
dotnet new sln -o web-api-with-integration-test

cd web-api-with-integration-test/

dotnet new webapi -o WebApiIntegrationTest

dotnet sln add WebApiIntegrationTest.Tests/WebApiIntegrationTest.Tests.csproj

dotnet add WebApiIntegrationTest.Tests/WebApiIntegrationTest.Tests.csproj reference WebApiIntegrationTest/WebApiIntegrationTest.csproj
```
