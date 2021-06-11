using ResponsiveLayoutApp.Models;
using ResponsiveLayoutApp.Services;
using ResponsiveLayoutApp.ViewModels;
using Xamarin.Forms;

namespace ResponsiveLayoutApp.Views
{
    public partial class HeroPage : ContentPage
    {
        public HeroPage(HerosModel herosModel)
        {
            InitializeComponent();
            BindingContext = new HeroPageViewModel(herosModel, Navigation, ApiService.Instance);
        }
    }
}
