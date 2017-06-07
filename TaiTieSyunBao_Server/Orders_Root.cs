using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiTieSyunBao_Server
{
    class Orders_Root
    {
        public List<Order> Orders = new List<Order>();

        public Boolean isExist(string Key)
        {
            for(int i = 0; i < Orders.Count; i++)
            {
                if (Orders[i].Key.Equals(Key))
                    return true;
            }
            return false;
        }
    }
}
