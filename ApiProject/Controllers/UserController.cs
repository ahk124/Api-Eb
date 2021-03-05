using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Entities.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Repository;
using WebFramework.Api;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;

        }
        [HttpGet]
        public async Task<ApiResult<List<UserModel>>> Get(CancellationToken cancellationToken)
        {
            var users = await _userRepository.TableNoTracking.ToListAsync(cancellationToken);
            return new ApiResult<List<UserModel>>
            {
                IsSuccess = true,
                StatusCode = ApiResultStatusCode.success,
                Message = "عملیات با موفقیت انجام شد",
                Data = users
            };
        }

        [HttpGet("{id:int}")]
        public async Task<ApiResult<UserModel>> Get(int id, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(cancellationToken, id);
            return new ApiResult<UserModel>
            {
                IsSuccess = true,
                StatusCode = ApiResultStatusCode.success,
                Message = "عملیات با موفقیت انجام شد",
                Data = user
            };
        }

        [HttpPost]
        public async Task<ApiResult> Create([FromBody] UserModel user, CancellationToken cancellationToken)
        {
            await _userRepository.AddAsync(user, cancellationToken);
            return new ApiResult<UserModel>
            {
                IsSuccess = true,
                StatusCode = ApiResultStatusCode.success,
                Message = "عملیات با موفقیت انجام شد",
            };
        }

        [HttpPut("{id}")]
        public async Task<ApiResult> Update(int id, [FromBody] UserModel user, CancellationToken cancellationToken)
        {
            var userUpdate = await _userRepository.GetByIdAsync(cancellationToken, id);
            userUpdate.UserName = user.UserName;
            userUpdate.PasswordHash = user.PasswordHash;
            userUpdate.Age = user.Age;
            userUpdate.Gender = user.Gender;
            userUpdate.IsActive = user.IsActive;
            userUpdate.LastLoginDate = user.LastLoginDate;
            await _userRepository.UpdateAsync(userUpdate, cancellationToken);
            return new ApiResult<UserModel>
            {
                IsSuccess = true,
                StatusCode = ApiResultStatusCode.success,
                Message = "عملیات با موفقیت انجام شد",
                Data = user
            };
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult> Delete(int id, CancellationToken cancellationToken)
        {
            var userDelete = await _userRepository.GetByIdAsync(cancellationToken, id);
            await _userRepository.DeleteAsync(userDelete, cancellationToken);
             return new ApiResult<UserModel>
            {
                IsSuccess = true,
                StatusCode = ApiResultStatusCode.success,
                Message = "عملیات با موفقیت انجام شد",
            };
        }
    }
}