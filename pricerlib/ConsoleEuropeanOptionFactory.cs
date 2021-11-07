using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricerlib
{
    public class ConsoleEuropeanOptionFactory : IOptionFactory
    {
        public Option create()
        {
            string optionType;

            double r;
            double vol;
            double K;
            double S0;
            double T;
            
            // Cost of carry
            double b;

            // User input 
            Console.WriteLine("Spot Price");
            S0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Strike Price");
            K = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Volatility");
            vol = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Interest Rate");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Time to Maturity");
            T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cost of carry");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Option Type: 1.Call , 2.Put");
            optionType = Convert.ToString(Console.ReadLine());

            // Create option
            Option opt = new(optionType, S0, K, vol, r, T, b);

            return opt;

        }
    }
}
