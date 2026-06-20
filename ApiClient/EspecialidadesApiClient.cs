using Entities;

namespace ApiClient
{
    public class EspecialidadesApiClient : ApiClientBase<EspecialidadDto, Especialidad>
    {
        protected override string ApiRoute => "api/especialidades";
    }
}
