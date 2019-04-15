using System.Collections.Generic;

namespace Study01
{
    interface IPayee
    {
        void Pay();
    }
    public class PayRoll
    {
        List<IPayee> payees = new List<IPayee>();

        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
            Logger.Log("Payroll started started", "Payroll");

        }
        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }

            Logger.Log("PayAll Completed", "PayRoll", 2);
        }
    }
}