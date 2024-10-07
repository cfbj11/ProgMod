using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Operation
{
    internal class Operationcs
    {
        public double Sum(double num1, double num2) { return num1 + num2; }

        public double Subst(double num1, double num2) { return num1 - num2; }

        public double Mult(double num1, double num2) { return num1 * num2; }

        public double Divide(double num1, double num2)
        {
            try
            {
                return num1 / num2;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public double Pow(double num1, double num2) { return Math.Pow(num1, num2); }

        public double Sqrt(double num) { return Math.Sqrt(num); }
        public string Out() { return "Adios"; }
    }
}
