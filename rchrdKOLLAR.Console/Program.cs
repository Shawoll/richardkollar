using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = (DateTime?)null;
            var b = "";
            var c = string.Empty;
            var d = "22/07/2019";
            var e = new DateTime(2019, 3, 15);
            var f = new DateTime();

            // System.FormatException string was not recognised as valid DateTime
            //var dta = DateTime.ParseExact(b, "u", CultureInfo.InvariantCulture, DateTimeStyles.None);
            //var dtb = DateTime.ParseExact(c, "u", CultureInfo.InvariantCulture, DateTimeStyles.None);
            //var dtc = DateTime.ParseExact(d, "u", CultureInfo.InvariantCulture, DateTimeStyles.None);
            var dtd = DateTime.ParseExact(e.ToUniversalTime().ToString("u"), "u", CultureInfo.InvariantCulture, DateTimeStyles.None);
            var dtf = DateTime.ParseExact(f.ToUniversalTime().ToString("u"), "u", CultureInfo.InvariantCulture, DateTimeStyles.None);
            //var dta = DateTime.ParseExact(a.ToUniversalTime().ToString("u"), "u", CultureInfo.InvariantCulture, DateTimeStyles.None);

            Console.WriteLine(dtd);
            Console.WriteLine(dtf);

            Console.WriteLine("Hello World!");
        }
    }
}
