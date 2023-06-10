using OracleJavaModel;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace OracleJavaApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private ObservableCollection<PageModel> pages = null;

        public ObservableCollection<PageModel> Pages
        {
            get { return pages; }
            set { SetProperty(ref pages, value);}
        }

        private PageModel activePage;
        public PageModel ActivePage
        {
            get { return activePage; }
            set { 
                SetProperty(ref activePage, value);
                //MessageBox.Show("activePage = " + activePage.Page);
                this.regionManager.RequestNavigate("ContentRegion", activePage.Page.ToString());
            }
        }

        private IRegionManager regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            InitializeData();
            this.regionManager = regionManager;
        }

        private void InitializeData()
        {
            pages = new ObservableCollection<PageModel>();
            pages.Add(new PageModel { Page = Page.ViewPanel });
            pages.Add(new PageModel { Page = Page.ViewCanvas });
            pages.Add(new PageModel { Page = Page.Mbc });
            pages.Add(new PageModel { Page = Page.Sbs });
            pages.Add(new PageModel { Page = Page.ViewCalendar });
            pages.Add(new PageModel { Page = Page.ViewAnimation });
            pages.Add(new PageModel { Page = Page.ViewEasing });
            pages.Add(new PageModel { Page = Page.MovieView });
        }
    }
}
