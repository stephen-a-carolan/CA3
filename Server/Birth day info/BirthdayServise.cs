namespace CA3.Server.Birth_day_info
{
    public class BirthdayServise : IBirthdayServise
    {
        private readonly List<BirthdayItem> _birthdays = new List<BirthdayItem>();

        public void AddBirthday(BirthdayItem birthdayItem)
        {
            _birthdays.Add(birthdayItem);
        }

        public void DeleteBirthday(BirthdayItem birthdayItem)
        {
            _birthdays.Remove(birthdayItem);
        }

        public void UpdateBirthday(BirthdayItem birthdayItem)
        {
            var index = _birthdays.FindIndex(b => b.Name == birthdayItem.Name);
            _birthdays[index] = birthdayItem;
        }

        private readonly HttpClient _httpClient;
        const string _baseUrl = "https://www.daysoftheyear.com/api/v1/days/";
        const string _BdayEndpoint = "curl -H 'X-Api-Key: 6887a9cd95ce4274bf0cc427981215fc' 'https://www.daysoftheyear.com/api/v1/date/2022/01/23/'";
        const string _Host = "https://www.daysoftheyear.com\">Days Of The Year</a>";
        const string _key = "6887a9cd95ce4274bf0cc427981215fc";

        
        public BirthdayServise(HttpClient httpClient) => _httpClient = httpClient;



        public async Task<List<BirthdayItem>> GetBirthdays()
        {
            ConfigerHttpClient();

            var response = await _httpClient.GetAsync(_BdayEndpoint);
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync();
            
            
        }

        private  void ConfigerHttpClient()
        {
            _httpClient.BaseAddress = new Uri(_baseUrl);
            _httpClient.DefaultRequestHeaders.Add("Host", _Host);
            _httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _key);
        }
    
    }
}
    

