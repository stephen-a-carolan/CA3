namespace CA3.Server.Birth_day_info
{
    public class BirthdayServiseBase
    {


        public async Task<List<BirthdayItem>> GetBirthdays(HttpClient httpClient)
        {
            ConfigerHttpClient();

            var response = await httpClient.GetAsync(BdayEndpoint);
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync();
            return null;
        }

        private void ConfigerHttpClient()
        {
            throw new NotImplementedException();
        }

        public string? BdayEndpoint { get; set; }
    }
}