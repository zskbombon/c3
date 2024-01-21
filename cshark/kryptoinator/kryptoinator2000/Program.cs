using System;

namespace krypto
{
    class Program
    {
        static void Main(string[] args)
        {

            //cezar();
            //slowny();
            //poli();
            //atbasz();
            vigenera();

        }

        static void cezar()
        {
            string czyste, alfabet = "abcdefghijklmnopqrstuvwxyz";
            int kod = 0;
            
            Console.WriteLine("Witaj, wpisz fraze ktora chcesz zakodowac");
            czyste =Console.ReadLine();
            czyste = czyste.ToLower();
            
            Console.WriteLine("podaj kod");
            kod = Convert.ToInt32(Console.ReadLine());
                
            char[] cz_tab = czyste.ToCharArray();

            int[] al_tab = new int[cz_tab.Length];

            for (int i = 0; i < cz_tab.Length; i++)
            {
                al_tab[i] = alfabet.IndexOf(cz_tab[i]) + kod;
                while(al_tab[i] > 25)
                {
                    al_tab[i]-=26;
                }
            }

             for (int i = 0; i < al_tab.Length; i++)
                {
                    if(char.IsWhiteSpace(cz_tab[i]))
                    {
                        System.Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(alfabet[al_tab[i]]);
                    }
                }
            
        }
    
        static void slowny()
        {
            string czyste, kod;
            
            Console.WriteLine("podaj fraze ktora chcesz zakodowac");
            czyste = Console.ReadLine();

            Console.WriteLine("podaj kod(najlepiej parzysty bez powtarzajacych sie liter)");
            kod = Console.ReadLine();

            char[] czt = czyste.ToCharArray();

            for(int i=0; i<czyste.Length; i++)
            {
                for(int j=0; j<kod.Length; j++)
                {
                    if(czyste[i]==kod[j])
                    {
                        if(j%2!=0)
                        {
                            czt[i]=kod[j-1];
                        }
                        else
                        {
                            czt[i]=kod[j+1];
                        }
                        break;
                    }
                }
            }

            System.Console.WriteLine(czt);

        }
    
        static void poli()
        {

           char[,] tl = {{'a', 'b', 'c', 'd', 'e'}, {'f', 'g', 'h', 'i', 'j'}, {'k', 'l', 'm', 'n', 'o'}, {'p', 'r', 's', 't', 'u'}, {'v', 'w', 'x', 'y', 'z'}};

           Console.WriteLine("podaj fraze ktora chcesz zakodowac");
           string czyste = Console.ReadLine();


           for (int i = 1; i < czyste.Length+1; i++)
           {

                for (int j = 1; j < 6; j++)
                {

                    for (int k = 1; k < 6; k++)
                    {

                        if(czyste[i-1] == tl[j-1, k-1])
                        {

                            Console.Write(j + "" + k + " ");

                        }

                    }

                }

           }

        }

        static void atbasz()
        {
            
            string oa="zyxwvutsrqponmlkjihgfedcba", a="abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("podaj fraze ktora chcesz zakodowac");
            string czyste = Console.ReadLine();

            for (int i = 0; i < czyste.Length; i++)
            {

                for (int j = 0; j < oa.Length; j++)
                {


                    if(czyste[i] == a[j])
                    {

                        Console.Write(oa[j]);

                    }

                }

            }

        }

        static void vigenera()
        {
            string alfabet = "abcdefghijklmnopqrstuvwxyz";
            
            Console.WriteLine("podaj fraze ktora chcesz zakodowac");
            string czyste=Console.ReadLine();

            Console.WriteLine("podaj kod");
            string kod=Console.ReadLine();

            for (int i = 0; i < czys


        }
    }
}