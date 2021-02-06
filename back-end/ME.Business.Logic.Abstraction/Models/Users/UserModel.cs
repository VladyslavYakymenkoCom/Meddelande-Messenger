using System;
using System.Collections.Generic;

namespace ME.Business.Logic.Abstraction.Models.Users
{
    public class UserModel
    {
        public Guid Id { get; set; }

        public string Tag { get; set; }
        public bool IsDeactivated { get; set; }

        public DateTime? ActiveAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        #region Navigation properties
        #endregion
    }
}
