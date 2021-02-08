using System.Linq;
using Mapster;
using ME.Business.Logic.Abstraction.Models.Chats;
using ME.Data.Models.Chats;

namespace ME.Business.Logic.Scopes.Chats
{
    public class ChatMapsterRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            CreateChatConfig(config);
        }

        private void CreateChatConfig(TypeAdapterConfig config)
        {
            config.NewConfig<Chat, ChatListItemModel>()
                .Map(m => m.PreviewMessage, e => e.Messages.FirstOrDefault())
                .MaxDepth(2);

            config.NewConfig<Chat, ChatModel>()
                .Map(m => m.Participants, e => e.Participants.Select(p => p.User))
                .MaxDepth(4);

            config.NewConfig<ChatToCreateModel, Chat>();
            config.NewConfig<ChatToUpdateModel, Chat>();
        }
    }
}
