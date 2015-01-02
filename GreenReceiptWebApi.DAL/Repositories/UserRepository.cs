using GreenReceiptWebApi.DAL.Model;
using GreenReceiptWebApi.DAL.RepositoryInterface;
using GreenReceiptWebApi.DAL.UnitOfWorkInterface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenReceiptWebApi.DAL.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {

        /// <summary>
        /// The Constructor
        /// </summary>
        /// <param name="unitOfWork">The Unit of work</param>
        public UserRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        /// <summary>
        /// Creates a new user in the repository.
        /// </summary>
        /// <param name="newUser"></param>
        public void Create(User newUser)
        {
            this.GetDbSet<User>().Add(newUser);
            this.UnitOfWork.SaveChanges();
        }

        /// <summary>
        /// Updates an existing user in the repository.
        /// 
        /// (This will only update the user, 
        /// not the rest of the object graph.)
        /// </summary>
        /// <param name="updatedUser">An updated user</param>
        public void Update(User updatedUser)
        {
            var oldUser = this.GetDbSet<User>().Where(u => u.UserId == updatedUser.UserId).First();

            oldUser.FirstName = updatedUser.FirstName;
            oldUser.LastName = updatedUser.LastName;
            oldUser.Email = updatedUser.Email;
            oldUser.Password = updatedUser.Password;

            this.SetEntityState(oldUser, oldUser.UserId == 0
                                            ? EntityState.Added
                                            : EntityState.Modified);

            this.UnitOfWork.SaveChanges();
        }
    }
}
