using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenReceiptWebApi.DAL
{
    /// <summary>
    /// The context for the GreenReceiptWebApi database
    /// </summary>
    public class GreenReceiptWebApiDbContext : DbContext
    {

        /// <summary>
        /// This method sets up the database appropriately for the available model objects.
        /// This method only sets up the data tier.
        /// Any shared or model level requirements (data validation, etc) are on the model objects themselves.
        /// </summary>
        /// <param name="modelBuilder">The model builder object for creating the data model</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            SetupUserEntity(modelBuilder);
        }

        /// <summary>
        /// Set up user entity
        /// </summary>
        /// <param name="modelBuilder">The model builder object for setting up the data model</param>
        private static void SetupUserEntity(DbModelBuilder modelBuilder)
        {

        }
    }
}
