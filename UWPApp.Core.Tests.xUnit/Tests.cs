using System.Threading.Tasks;
using UWPApp.Core.Services;
using Xunit;

namespace UWPApp.Core.Tests.XUnit
{
    public class Tests
    {
        [Fact]
        public void Test1()
        { }

        // This test serves only as a demonstration of testing functionality in the Core library.
        [Fact]
        public async void EnsureSampleDataServiceReturnsContentGridDataAsync()
        {
            var actual = await SampleDataService.GetContentGridDataAsync();

            Assert.NotEmpty(actual);
        }

        // This test serves only as a demonstration of testing functionality in the Core library.
        [Fact]
        public async void EnsureSampleDataServiceReturnsGridDataAsync()
        {
            var actual = await SampleDataService.GetGridDataAsync();

            Assert.NotEmpty(actual);
        }

        // This test serves only as a demonstration of testing functionality in the Core library.
        [Fact]
        public async Task EnsureSampleDataServiceReturnsMasterDetailDataAsync()
        {
            var actual = await SampleDataService.GetMasterDetailDataAsync();

            Assert.NotEmpty(actual);
        }
    }
}