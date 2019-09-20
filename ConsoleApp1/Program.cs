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


            Console.WriteLine("Írja be, hány számot kíván megadni: ");
            int[] szam=new int[int.Parse(Console.ReadLine())];

          
           Console.WriteLine("Kerek"+szam.Length+"számot.");

           
            int seged = 0;
            
            for (int i = 0; i < szam.Length; i++) 
            {
                Console.WriteLine("Írja be a "+(i+1)+". számot");
                szam[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < szam.Length; i++) 
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
