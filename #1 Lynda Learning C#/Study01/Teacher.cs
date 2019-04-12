using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study01
{
    class Teacher : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying teacher");
        }
    }
}
