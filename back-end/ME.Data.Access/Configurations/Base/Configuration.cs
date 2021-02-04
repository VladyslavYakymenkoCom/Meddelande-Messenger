namespace ME.Data.Access.Configurations.Base
{
    public abstract class Configuration
    {
        protected int MaxTagLength = 100;
        protected int MaxTitleLength = 255;
        protected int MaxBodyLength = 1024;
        protected int MaxHashLength = 1024;
        protected int MaxSaltLength = 512;
    }
}
