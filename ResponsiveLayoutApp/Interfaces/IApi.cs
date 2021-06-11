using System.Threading.Tasks;
using Refit;
using ResponsiveLayoutApp.Models;
using ResponsiveLayoutApp.Services;
using ResponsiveLayoutAppDto.Dto;

namespace ResponsiveLayoutApp.Interfaces
{
    public interface IApi
    {        
        Task<UsuarioModel> GetUsuario();

        [Get("/characters")]
        Task<GatewayMarvelDto> GetHeros(ApiServiceParams apiServiceParams);     
    }
}
