using Prism.Mvvm;

namespace OracleJavaModel
{
    public class PageModel : BindableBase
    {
        private Page page = Page.ViewPanel;

        public Page Page
        { 
            get { return page; } 
            set { SetProperty(ref page, value); }
        }
    }
}