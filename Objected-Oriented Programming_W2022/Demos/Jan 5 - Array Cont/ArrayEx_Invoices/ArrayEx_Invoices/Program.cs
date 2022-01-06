using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx_Invoices
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] invoices = new decimal[5];
            decimal total = 0;

            for (int i = 0; i < invoices.Length; i++)
            {
                Console.Write($"Enter the total of invoice #{i+1}: ");
                invoices[i] = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("***** Using a for loop *****");
            Console.WriteLine();

            //for (int i = 0; i < invoices.Length; i++)
            //{
            //    Console.WriteLine(invoices[i].ToString("c"));
            //    total += invoices[i];
            //}

            //Console.WriteLine($"Total: {total:c}");

            foreach(decimal invoice in invoices)
            {
                total += invoice;
                Console.WriteLine(invoice.ToString("c"));
            }

            Console.WriteLine($"Average: {total / invoices.Length:c}");

            Console.ReadLine();
        }
    }
}
