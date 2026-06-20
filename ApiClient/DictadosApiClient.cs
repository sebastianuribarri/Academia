using Entities;

namespace ApiClient
{
    public class DictadoApiClient : ApiClientBase<DictadoDto, Dictado>
    {
        protected override string ApiRoute => "api/dictados";
    }
}
