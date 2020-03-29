using Modules.Views;
using Prism.Modularity;
using Prism.Unity;
using Prism.Ioc;
using System.Windows;

namespace Modules
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        // ここから自動生成 code
        protected override Window CreateShell() => Container.Resolve<MainWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry) { }
        // ここまで自動生成 code

        // DirectoryにあるすべてのModule files を読み込む
        protected override IModuleCatalog CreateModuleCatalog() => new DirectoryModuleCatalog() { ModulePath = @".\Modules" };
    }
}
