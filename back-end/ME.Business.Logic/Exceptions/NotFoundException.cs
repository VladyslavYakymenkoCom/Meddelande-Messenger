namespace ME.Business.Logic.Exceptions
{
    public class NotFoundException : BusinessLogicException
    {
        public NotFoundException() : base($"Resource not found.")
        {

        }
    }
}
