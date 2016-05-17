using System.Windows;
using WpfApplication1.View;
using WpfApplication1.ViewModels;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var viewModel = new MainViewModel();

            InitDataItemsForSample(viewModel);

            var view = new MainWindow();
            view.DataContext = viewModel;
            view.Show();
        }

        /// <summary>
        /// Создаем viewModel для теста
        /// </summary>
        private void InitDataItemsForSample(MainViewModel viewModel)
        {
            var item1 = new TreeNodeViewModel("Это пункт 1");

            item1.AddCommand(new MenuItemViewModel("Это меню 1", new CustomCommand("Это команда 1")));
            item1.AddCommand(new MenuItemViewModel("Это меню 2", new CustomCommand("Это команда 2")));
            item1.AddCommand(new MenuItemViewModel("Это меню 3", new CustomCommand("Это команда 3")));
            viewModel.Data.Add(item1);

            var item11 = new TreeNodeViewModel("Это дочерний пункт");
            item11.AddCommand(new MenuItemViewModel("Это меню 11", new CustomCommand("Это команда 11")));
            item1.Childrens.Add(item11);

            var item2 = new TreeNodeViewModel("Это пункт без команд");
            viewModel.Data.Add(item2);
        }
    }
}
