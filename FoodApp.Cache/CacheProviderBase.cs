using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceApp.Cache
{
    public class CacheProviderBase
    {
        public T GetEntity<T>(string key)
        {
            throw  new NotImplementedException();
        }

        public bool KeepEntity<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
