using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WebApplication9.Database;

namespace WA9Service
{
    
    [ServiceContract]
    interface IWA9Service
    {
        [OperationContract]
        List<Item> getAllItems();

        [OperationContract]
        String insertItem(Item item);

        [OperationContract]
        void testFunction();
    }
}
