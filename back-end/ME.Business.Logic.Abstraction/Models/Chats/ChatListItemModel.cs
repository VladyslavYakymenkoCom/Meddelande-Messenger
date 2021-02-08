using System;
using ME.Business.Logic.Abstraction.Models.Messages;

namespace ME.Business.Logic.Abstraction.Models.Chats
{
    public class ChatListItemModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public DateTime CreatedAt { get; set; }

        #region Navigation properties
        public MessageModel PreviewMessage { get; set; }
        #endregion
    }
}
