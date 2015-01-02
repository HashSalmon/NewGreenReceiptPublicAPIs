using GreenReceiptWebApi.DAL.UnitOfWorkInterface;
using MySql.Data.MySqlClient;
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
    public class GreenReceiptWebApiDbContext : DbContext, IUnitOfWork
    {

        public GreenReceiptWebApiDbContext()
#if RELEASE
            : base(new MySqlConnection("Server=54.148.225.22;Database=greenreceipt;Uid=root;Pwd=agrit817!!@@##"), true)
#elif ALEX
            : base(new MySqlConnection("Server=127.0.0.1;Database=greenreceipt;Uid=root;Pwd=Aa8175014"), true)
#else
            : base(new MySqlConnection("Server=127.0.0.1;Database=greenreceipt;Uid=root;Pwd=zheng"), true)
#endif
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

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

        /// <summary>
        /// Allows saving changes via the IUnitOfWork Interface.
        /// </summary>
        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
