using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monto_disponible
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este programa procesa si puede hacer un retiro siempre y cuando el monto soporte

            double monto, retiro, balance;

            monto = 18765.43;

            Console.WriteLine("Digite la cantidad que desea retirar");
            retiro= Convert.ToDouble(Console.ReadLine());

            balance = monto - retiro;

            if (retiro> monto)
            {
                Console.WriteLine("No tiene balance disponible para retirar....intente otra cantidad!!!");

            } else if( retiro <= monto)
            {
                Console.WriteLine("SU BALANCE ACTUAL ES DE " + balance);
                
            }
            Console.ReadLine();







        }
    }
}
