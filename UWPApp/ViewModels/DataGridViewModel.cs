using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Caliburn.Micro;
using UWPApp.Core.Models;
using UWPApp.Core.Services;

namespace UWPApp.ViewModels
{
    public class DataGridViewModel : Screen
    {
        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public DataGridViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // Get sample data from service
            var data = await SampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
