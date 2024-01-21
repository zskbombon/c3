using System;
using System.Runtime.CompilerServices;

namespace gsn
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] T;
            string klasa;
            int klasaint, lvl, nlvl, exp, monety, hp, zre, sila=1, bron=0;
//level, kasa, exp do zrobienia 
            do
                {
                    Console.WriteLine("wybierz klase:\n1. Samurai\n2. Ninja");
                    klasa = Console.ReadLine();
                    klasaint = Convert.ToInt32(klasa);
                }while(klasaint != 1 && klasaint != 2);

            if(klasaint==1)
                {
                    klasa="samuraj";
                    hp=200;
                    bron=10;
                    zre=2;
                }
            else
                {
                    klasa="ninja";
                    hp=100;
                    bron=5;
                    zre=5;
                }
            Console.WriteLine("twoja klasa to: " + klasa + "\n twoje statystyki to:\n" + hp + "\n" + bron + "\n" + zre);

            System.Console.WriteLine();
            Console.WriteLine("zadajesz " + dmg(sila, bron));


           
        }
/*
        static void walka(int dmg, )
        {

            

        }
*/
        static int dmg(int sila, int bron)
        {
            Random generator = new Random();
            return sila * bron* generator.Next(11);
        }
    

    }
}
