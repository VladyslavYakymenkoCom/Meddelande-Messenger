using System;
using FluentValidation;
using ME.Business.Logic.Abstraction.Validators.Messages;

namespace ME.Business.Logic.Abstraction.Models.Messages
{
    public  class MessageToCreateModel
    {
        public Guid AuthorId { get; set; }

        public string Body { get; set; }

        #region Navigation properties
        #endregion

        public void ValidateAndThrow()
        {
            new MessageToCreateModelValidator().ValidateAndThrow(this);
        }
    }
}
