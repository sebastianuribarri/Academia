using Entities;

namespace ApiClient
{
    public class DocenteApiClient : ApiClientBase<DocenteDto, Usuario>
    {
        protected override string ApiRoute => "api/docentes";
    }
}
