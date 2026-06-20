using Entities;

namespace ApiClient
{
    public class PersonaApiClient : ApiClientBase<PersonaDto, Persona>
    {
        protected override string ApiRoute => "api/personas";
        public async Task<Persona?> AddAsync(Persona persona)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(ApiRoute, persona);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Persona?>();
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(errorMessage);
            }
        }
    }

    
}
