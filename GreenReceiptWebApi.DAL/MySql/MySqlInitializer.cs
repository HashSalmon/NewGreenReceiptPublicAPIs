using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenReceiptWebApi.DAL.MySql
{
    //public class MySqlInitializer : IDatabaseInitializer<ApplicationDbContext>
    //{
    //    public void InitializeDatabase(ApplicationDbContext context)
    //    {
    //        if (!context.Database.Exists())
    //        {
    //            context.Database.Create();
    //        }
    //        else
    //        {
    //            var migrationHistoryTableExists = ((IObjectContextAdapter)context).ObjectContext.ExecuteStoreQuery<int>(
    //                string.Format("SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '{0}' AND table_name = '__MigrationHistory'", "greenreceipt"));

    //            if (migrationHistoryTableExists.FirstOrDefault() == 0)
    //            {
    //                context.Database.Delete();
    //                context.Database.Create();
    //            }
    //        }
    //    }
    //}
}
