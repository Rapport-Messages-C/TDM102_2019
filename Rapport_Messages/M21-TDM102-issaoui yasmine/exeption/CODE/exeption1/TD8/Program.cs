using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD8
{
    class Program
    {
        static void Main(string[] args)
        {
            stagiaire[] listeStagiaires = new stagiaire[2];

            stagiaire stg1 = new stagiaire();
            stg1.Id = 1;
            stg1.Nom = "Mdani";
            stg1.Prenom = "ali";
            stg1.Cin = "K0001";
            listeStagiaires[0] = stg1;

            stagiaire stg2 = new stagiaire();
            stg2.Id = 1;
            stg2.Nom = "Mdani";
            stg2.Prenom = "mouad";
            stg2.Cin = "K0002";
            listeStagiaires[1] = stg2;

            foreach(stagiaire stg in listeStagiaires)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("stg : stagiaire " + stg);
                Console.WriteLine("methode ToString : stagiaire " + stg.ToString());
                Console.WriteLine("methode presentation : stagiaire " +stg.presentation());
            
            }
            Console.Read();
        }
    }
}
