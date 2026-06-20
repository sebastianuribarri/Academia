using Entities;

namespace ApiClient
{
    public class ComisionApiClient : ApiClientBase<ComisionDto, Comision>
    {
        protected override string ApiRoute => "api/comisiones";
    }
}
