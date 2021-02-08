using System;
using System.Threading.Tasks;

namespace ME.Business.Logic.Abstraction.Interfaces
{
    public interface IReadable<TRes> where TRes : class
    {
        Task<TRes> GetByIdAsync(Guid id);
    }
}
