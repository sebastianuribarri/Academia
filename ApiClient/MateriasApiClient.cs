using Entities;

namespace ApiClient
{
    public class MateriaApiClient : ApiClientBase<MateriaDto, Materia>, IMateriaApiClient
    {
        protected override string ApiRoute => "api/materias";

        public async Task<List<MateriaDto>> GetByPlanAsync(int idPlan)
        {
            HttpResponseMessage response = await client.GetAsync($"{ApiRoute}/plan/{idPlan}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<List<MateriaDto>>();
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }

    }
    public interface IMateriaApiClient
    {
        Task<List<MateriaDto>> GetAllAsync();
        Task<List<MateriaDto>> GetByPlanAsync( int idPlan);
        Task<Materia?> GetAsync(int id);
        Task AddAsync(Materia materia);
        Task UpdateAsync(Materia materia);
        Task DeleteAsync(int id);
    }
}
