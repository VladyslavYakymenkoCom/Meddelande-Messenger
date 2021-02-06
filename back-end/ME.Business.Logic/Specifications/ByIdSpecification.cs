using EntityFrameworkCore.CommonTools;
using ME.Data.Models.Abstractions;
using System;

namespace ME.Business.Logic.Specifications
{
    public class ByIdSpecification<TEntity> : Specification<TEntity> where TEntity : class, IEntity
    {
        public ByIdSpecification(Guid id) : base(e => e.Id == id)
        {

        }
    }
}
