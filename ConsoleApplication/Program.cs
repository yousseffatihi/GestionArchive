using ClassLibrary;
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
            /* UNDONE AnneeScolaireDAO */
            var rs = new AnneeScolaireDAO().GetAnneeScolaires();
            //
            //var etudiant = new EtudiantDAO().GetEtudiant(1);
            foreach (var item in rs)
            {
                Console.WriteLine(item + " " + item.Classe + " " + item.Etudiant);
            }
            Console.ReadLine();

        }
    }
}
