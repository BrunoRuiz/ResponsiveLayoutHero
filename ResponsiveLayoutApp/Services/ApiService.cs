using System.Threading.Tasks;
using Refit;
using ResponsiveLayoutApp.Interfaces;
using ResponsiveLayoutApp.Models;
using ResponsiveLayoutAppDto.Dto;

namespace ResponsiveLayoutApp.Services
{
    public class ApiService : IApi
    {
        private static string BaseUrl => "http://gateway.marvel.com/v1/public";

        private static ApiService _instance;        
        public static ApiService Instance = _instance ?? (_instance = new ApiService());
        private readonly IApi _api;

        private GatewayMarvelDto _allHeros;

        private ApiService()
        {
            _api = RestService.For<IApi>(BaseUrl);
        }

        public async Task<UsuarioModel> GetUsuario()
        {
            //simulando a chamada da API para obter as informações do usuario logado                      
            return await Task.Run(() =>
            {
                var usuario = new UsuarioModel
                {
                    Nome = "Bruno Ruiz Ferreira dos Santos",
                    DataNascimentoExtenso = "07 de Julho de 1986",
                    Idade = 34,
                    UriAvatar = "https://devblogs.microsoft.com/xamarin/wp-content/uploads/sites/44/2020/01/Codemonkeys2-1.jpg"
                };

                return usuario;
            });           
        }

        public async Task<GatewayMarvelDto> GetHeros(ApiServiceParams apiServiceParams)
        {
            _allHeros = await _api.GetHeros(apiServiceParams);
            return _allHeros;
        }        
    }
}
