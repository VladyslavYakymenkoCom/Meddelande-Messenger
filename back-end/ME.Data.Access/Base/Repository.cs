using ME.Data.Access.Context;

namespace ME.Data.Access.Base
{
    public abstract class Repository
    {
        protected MeddelandeContext Context;

        public Repository(MeddelandeContext context)
        {
            Context = context;
        }
    }
}
