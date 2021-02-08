using System;

namespace ME.Business.Logic.Abstraction.Interfaces
{
    public interface IDeleteable
    {
        void Delete(Guid id);
    }
}
