using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Common.Utilities;
using Data;
using Services.Repositories;
using Entities;
using Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Services.Repositories
{
    public class UserRepository : Repository<UserModel>,IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public  Task<UserModel> GetByUserAndPassAsync(string UserName,string Password,CancellationToken cancellationToken)
        {
            var passwordHash=SecurityHelper.GetSha256Hash(Password);
            return  Table.Where(p=>p.UserName==UserName && p.PasswordHash==Password).SingleOrDefaultAsync(cancellationToken);

        }
        public  Task AddAsync(UserModel user,string password ,CancellationToken cancellationToken)
        {
            var passwordHash=SecurityHelper.GetSha256Hash(password);
            user.PasswordHash=passwordHash;
            return base.AddAsync(user,cancellationToken);
        }
    }
}