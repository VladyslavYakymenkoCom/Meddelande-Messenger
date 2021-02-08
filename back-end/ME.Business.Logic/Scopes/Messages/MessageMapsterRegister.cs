using Mapster;
using ME.Business.Logic.Abstraction.Models.Messages;
using ME.Data.Models.Messages;

namespace ME.Business.Logic.Scopes.Messages
{
    public class MessageMapsterRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            CreateMessageConfig(config);
        }

        private void CreateMessageConfig(TypeAdapterConfig config)
        {
            config.NewConfig<Message, MessageModel>()
                .MaxDepth(2);

            config.NewConfig<MessageToCreateModel, Message>();
            config.NewConfig<MessageToUpdateModel, Message>();
        }
    }
}
