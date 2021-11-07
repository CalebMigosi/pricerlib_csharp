using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricerlib
{
    public class Option
    {
        private double S0, K, vol, r, T, b;
        private string optionType;

        public Option(string optionType, double S0, double K, double vol, double r, double T, double b)
        {
            this.optionType = optionType;
            this.S0 = S0;
            this.K = K;
            this.vol = vol;
            this.r = r;
            this.T = T;
            this.b = b;
        }

        public override string ToString()
        {
            return string.Format("Option: \n " +
                "Option Type: {0} \n " +
                "Spot: {1} \n " +
                "Strike: {2} \n" +
                "Volatility: {3} \n" +
                "Rate: {4} \n" +
                "Time to Maturity: {5} \n" +
                "Cost of carry: {6} \n" +
                "", optionType, S0, K, vol, r, T, b);
        }
    }
}
