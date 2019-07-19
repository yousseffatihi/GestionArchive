using DAO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Classe c = new ClasseDAO().GetClasse(1);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
