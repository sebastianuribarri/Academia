using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Entities;

namespace ApiClient
{
    public class UsuarioApiClient : ApiClientBase<UsuarioDto, Usuario>, IUsuarioApiClient
    {

        protected override string ApiRoute => "api/usuarios";


        public async Task<Usuario?> LoginAsync(string nombreUsuario, string clave)
        {
            var loginRequest = new { nombreUsuario, clave };

            HttpResponseMessage response = await client.PostAsJsonAsync($"{ApiRoute}/login", loginRequest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Usuario>();
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
        }

        public async Task<Usuario?> GetByLegajoAsync(int legajo)
        {
            HttpResponseMessage response = await client.GetAsync($"{ApiRoute}/legajo/{legajo}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Usuario>();
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }
    }

    public interface IUsuarioApiClient
    {
        Task<Usuario?> LoginAsync(string nombreUsuario, string clave);
        Task<List<UsuarioDto>> GetAllAsync();
        Task<Usuario?> GetAsync(int id);
        Task AddAsync(Usuario usuario);
        Task UpdateAsync(Usuario usuario);
        Task DeleteAsync(int id);
    }
}
