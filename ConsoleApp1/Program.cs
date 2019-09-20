using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            //usertől 10 számot
            //keressük meg, írjuk ki a legnagyobbat
            //módosítsuk a programot, user darabszám is bekérhető legyen
            //legnagyobb mellett a legkisebbet is
            //hiba üzenet
            
           Console.WriteLine("Adjon meg 10 számot!");
            int[] szam=new int[10];
            int seged = 0;
            
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Írja be a "+(i+1)+". számot");
                szam[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 10; i++) 
            {
                if (seged<szam[i]) {
                    seged = szam[i];

                }
            }
            Console.WriteLine("A legnagyobb szám: "+seged);

                       
            
            Console.ReadLine();


        }
    }
}
