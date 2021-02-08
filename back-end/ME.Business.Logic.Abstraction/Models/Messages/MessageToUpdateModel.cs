using System;
using FluentValidation;
using ME.Business.Logic.Abstraction.Validators.Messages;

namespace ME.Business.Logic.Abstraction.Models.Messages
{
    public class MessageToUpdateModel
    {
        public Guid Id { get; set; }  

        public string Body { get; set; }
        #region Navigation properties
        #endregion

        public void ValidateAndThrow()
        {
            new MessageToUpdateModelValidator().ValidateAndThrow(this);
        }
    }
}
