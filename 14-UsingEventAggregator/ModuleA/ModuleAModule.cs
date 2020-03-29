using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        // View を読み込む
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            // LeftRegion にこの View を表示する
            regionManager.RegisterViewWithRegion("LeftRegion", typeof(MessageView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) { }
    }
}
