using System;
using System.Collections.Generic;

namespace ME.Business.Logic.Abstraction.Models.Messages
{
    public class MessageToUpdateModel
    {
        public Guid Id { get; set; }  

        public string Body { get; set; }
        #region Navigation properties
        #endregion
    }
}
