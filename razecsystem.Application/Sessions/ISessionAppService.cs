using System.Threading.Tasks;
using Abp.Application.Services;
using razecsystem.Sessions.Dto;

namespace razecsystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
