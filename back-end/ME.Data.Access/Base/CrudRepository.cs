using EntityFrameworkCore.CommonTools;
using ME.Data.Access.Abstractions.Interfaces;
using ME.Data.Access.Context;
using ME.Data.Models.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ME.Data.Access.Base
{
    public abstract class CrudRepository<TEntity> : 
        Repository,
        ICreateable<TEntity>,
        ISearchable<TEntity>,
        IFetchable<TEntity>,
        IDeletable<TEntity>  where TEntity : class, IEntity
    {
        protected DbSet<TEntity> Table;

        public CrudRepository(MeddelandeContext context) : base(context)
        {
            Table = Context.Set<TEntity>();
        }

        public virtual TEntity Create(TEntity entity)
        {
            return Table.Add(entity).Entity;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            return (await Table.AddAsync(entity)).Entity;
        }

        public virtual TEntity First(ISpecification<TEntity> pattern)
        {
            return Table.FirstOrDefault(pattern.ToExpression());
        }

        public virtual async Task<TEntity> FirstAsync(ISpecification<TEntity> pattern)
        {
            return await Table.FirstOrDefaultAsync(pattern.ToExpression());
        }

        public virtual IQueryable<TEntity> GetAll(ISpecification<TEntity> pattern)
        {
            return Table.Where(pattern.ToExpression());
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return Table.AsQueryable();
        }

        public virtual void Remove(TEntity entity)
        {
            Table.Remove(entity);
        }
    }
}
