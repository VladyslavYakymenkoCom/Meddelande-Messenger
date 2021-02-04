namespace ME.Data.Access.Abstractions.Interfaces
{
    public interface IDeletable<TEntity>
    {
        void Remove(TEntity entity);
    }
}
