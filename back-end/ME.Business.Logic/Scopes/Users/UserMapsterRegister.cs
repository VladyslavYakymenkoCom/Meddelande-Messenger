using Mapster;
using ME.Business.Logic.Abstraction.Models.Users;
using ME.Data.Models.Users;

namespace ME.Business.Logic.Scopes.Users
{
    public class UserMapsterRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            CreateMessageConfig(config);
        }

        private void CreateMessageConfig(TypeAdapterConfig config)
        {
            config.NewConfig<User, UserModel>()
                .MaxDepth(2);

            config.NewConfig<UserToCreateModel, User>();
            config.NewConfig<UserToUpdateModel, User>();
        }
    }
}
