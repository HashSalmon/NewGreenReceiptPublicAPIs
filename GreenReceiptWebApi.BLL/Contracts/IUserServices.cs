using GreenReceiptWebApi.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenReceiptWebApi.BLL.Contracts
{
    public interface IUserServices
    {
        User GetOrCreateUser(string claimedId);

        void UpdateUser(User updatedUser);
    }
}
