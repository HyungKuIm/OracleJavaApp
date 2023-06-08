using OracleJavaModel;
using Prism.Mvvm;
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
                MessageBox.Show("activePage = " + activePage.Page);
            }
        }

        public MainWindowViewModel()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            pages = new ObservableCollection<PageModel>();
            pages.Add(new PageModel { Page = Page.Kbs1 });
            pages.Add(new PageModel { Page = Page.Kbs2 });
            pages.Add(new PageModel { Page = Page.Mbc });
            pages.Add(new PageModel { Page = Page.Sbs });
        }
    }
}
