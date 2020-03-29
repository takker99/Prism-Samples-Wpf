using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using System;
using System.Reflection;
using System.Windows;
using ViewModelLocator.Views;

namespace ViewModelLocator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        // "...Views.hogehoge.xaml" という View の View Model を "...ViewModels.hogehoge.cs" に自動で設定する
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                // "...ViewModelLocator.Views.MainWindow" を "...ViewModelLocator.ViewModels.MainWindow" に置き換える
                var viewName = viewType.FullName.Replace(".Views.",".ViewModels.");
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                var viewModelName = $"{viewName}, {viewAssemblyName}";
                return Type.GetType(viewModelName);
            });
        }
    }
}
