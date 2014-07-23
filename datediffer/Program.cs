using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datediffer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateDiffer = new DateDiffer(new DateTime(2014, 7, 24));

            var monthsUntil = dateDiffer.MonthsUntil();
            var daysUntil = dateDiffer.DaysUntil();

            Console.WriteLine("{0} months, {1} days", monthsUntil, daysUntil);

            Console.WriteLine("verification: {0}", dateDiffer.Verify(monthsUntil,daysUntil));
            Console.ReadKey();
        }
    }
}
