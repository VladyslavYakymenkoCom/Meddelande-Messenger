using System;
using System.Collections.Generic;

namespace ME.Business.Logic.Abstraction.Models.Chats
{
    public class ChatToCreateModel
    {
        public string Title { get; set; }

        #region Navigation properties
        public IEnumerable<Guid> ParticipantIds { get; set; } = new List<Guid>();
        #endregion
    }
}
