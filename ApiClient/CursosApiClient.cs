using Entities;

namespace ApiClient
{
    public class CursoApiClient : ApiClientBase<CursoDto, Curso> , ICursoApiClient
    {
        protected override string ApiRoute => "api/cursos";
        public async Task<List<Curso>> GetByUsuarioAsync(int usuarioId)
        {
            HttpResponseMessage response = await client.GetAsync($"{ApiRoute}/usuario/{usuarioId}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<List<Curso>>();
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }
    }

    public interface ICursoApiClient
    {
        Task<List<CursoDto>> GetAllAsync();
        Task<List<Curso>> GetByUsuarioAsync(int usuarioId);
        Task<Curso?> GetAsync(int id);
        Task AddAsync(Curso curso);
        Task UpdateAsync(Curso curso);
        Task DeleteAsync(int id);
    }
}
