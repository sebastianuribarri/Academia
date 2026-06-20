using Entities;

namespace ApiClient
{
    public class PlanApiClient : ApiClientBase<PlanDto, Plan>
    {
        protected override string ApiRoute => "api/planes";
    }
}
