using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ResponsiveLayoutApp.Enums;
using ResponsiveLayoutApp.Interfaces;
using ResponsiveLayoutApp.Models;
using ResponsiveLayoutApp.ViewModels.Base;
using ResponsiveLayoutApp.Views;
using Xamarin.Forms;

namespace ResponsiveLayoutApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {      
        #region Atributos de controles Publicos
        public Task Initialization { get; }
        public UsuarioModel Usuario { get; private set; }
        public ObservableCollection<HerosModel> Heros { get; private set; }
        public Command<PagesType> NavigateToCommand { get; private set; }
        public Command<HerosModel> RemoveHeroiFavoriteCommand { get; private set; }
        #endregion

        #region Navegacao para outras Pages
        public PagesType NavigationToListHerosPage => PagesType.ListHerosPage;
        #endregion     

        public MainPageViewModel(INavigation navigation, IApi api): base(navigation, api)
        {
            Heros = new ObservableCollection<HerosModel>();
            NavigateToCommand = new Command<PagesType>(async (pagesType) => await NavigateToAsync(pagesType));
            RemoveHeroiFavoriteCommand = new Command<HerosModel>(async (heroModel) => await RemoveHeroiFavoriteAsync(heroModel)); 
            Initialization = InitializationAsync();

            MessagingCenter.Unsubscribe<HerosModel>(this, "HeroFavorite");
            MessagingCenter.Subscribe<HerosModel>(this, "HeroFavorite", heroFavorite =>
            {               
                if (!Heros.Contains(heroFavorite))
                    Heros.Add(heroFavorite);

                App.Current.MainPage.DisplayAlert("Heróis favoritos", "Herói adicionado com sucesso.", "OK");
            });
        }

        private async Task InitializationAsync()
        {            
            await LoadUsuarioAsync();            
        }

        private async Task LoadUsuarioAsync()
        {
            try
            {
                Usuario = await Api.GetUsuario();
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }

        private async Task RemoveHeroiFavoriteAsync(HerosModel herosModel)
        {
            var result = await App.Current.MainPage.DisplayAlert("Confirmar", "Deseja realmente excluir este herói?", "SIM", "NÃO");
            
            if (result)            
                Heros.Remove(herosModel);                  
        }


        private async Task NavigateToAsync(PagesType pagesType)
        {
            System.Diagnostics.Debug.WriteLine(pagesType);            
            //TODO - Somente um exemplo de controle de navegação se esta classe
            //fosse responsavel por um MainMenu por exemplo. Porem eu ainda estou
            //acoplando minha ViewModel a uma View e isso é um problema, eu posso
            //implementar um servico de navegacão para minhas classes sejam
            //fortemente DESACOPLADAS fazendo com que eu nao tenha problemas com
            //Testes de unidade e da UI tbm.

            switch (pagesType)
            {
                case PagesType.ListHerosPage:
                    await Navigation.PushAsync(new ListHerosPage());
                    break;
            }
        }
    }
}
