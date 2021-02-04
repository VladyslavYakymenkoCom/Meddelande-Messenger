using System.Threading.Tasks;

namespace ME.Data.Access.Abstractions.Interfaces
{
    public interface ICreateable<TEntity>
    {
        Task<TEntity> CreateAsync(TEntity entity);
        TEntity Create(TEntity entity);
    }
}
