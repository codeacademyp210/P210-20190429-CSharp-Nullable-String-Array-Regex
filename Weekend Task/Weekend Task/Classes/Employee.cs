using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekend_Task.Classes
{
    class Employee : Person
    {
        private static int EID = 0;
        
        public int GetID()
        {
            EID++;
            return EID;
        }

        public string Position { get; set; }
        public double Salary { get; set; }
    }
}
