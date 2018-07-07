using DeliveryServiceApp.KitchenDb;
using DeliveryServiceApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceApp.Repository
{
    public class KitchenRepository:RepositoryBase, IKitchenRepository
    {
        public KitchenRepository(string kitchenOwnerEmail):base(DeliveryServiceAppDbType.Kitchen, kitchenOwnerEmail)
        {
        }
        public KitchenRepository(int kitchenId) : base(DeliveryServiceAppDbType.Kitchen, kitchenId)
        {
        }


        public Kitchen GetKitchen(int kitchenId)
        {
           return this.Get<Kitchen>(p => p.KitchenId == kitchenId).SingleOrDefault();
        }

        
    }
}
