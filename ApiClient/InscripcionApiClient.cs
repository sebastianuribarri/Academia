using Entities;

namespace ApiClient
{
    public class InscripcionApiClient : ApiClientBase<InscripcionDto, Inscripcion>, IInscripcionApiClient
    {
        protected override string ApiRoute => "api/inscripciones";


        public async Task<List<InscripcionAlumnoDto>> GetInscripcionesAlumnoAsync(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{ApiRoute}/alumno/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<List<InscripcionAlumnoDto>>();
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }

        public async Task<List<InscripcionDto>> GetInscripcionesDocenteAsync(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{ApiRoute}/docente/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<List<InscripcionDto>>();
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }
        public async Task AddAsync(InscripcionRequest inscripcionRequest)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(ApiRoute, inscripcionRequest);
            if (!response.IsSuccessStatusCode)
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }
    }

    public interface IInscripcionApiClient
    {
        Task<List<InscripcionAlumnoDto>> GetInscripcionesAlumnoAsync(int idUsuario);
        Task<List<InscripcionDto>> GetInscripcionesDocenteAsync(int idUsuario);
        Task<List<InscripcionDto>> GetAllAsync();
        Task<Inscripcion?> GetAsync(int id);
        Task AddAsync(Inscripcion inscripcion);
        Task AddAsync(InscripcionRequest inscripcionRequest);
        Task UpdateAsync(Inscripcion inscripcion);
        Task DeleteAsync(int id);
    }
}
