using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Classes
{
    public class EDM
    {
        public static CUSTOMER_SQLEntities DBEntity()
        {
            return new CUSTOMER_SQLEntities();
        }
    }
}
