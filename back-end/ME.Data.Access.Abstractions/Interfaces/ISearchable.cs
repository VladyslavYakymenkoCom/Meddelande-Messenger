using EntityFrameworkCore.CommonTools;
using System.Threading.Tasks;

namespace ME.Data.Access.Abstractions.Interfaces
{
    public interface ISearchable<TEntity>
    {
        Task<TEntity> FirstAsync(ISpecification<TEntity> pattern);
        TEntity First(ISpecification<TEntity> pattern);
    }
}
