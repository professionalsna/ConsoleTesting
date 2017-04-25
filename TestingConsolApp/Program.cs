using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.Parse("2017-11-01");
            DateTime endDate = DateTime.Parse("2018-04-30");
            string days = "Sun";
            List<DateTime> dates = new List<DateTime>();
            List<DateTime> months = new List<DateTime>();

            DateTime nstartDate = startDate;
            DateTime nendDate = endDate;

            while (nstartDate <= nendDate)
            {
                // pull out month and year
                months.Add(nstartDate);
                nstartDate = nstartDate.AddMonths(1);
            }


            //for (DateTime dat = startDate; dat <= endDate;dat = dat.AddDays(1.0))
            //{
            //    string dyn = dat.ToString("ddd");
            //    if (dyn==days)
            //    {
            //        dates.Add(dat);
            //    }    
            //    Console.WriteLine(dat.ToShortDateString());
            //}
            while (startDate <= endDate)
            {
                startDate = startDate.AddDays(1.0);
                string dyn = startDate.ToString("ddd");
                if (dyn == days)
                {
                    dates.Add(startDate);
                }
                Console.WriteLine(startDate.ToShortDateString());
            }

            Console.Read();


        }
    }
}
