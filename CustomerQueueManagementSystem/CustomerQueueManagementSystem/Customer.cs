using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerQueueManagementSystem
{
    class Customer
    {
        public string Name { set; get; }
        public string Complain { set; get; }
        public int SerialNo { private set; get; }
         public Customer(int serialNo,string name, string complain)
         {
            SerialNo = serialNo;
            Name = name;
            Complain = complain;
            
        }


      
    }
}
