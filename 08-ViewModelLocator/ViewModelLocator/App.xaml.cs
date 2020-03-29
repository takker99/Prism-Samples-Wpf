using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using ViewModelLocator.Views;

// 自動生成 code のみ。Module の登録なし
namespace ViewModelLocator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell() => Container.Resolve<MainWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry) { }
    }
}
