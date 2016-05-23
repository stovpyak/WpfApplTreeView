using System.Collections.ObjectModel;

namespace WpfApplication1.ViewModels
{
    public abstract class TreeNodeBaseViewModel
    {
        public abstract string Caption { get; }

        public abstract object Icon { get; }

        /// <summary>
        /// Дочерние узлы
        /// </summary>
        public ObservableCollection<TreeNodeBaseViewModel> Children { get; } = new ObservableCollection<TreeNodeBaseViewModel>();

        /// <summary>
        /// Команды (точнее viewModel для них). Из них будет сформировано контекстное меню для каждого пункта
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
