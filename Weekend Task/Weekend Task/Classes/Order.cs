using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekend_Task.Classes
{
    class Order
    {
        public int ID { get; set; }
        public Client OrderClient{ get; set; }
        public Product OrderProduct{ get; set; }
        public Employee OrderEmployee { get; set; }
        public short Count { get; set; }
        public double TotalPrice { get; set; }
    }
}
