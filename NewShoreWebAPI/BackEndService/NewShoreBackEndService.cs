namespace NewShoreWebAPI.BackEndService
{
    public class NewShoreBackEndService
    {
        public async Task<List<NewShoreAirResponse>> GetNewShoreRuts()
        {
            var urlService = $"{NSConstants.UrlBase}2";
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, urlService);
                var httpResponse = await client.SendAsync(request);
                if (httpResponse.IsSuccessStatusCode)
                {
                    string user = await httpResponse.Content.ReadAsStringAsync();
                    var resultDeserialize = JsonConvert.DeserializeObject<List<NewShoreAirResponse>>(user);
                    return resultDeserialize;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
