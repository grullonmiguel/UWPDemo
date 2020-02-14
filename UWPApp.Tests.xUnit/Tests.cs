using Caliburn.Micro;
using Moq;
using UWPApp.Services;
using UWPApp.ViewModels;

using Xunit;

namespace UWPApp.Tests.XUnit
{
    public class Tests
    {
        [Fact]
        public void TestMethod1()
        {
        }

        [Fact]
        public void TestContentGridViewModelCreation()
        {
            var mockNavService = new Mock<INavigationService>();
            var mockAnimationService = new Mock<IConnectedAnimationService>();
            var vm = new ContentGridViewModel(mockNavService.Object, mockAnimationService.Object);
            Assert.NotNull(vm);
        }

        [Fact]
        public void TestDataGridViewModelCreation()
        {
            var vm = new DataGridViewModel();
            Assert.NotNull(vm);
        }

        [Fact]
        public void TestMainViewModelCreation()
        {
            var vm = new MainViewModel();
            Assert.NotNull(vm);
        }

        [Fact]
        public void TestMasterDetailViewModelCreation()
        {
            var vm = new MasterDetailViewModel();
            Assert.NotNull(vm);
        }

        [Fact]
        public void TestSettingsViewModelCreation()
        {
            var vm = new SettingsViewModel();
            Assert.NotNull(vm);
        }
    }
}
