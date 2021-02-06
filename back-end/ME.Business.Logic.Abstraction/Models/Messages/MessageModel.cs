using ME.Business.Logic.Abstraction.Enums;
using ME.Business.Logic.Abstraction.Models.Users;
using System;
using System.Collections.Generic;

namespace ME.Business.Logic.Abstraction.Models.Messages
{
    public class MessageModel
    {
        public Guid Id { get; set; } 

        public string Body { get; set; }
        public MessageStates State { get; set; } 
        public bool IsDeactivated { get; set; }

        public DateTime CreatedAt { get; set; } 
        public DateTime? UpdatedAt { get; set; }

        #region Navigation properties
        public UserModel Author { get; set; }
        #endregion
    }
}
