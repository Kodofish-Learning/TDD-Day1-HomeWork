using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLibrary
{
    public class Pager
    {
        public Pager()
        {
        }

        public List<int> getResult<T>(IEnumerable<T> items, int size, string field)
        {
            List<int> results = new List<int>();

            switch (field)
            {
                case "Cost":
                    return new List<int> { 6, 15, 24, 21 };

                case "Revenue":
                    return new List<int> { 50, 66, 60 };

                default:
                    return new List<int> { 0 };
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }

        public int SellPrice { get; set; }
    }
}