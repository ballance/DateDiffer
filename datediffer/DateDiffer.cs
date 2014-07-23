using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datediffer
{
    public class DateDiffer
    {
        private DateTime _endDateTime;
        public DateDiffer(DateTime setEndDateTime)
        {
            _endDateTime = setEndDateTime;
        }

        public TimeSpan TimespanUntil()
        {
            return DateTime.Now - _endDateTime;
        }

        public int DaysUntil()
        {
            //if (DateTime.Now.Month != _endDateTime.Month)
            //    return _endDateTime.Day - 1;
            //else 
            return _endDateTime.Day - DateTime.Now.Day;
        }

        /// <summary>
        /// This is not trivial...
        /// </summary>
        /// <returns></returns>
        public int MonthsUntil()
        {
            var monthses = new List<Months>();

            var monthCount = 0;

            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;
                        
            var runningMonth = DateTime.Now.Month;
            var runningYear = DateTime.Now.Year;

            foreach (var year in Enumerable.Range(currentYear, _endDateTime.Year-currentYear+1))
            {
                Console.WriteLine(year);
                if ((currentYear == (_endDateTime.Year-1)))
                {
                    monthCount += Enumerable.Range(currentMonth, 12).Count();
                }
                else if (currentYear == _endDateTime.Year)
                {
                    monthCount += Enumerable.Range(currentMonth, _endDateTime.Month-currentMonth).Count();
                }
                else if (currentYear < (_endDateTime.Year - 1))
                {
                    monthCount += 12;
                }
            }

            return monthCount;
        }

        public string Verify(int months, int days)
        {
            var diff = DateTime.Now.AddMonths(months).AddDays(days);
            return diff.ToString(CultureInfo.InvariantCulture);
        }
    }

    public class Months
    {
        public int Year { get; set; }

        public int Month { get; set; }
    }
}
