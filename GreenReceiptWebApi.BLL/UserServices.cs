using GreenReceiptWebApi.BLL.Contracts;
using GreenReceiptWebApi.BLL.Models;
using GreenReceiptWebApi.DAL.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenReceiptWebApi.BLL
{
    public class UserServices : IUserServices
    {
        /// <summary>
        /// The user repository interface
        /// </summary>
        private readonly IUserRepository userRepository;

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="userRepository"></param>
        public UserServices(IUserRepository userRepository)
        {
            if (userRepository == null)
            {
                throw new ArgumentNullException("userRepository");
            }

            this.userRepository = userRepository;
        }

        public User GetOrCreateUser(string claimedId)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(User newUser)
        {
            if (newUser == null)
            {
                throw new ArgumentNullException("newUser");
            }

            try
            {
                GreenReceiptWebApi.DAL.Model.User userToAdd = ToDataModelUser(newUser);
                this.userRepository.Create(userToAdd);
                return ToServiceUser(userToAdd);
            }
            catch (InvalidOperationException ex)
            {
                //throw new BusinessServicesException(Resources.UnableToCreateUserExceptionMessage, ex);
                throw new Exception("CreateUser");
            }
        }

        public void UpdateUser(User updatedUser)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Convert BLL.Model.User to DAL.Model.User
        /// </summary>
        /// <param name="userToConvert">DAL.Model.User</param>
        /// <returns>Return BLL.Model.User</returns>
        internal static GreenReceiptWebApi.DAL.Model.User ToDataModelUser(User userToConvert)
        {
            if (userToConvert == null)
            {
                return null;
            }

            GreenReceiptWebApi.DAL.Model.User modelUser = new GreenReceiptWebApi.DAL.Model.User()
            {
                UserId = userToConvert.UserId,
                FirstName = userToConvert.FirstName,
                LastName = userToConvert.LastName,
                Email = userToConvert.Email,
                Password = userToConvert.Password,
                Username = userToConvert.Username,
            };

            return modelUser;
        }

        /// <summary>
        /// Convert DAL.Model.User to BLL.Model.User
        /// </summary>
        /// <param name="dataModelUser">DAL.Model.User</param>
        /// <returns>Return BLL.Model.User</returns>
        internal static User ToServiceUser(GreenReceiptWebApi.DAL.Model.User dataModelUser)
        {
            if (dataModelUser == null)
            {
                return null;
            }

            User user = new User()
            {
                UserId = dataModelUser.UserId,
                FirstName = dataModelUser.FirstName,
                LastName = dataModelUser.LastName,
                Email = dataModelUser.Email,
                Password = dataModelUser.Password,
                Username = dataModelUser.Username,
            };

            return user;
        }
    }
}
