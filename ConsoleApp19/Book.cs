using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp19
{
    internal class Book: Product
    {
        static int _id;
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public override int Id { get; }

        public Book()
        {
            _id++;
            Id = _id;
        }

        public override float Sell()
        {

            if (Count > 0)
            {
                return TotalInCome += Price * Count--;
            }
            else
                return TotalInCome;
        }

        public override void ShowInfo()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"AuthorName : {AuthorName},Id : {Id},Count : {Count},Name : {Name},PageCount : {PageCount},Price :  {Price},TotalInCome : {TotalInCome}";
        }
    }
}
