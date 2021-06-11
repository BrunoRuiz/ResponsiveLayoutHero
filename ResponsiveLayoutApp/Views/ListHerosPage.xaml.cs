using ResponsiveLayoutApp.Services;
using ResponsiveLayoutApp.ViewModels;
using Xamarin.Forms;

namespace ResponsiveLayoutApp.Views
{
    public partial class ListHerosPage : ContentPage
    {
        public ListHerosPage()
        {
            InitializeComponent();
            BindingContext = new ListHerosPageViewModel(Navigation, ApiService.Instance);
        }       
    }
}
