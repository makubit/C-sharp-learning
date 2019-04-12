using System;

namespace Study01
{
    public class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying principal");
        }
    }
}