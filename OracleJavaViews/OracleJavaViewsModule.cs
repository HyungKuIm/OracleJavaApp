using OracleJavaViews.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace OracleJavaViews
{
    public class OracleJavaViewsModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionMan = containerProvider.Resolve<RegionManager>();
            regionMan.RegisterViewWithRegion("ContentRegion", typeof(Views.ViewStart));
            //AssemblyQualifiedName = "OracleJavaViews.Views.ViewStart, OracleJavaViews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            //regionMan.RegisterViewWithRegion("ContentRegion", "OracleJavaViews.Views.ViewStart, OracleJavaViews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}