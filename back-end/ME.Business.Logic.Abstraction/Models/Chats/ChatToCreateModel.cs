using System;
using System.Collections.Generic;
using FluentValidation;
using ME.Business.Logic.Abstraction.Validators.Chats;

namespace ME.Business.Logic.Abstraction.Models.Chats
{
    public class ChatToCreateModel
    {
        public string Title { get; set; }

        #region Navigation properties
        public IEnumerable<Guid> ParticipantIds { get; set; } = new List<Guid>(); // TODO: Add Creator;
        #endregion

        public void ValidateAndThrow()
        {
            new ChatToCreateModelValidator().ValidateAndThrow(this);
        }
    }
}
