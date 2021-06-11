using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ResponsiveLayoutApp.Interfaces;
using ResponsiveLayoutApp.Models;
using ResponsiveLayoutApp.Services;
using ResponsiveLayoutApp.ViewModels.Base;
using ResponsiveLayoutApp.Views;

using Xamarin.Forms;

namespace ResponsiveLayoutApp.ViewModels
{
    public class ListHerosPageViewModel : BaseViewModel
    {      
        #region Atributos de controles Publicos
        public Task Initialization { get; }        
        public IList<HerosModel> Heros { get; private set; }
        public HerosModel HeroSelected { get; private set; }
        public Command<HerosModel> NavigateToDetalheCommand { get; private set; }
        #endregion

        public ListHerosPageViewModel(INavigation navigation, IApi api): base(navigation, api)
        {           
            NavigateToDetalheCommand = new Command<HerosModel>(async(herosModel) => await NavigateToAsync(herosModel));
            Initialization = InitializationAsync();
        }        

        private async Task InitializationAsync() => await LoadHerosAsync();        

        private async Task LoadHerosAsync()
        {
            try
            {
                var apiServiceParams = new ApiServiceParams();
                var heros = await Api.GetHeros(apiServiceParams);

                var dtoToModel = JsonConvert.SerializeObject(heros.Data.Results);
                Heros = JsonConvert.DeserializeObject<IList<HerosModel>>(dtoToModel);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }

        private async Task NavigateToAsync(HerosModel herosModel) => await Navigation.PushAsync(new HeroPage(herosModel));        
    }
}
