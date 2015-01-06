using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenReceiptWebApi.DAL.UnitOfWorkInterface
{
    /// <summary>
    /// Encapsulates a unit of work
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Save changes to all objects that have changed within the unit of work
        /// </summary>
        void SaveChanges();
    }
}
