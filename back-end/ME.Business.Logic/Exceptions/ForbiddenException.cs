namespace ME.Business.Logic.Exceptions
{
    public class ForbiddenException : BusinessLogicException
    {
        public ForbiddenException() : base("Action is forbidden.")
        {

        }
    }
}
