using System.Threading.Tasks;

namespace ME.Business.Logic.Abstraction.Interfaces
{
    public interface IUpdateable<in TModel, TRes> where TModel : class
                                                  where TRes : class
    {
        Task<TRes> UpdateAsync(TModel model);
    }
}
