using System.Collections.ObjectModel;
using System.Windows;
using WpfApplication1.Model;
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
            var model = BuildModelForSample();
            var emailSender = new ComplexEmailSender();
            var viewModel = BuildViewModel(model, emailSender);
            var view = new MainWindow {DataContext = viewModel};
            view.Show();
        }
        
        private ObservableCollection<PersonGroup> BuildModelForSample()
        {
            var model = new ObservableCollection<PersonGroup>();
            var emailSource = new ComplexEmailSource();

            var alex = new Person("Alex", emailSource);
            var beatrice = new Person("Beatrice", emailSource);

            var swimmers = new PersonGroup("Swimmers");
            model.Add(swimmers);

            swimmers.Persons.Add(alex);
            swimmers.Persons.Add(beatrice);

            var cooks = new PersonGroup("Cooks");
            model.Add(cooks);
            cooks.Persons.Add(alex);

            var softwareEngineers = new PersonGroup("Software Engineers");
            model.Add(softwareEngineers);

            return model;
        }

        private MainViewModel BuildViewModel(ObservableCollection<PersonGroup> model, IEmailSender emailSender)
        {
            var viewModel = new MainViewModel();
            foreach (var group in model)
            {
                var groupViewModel = new PersonGroupViewModel(group, emailSender);
                viewModel.Data.Add(groupViewModel);
            }

            return viewModel;
        }
    }
}
