using EntityFrameworkCore.CommonTools;
using ME.Data.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace ME.Business.Logic.Specifications.Users
{
    public class UserByTagSpecification : Specification<User>
    {
        public UserByTagSpecification(string tag) : base(u => string.IsNullOrEmpty(tag) || EF.Functions.Like(u.Tag.Trim(), $"%{tag.Trim()}%"))
        {

        }
    }
}
