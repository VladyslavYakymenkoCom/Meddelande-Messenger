using ME.Business.Logic.Abstraction.Models.Messages;
using ME.Business.Logic.Abstraction.Models.Users;
using System;
using System.Collections.Generic;

namespace ME.Business.Logic.Abstraction.Models.Chats
{
    public class ChatModel
    {
        public Guid Id { get; set; } 

        public string Title { get; set; }
        public bool IsDeactivated { get; set; }

        public DateTime CreatedAt { get; set; }  
        public DateTime? UpdatedAt { get; set; }

        #region Navigation properties
        public ICollection<MessageModel> Messages { get; set; } = new List<MessageModel>();
        public ICollection<UserModel> Participants { get; set; } = new List<UserModel>();
        #endregion
    }
}
