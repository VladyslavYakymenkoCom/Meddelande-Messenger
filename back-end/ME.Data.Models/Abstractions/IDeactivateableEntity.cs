namespace ME.Data.Models.Abstractions
{
    public interface IDeactivateableEntity
    {
        public bool IsDeactivated { get; set; }
    }
}
