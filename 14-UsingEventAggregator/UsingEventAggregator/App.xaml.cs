using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using UsingEventAggregator.Views;

namespace UsingEventAggregator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    // The entry point of the application
    public partial class App : PrismApplication
    {
        protected override Window CreateShell() => return Container.Resolve<MainWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry) { }

        // Load the modules
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleA.ModuleAModule>();
            moduleCatalog.AddModule<ModuleB.ModuleBModule>();
        }
    }
}
