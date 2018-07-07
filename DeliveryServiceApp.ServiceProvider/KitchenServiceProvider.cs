using DeliveryServiceApp.Repository;
using DeliveryServiceApp.Repository.Interface;
using DeliveryServiceApp.ServiceProvider.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceApp.ServiceProvider
{
    public class KitchenServiceProvider: IKitchenServiceProvider
    {
        private IKitchenRepository _kitchenRepo;
        public KitchenServiceProvider(string kitchenOwnerEmailId)
        {
            _kitchenRepo = new KitchenRepository(kitchenOwnerEmailId);
        }
        public KitchenServiceProvider(int kitchenId)
        {
            _kitchenRepo = new KitchenRepository(kitchenId);
        }


        //Example methods
        public void SetKitchenMenu()
        {
        }

        public void Dispose()
        {
            _kitchenRepo.Dispose();
        }

    }
}
