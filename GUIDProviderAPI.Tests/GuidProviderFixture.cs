using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net.Http.Json;
using Xunit;
using Xunit.Abstractions;

namespace GUIDProviderAPI.Tests
{
    public class GuidProviderFixture : IDisposable
    {

        private readonly ITestOutputHelper _output;

        private WebApplicationFactory<Program> _factory;
        private HttpClient _client;

        public GuidProviderFixture(ITestOutputHelper output) 
        {
            _factory = new WebApplicationFactory<Program>();
            _client = _factory.CreateClient();
            
            _output = output;
            _output.WriteLine("SetUp");
        }

        public void Dispose()
        {
            _output.WriteLine("TearDown");
        }

        [Fact]
        public async void ExampleTest()
        {
            var response1 = await _client.GetAsync("/GUIDProviderAPI");
            var guid1 = await response1.Content.ReadFromJsonAsync<Guid>();
            _output.WriteLine(guid1.ToString());

            var response2 = await _client.GetAsync("/GUIDProviderAPI");
            var guid2 = await response2.Content.ReadFromJsonAsync<Guid>();
            _output.WriteLine(guid2.ToString());

            Assert.NotEqual(guid1, guid2);
            Assert.False(guid1 == guid2);
        }

        [Fact]
        public async void ExampleTest2()
        {            
          // _factory.Services.   
        }
    }
}
