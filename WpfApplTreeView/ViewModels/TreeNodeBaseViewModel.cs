using System.Collections.ObjectModel;

namespace WpfApplication1.ViewModels
{
    public class TreeNodeBaseViewModel
    {
        public TreeNodeBaseViewModel(string caption)
        {
            Caption = caption;
        }

        public string Caption { get; set; }

        /// <summary>
        /// Дочерние узлы
        /// </summary>
        public ObservableCollection<TreeNodeBaseViewModel> Childrens { get; } = new ObservableCollection<TreeNodeBaseViewModel>();

        /// <summary>
        /// Комманды (точнее viewModel для них). Из них будет сформировано контекстное меню для каждого кункта
        /// </summary>
        public ReadOnlyObservableCollection<MenuItemViewModel> Commands => GetCommands();

        /// <summary>
        /// Метод вирткуальный - таким образом потомки сами могут решать какие дял них команды доступны
        /// </summary>
        /// <returns></returns>
        protected virtual ReadOnlyObservableCollection<MenuItemViewModel> GetCommands()
        {
            // по умолчанию возвращаем пустой список команд
            return new ReadOnlyObservableCollection<MenuItemViewModel>(new ObservableCollection<MenuItemViewModel>());
        }

        public bool CommandsIsEmpty => Commands.Count > 0;
    }
}
