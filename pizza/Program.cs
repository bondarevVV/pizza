using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peperoni peperoni = new Peperoni();
            peperoni.Name = "Пеперони";
            peperoni.weight = 500;
            peperoni.Testo = "Тонкое";
            peperoni.price = 999;
        }
    }
}