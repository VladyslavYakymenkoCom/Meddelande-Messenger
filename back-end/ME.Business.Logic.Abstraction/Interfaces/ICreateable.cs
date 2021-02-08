using System.Threading.Tasks;

namespace ME.Business.Logic.Abstraction.Interfaces
{
    // TODO: Create User context or decorator for Auth.
    public interface ICreateable<in TModel, TRes> where TModel : class
                                                  where TRes : class
    {
        Task<TRes> CreateAsync(TModel model);
    }
}
