using Xamarin.Forms;
using PropertyChanged;
using ResponsiveLayoutApp.Interfaces;

namespace ResponsiveLayoutApp.ViewModels.Base
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel
    {
        protected readonly INavigation Navigation;
        protected readonly IApi Api;
        public bool IsBusy { get; set; }

        public BaseViewModel(INavigation navigation = null, IApi api = null)
        {
            Navigation = navigation;
            Api = api;
        }
    }
}
