namespace CA3.Server.Services
{
    public class BdayinfoService : iBdayinfo
    {
        private readonly HttpClient httpClient;
        public BdayinfoService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task<iBdayinfo> GetBdaysinfo()
        {
            throw new NotImplementedException();
        }
    }
}
