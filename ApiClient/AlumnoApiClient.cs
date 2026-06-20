using Entities;

namespace ApiClient
{
    public class AlumnoApiClient : ApiClientBase<AlumnoDto, Usuario>
    {
        protected override string ApiRoute => "api/alumnos";
    }
}
