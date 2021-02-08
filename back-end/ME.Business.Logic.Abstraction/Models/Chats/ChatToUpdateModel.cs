using System;
using FluentValidation;
using ME.Business.Logic.Abstraction.Validators.Chats;

namespace ME.Business.Logic.Abstraction.Models.Chats
{
    public class ChatToUpdateModel
    {
        public Guid Id { get; set; }  

        public string Title { get; set; }
        public bool IsDeactivated { get; set; }

        #region Navigation properties
        #endregion

        public void ValidateAndThrow()
        {
            new ChatToUpdateModelValidator().ValidateAndThrow(this);
        }
    }
}
