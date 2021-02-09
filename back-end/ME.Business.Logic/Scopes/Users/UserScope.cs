using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mapster;
using ME.Business.Logic.Abstraction.Models.Users;
using ME.Business.Logic.Abstraction.Scopes.Users;
using ME.Business.Logic.Exceptions;
using ME.Business.Logic.Specifications;
using ME.Data.Access.Abstractions.UnitOfWork;
using ME.Data.Models.Users;

namespace ME.Business.Logic.Scopes.Users
{
    public class UserScope : IUserScope
    {
        #region Dependencies
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        public UserScope(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Crud
        public async Task<UserModel> GetByIdAsync(Guid id)
        {
            var user = await _unitOfWork.User.FirstAsync(
                new ByIdSpecification<User>(id)
                && new ActiveSpecification<User>()
            );
            if (user is null)
                throw new NotFoundException();

            return user.Adapt<UserModel>();
        }

        public async Task<UserModel> CreateAsync(UserToCreateModel model)
        {
            model.ValidateAndThrow();

            var entityToCreate = model.Adapt<User>();
            var user = await _unitOfWork.User.CreateAsync(entityToCreate);

            // TODO: Add hashing.
            // user.HashPassword =
            // user.Salt = 

            await _unitOfWork.CommitAsync();
            return await GetByIdAsync(user.Id);
        }

        public async Task<UserModel> UpdateAsync(UserToUpdateModel model)
        {
            model.ValidateAndThrow();

            var user = await _unitOfWork.User.FirstAsync(new ByIdSpecification<User>(model.Id));
            if (user is null)
                throw new NotFoundException();

            user.Tag = model.Tag;
            user.UpdatedAt = DateTime.UtcNow;

            await _unitOfWork.CommitAsync();
            return await GetByIdAsync(user.Id);
        }

        public void Delete(Guid id)
        {
            var user = _unitOfWork.User.First(new ByIdSpecification<User>(id));
            if (user is null)
                throw new NotFoundException();

            user.UpdatedAt = DateTime.UtcNow;
            user.IsDeactivated = true;

            _unitOfWork.Commit();
        }
        #endregion
    }
}
