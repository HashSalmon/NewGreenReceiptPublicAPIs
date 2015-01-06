using GreenReceiptWebApi.DAL.UnitOfWorkInterface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenReceiptWebApi.DAL.Repositories
{
    /// <summary>
    /// This class represents a base repository, every repository will
    /// extends from this base repository
    /// </summary>
    public class BaseRepository
    {
        protected IUnitOfWork UnitOfWork { get; set; }

        protected GreenReceiptWebApiDbContext Context
        {
            get { return (GreenReceiptWebApiDbContext)this.UnitOfWork; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitOfWork">Unit of work</param>
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException("unitOfWork");
            }

            this.UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Get a generic Set from database
        /// </summary>
        /// <typeparam name="TEntity">Generic TEntity type</typeparam>
        /// <returns>Return a Set of type TEntity from database</returns>
        protected virtual DbSet<TEntity> GetDbSet<TEntity>() where
            TEntity : class
        {
            return this.Context.Set<TEntity>();
        }

        /// <summary>
        /// Set an entity state 
        /// </summary>
        /// <param name="entity">An entity</param>
        /// <param name="entityState">The entity's state</param>
        protected virtual void SetEntityState(object entity, EntityState entityState)
        {
            this.Context.Entry(entity).State = entityState;
        }
    }
}
