using CA3.Client.Pages;

namespace CA3.Server.Services
{
    public interface iBdayinfo
    {
        Task<iBdayinfo<BdayInfo>>GetBdaysinfo();
    }
}
