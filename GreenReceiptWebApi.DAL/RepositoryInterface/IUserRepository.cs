using GreenReceiptWebApi.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenReceiptWebApi.DAL.RepositoryInterface
{
    public interface IUserRepository
    {
        void Create(User newUser);

        void Update(User updatedUser);
    }
}
