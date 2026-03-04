using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary < int , string> producto = new Dictionary< int , string>();

            producto.Add(1596, "laptop Gamer");
            producto.Add(2005, " Mouse inalambrico");
            producto.Add(2620,"teclado inalambrico");

            Console.WriteLine(" lista de productos ");

            foreach (var item in producto)
            {

            }

        }
    }
}
