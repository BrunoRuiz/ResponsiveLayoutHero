using System;
using System.Linq;
using System.Threading.Tasks;
using ResponsiveLayoutApp.Interfaces;
using ResponsiveLayoutApp.Models;
using ResponsiveLayoutApp.ViewModels.Base;
using Xamarin.Forms;

namespace ResponsiveLayoutApp.ViewModels
{
    public class HeroPageViewModel : BaseViewModel
    {
        private readonly HerosModel _heroSelected;

        #region Atributos de controles Publicos
        public Task Initialization { get; }
        public Uri UriHero { get; set; }
        public Command AdicionarHeroCommand { get; private set; }
        #endregion


        public HeroPageViewModel(HerosModel herosModel, INavigation navigation, IApi api): base(navigation, api)
        {
            _heroSelected = herosModel;
            AdicionarHeroCommand = new Command(async() => await SendHeroFavoriteToAsync());
            Initialization = InitializationAsync();
        }

        private async Task InitializationAsync()
        {
            UriHero = new Uri(GetUriHeroSelected());
            await Task.CompletedTask;
        }

        private string GetUriHeroSelected()
        {
            string uriHero;

            if (_heroSelected.Urls.Where(urls => urls.Type.Equals("wiki")).Count() > 0)
                uriHero = _heroSelected.Urls.Where(urls => urls.Type.Equals("wiki")).FirstOrDefault().Url;
            else
                uriHero = _heroSelected.Urls.Where(urls => urls.Type.Equals("detail")).FirstOrDefault().Url;

            return uriHero;                
        }

        private async Task SendHeroFavoriteToAsync()
        {
            MessagingCenter.Send(_heroSelected, "HeroFavorite");
            await Task.CompletedTask;
        }
    }
}
