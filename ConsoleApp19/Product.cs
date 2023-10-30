using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal abstract class Product
    {
        public abstract int Id { get; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }

        protected float TotalInCome { get; set; }

        public abstract float Sell();
        public abstract void ShowInfo();
    }
}
