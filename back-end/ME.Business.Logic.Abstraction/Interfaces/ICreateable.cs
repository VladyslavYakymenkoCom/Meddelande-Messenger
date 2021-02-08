using System.Threading.Tasks;

namespace ME.Business.Logic.Abstraction.Interfaces
{
    public interface ICreateable<in TModel, TRes> where TModel : class
                                                  where TRes : class
    {
        Task<TRes> CreateAsync(TModel model);
    }
}
