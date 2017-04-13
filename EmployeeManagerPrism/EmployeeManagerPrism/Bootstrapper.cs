using Microsoft.Practices.Unity;
using Prism.Unity;
using EmployeeManagerPrism.Views;
using System.Windows;

namespace EmployeeManagerPrism
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
