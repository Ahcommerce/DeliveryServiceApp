using DeliveryServiceApp.KitchenDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceApp.Repository.Interface
{
    public interface IKitchenRepository:IDisposable
    {
        Kitchen GetKitchen(int kitchenId);
    }
}
