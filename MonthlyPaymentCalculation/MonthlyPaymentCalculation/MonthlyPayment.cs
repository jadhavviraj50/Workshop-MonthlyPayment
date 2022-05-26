using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyPaymentCalculation
{
    public class MonthlyPayment
    {
        public void comp()
        {
            double P, R, n, r, ci;
            int Y;

            Console.WriteLine("Enter Principal");
            P = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Year");
            Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter rate");
            R = Convert.ToDouble(Console.ReadLine());

            n = 12 * Y;
            r = R / (12 * 100);
            ci = (P * r) / (1 - Math.Pow((1 + r), -n));

            Console.WriteLine("Monthly Payment have to pay over years : " + ci);

        }
    }
}
