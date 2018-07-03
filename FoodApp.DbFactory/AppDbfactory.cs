using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.DbFactory
{
    public class AppDbfactory
    {
        public static DbContext GetDefaultCentralContext
        {
            get
            {
                return new CenteralDb.CentralDbContext();
            }
        }

        public static DbContext GetDefaultKitchenContext { get
            {
                //You may decide a to go with a different kitchen Db with differnt connection string
                return new KitchenDb.KitchenDbContext();
            }
        }

        public static DbContext GetSpecificKitchenContext(string kitchenOwnerEmail)
        {
            var kitchenContext = new KitchenDb.KitchenDbContext();
            using (var centerDbContext = new CenteralDb.CentralDbContext())
            {
                var kitchenMapping= centerDbContext.KitchenMappings.Where(k => k.KitchenOwnerEmail == kitchenOwnerEmail).FirstOrDefault();
                if (kitchenMapping != null)// you may cache kitchenMapping
                {
                    kitchenContext = new KitchenDb.KitchenDbContext(kitchenMapping.DbInstance);
                }
            }

            return kitchenContext;
        }
        public static DbContext GetSpecificKitchenContext(int kitchenId)
        {
            var kitchenContext = new KitchenDb.KitchenDbContext();
            using (var centerDbContext = new CenteralDb.CentralDbContext())
            {
                var kitchenMapping = centerDbContext.KitchenMappings.Where(k => k.KitchenId == kitchenId).FirstOrDefault();
                if (kitchenMapping != null)// you may cache kitchenMapping
                {
                    kitchenContext = new KitchenDb.KitchenDbContext(kitchenMapping.DbInstance);
                }
            }

            return kitchenContext;
        }
    }
}
