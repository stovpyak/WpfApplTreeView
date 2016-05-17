using System.Collections.ObjectModel;

namespace WpfApplication1.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<TreeNodeBaseViewModel> Data { get; } = new ObservableCollection<TreeNodeBaseViewModel>();
    }
}