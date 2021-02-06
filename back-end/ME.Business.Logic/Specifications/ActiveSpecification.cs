using EntityFrameworkCore.CommonTools;
using ME.Data.Models.Abstractions;

namespace ME.Business.Logic.Specifications
{
    public class ActiveSpecification<TEntity> : Specification<TEntity> where TEntity : class, IDeactivateableEntity
    {
        public ActiveSpecification() : base(e => e.IsDeactivated)
        {

        }
    }
}
