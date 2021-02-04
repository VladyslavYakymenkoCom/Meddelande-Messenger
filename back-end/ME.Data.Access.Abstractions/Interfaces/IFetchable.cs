using EntityFrameworkCore.CommonTools;
using System.Linq;

namespace ME.Data.Access.Abstractions.Interfaces
{
    public interface IFetchable<TEntity>
    {
        IQueryable<TEntity> GetAll(ISpecification<TEntity> pattern);
        IQueryable<TEntity> GetAll();
    }
}
