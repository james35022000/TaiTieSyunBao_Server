using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiTieSyunBao_Server
{
    class Order
    {
        public string Key;
        public string UID;
        public List<OrderList> OrderList = new List<OrderList>();
        public PersonalInfo PersonalInfo = new PersonalInfo();

        //Order(string Key, List<OrderList> orderList, PersonalInfo personalInfo)
        //{
            //this.Key = Key;
            //this.OrderList = orderList;
            //this.PersonalInfo = personalInfo;
        //}
    }
}
