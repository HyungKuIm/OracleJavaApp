using Prism.Mvvm;

namespace OracleJavaModel
{
    public class PageModel : BindableBase
    {
        private Page page = Page.Kbs1;

        public Page Page
        { 
            get { return page; } 
            set { SetProperty(ref page, value); }
        }
    }
}