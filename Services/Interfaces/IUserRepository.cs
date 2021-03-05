using System.Threading;
using System.Threading.Tasks;
using Data.Repositories;
using Entities.User;

namespace Services.Repository
{
    public interface IUserRepository:IRepository<UserModel>
    {
        Task<UserModel> GetByUserAndPassAsync(string UserName,string Password,CancellationToken cancellationToken);
    }
}