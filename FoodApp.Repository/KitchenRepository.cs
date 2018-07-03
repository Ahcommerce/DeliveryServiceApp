using FoodApp.KitchenDb;
using FoodApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Repository
{
    public class KitchenRepository:RepositoryBase, IKitchenRepository
    {
        public KitchenRepository(string kitchenOwnerEmail):base(FoodAppDbType.Kitchen, kitchenOwnerEmail)
        {
        }
        public KitchenRepository(int kitchenId) : base(FoodAppDbType.Kitchen, kitchenId)
        {
        }


        public Kitchen GetKitchen(int kitchenId)
        {
           return this.Get<Kitchen>(p => p.KitchenId == kitchenId).SingleOrDefault();
        }

        
    }
}
