using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtensionMethods;

namespace ExtensionMethods
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Extension Methods *****\n");
            
            //The in thas assumed a new identity
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();

            //So has the data set
            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();

            //use new integer functionality
            Console.WriteLine("Value of myIn: {0}", myInt);
            Console.WriteLine("Reversed digits of myInt: {0}", myInt.ReverseDigits());

            Console.ReadLine();
        }

    }
}
