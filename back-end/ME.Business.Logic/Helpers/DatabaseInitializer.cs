using System.Threading.Tasks;
using ME.Business.Logic.Specifications.Users;
using ME.Data.Access.Abstractions.UnitOfWork;
using ME.Data.Models.Users;

namespace ME.Business.Logic.Helpers
{
    public class DatabaseInitializer
    {
        private readonly IUnitOfWork _unitOfWork;

        public DatabaseInitializer(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Initialize()
        { 
            InitMarcus();
        }

        #region private methods

        private void InitMarcus()
        {
            const string tag = "marcus@fa";

            var user = _unitOfWork.User.FirstAsync(new UserByTagSpecification(tag));
            if (user != null)
                return;

            var saltedPassword = CryptoHelper.GenerateSaltedHash("marcusFa"); 
            _unitOfWork.User.Create(new User
            {
                Tag = tag,
                Salt = saltedPassword.Salt,
                HashPassword = saltedPassword.Hash
            });
            
            _unitOfWork.Commit();
        }
        #endregion
    }
}
