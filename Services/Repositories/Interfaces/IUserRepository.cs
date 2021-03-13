using System.Threading;
using System.Threading.Tasks;
using Services.Repositories;
using Entities.User;

namespace Services.Repositories
{
    public interface IUserRepository:IRepository<UserModel>
    {
        Task<UserModel> GetByUserAndPassAsync(string UserName,string Password,CancellationToken cancellationToken);
        Task AddAsync(UserModel user,string password ,CancellationToken cancellationToken);
    }
}