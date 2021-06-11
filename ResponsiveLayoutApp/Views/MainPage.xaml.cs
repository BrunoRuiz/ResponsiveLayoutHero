using ResponsiveLayoutApp.Services;
using ResponsiveLayoutApp.ViewModels;
using Xamarin.Forms;

namespace ResponsiveLayoutApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(Navigation, ApiService.Instance);
        }
    }
}
