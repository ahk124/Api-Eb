using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Common.Utilities;
using Data;
using Data.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Services.Repository
{
    public class UserRepository : Repository<UserModel>
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<UserModel> GetByUserAndPassAsync(string UserName,string Password,CancellationToken cancellationToken)
        {
            var passwordHash=SecurityHelper.GetSha256Hash(Password);
            return await Table.Where(p=>p.UserName==UserName && p.PasswordHash==Password).SingleOrDefaultAsync(cancellationToken);

        }
    }
}