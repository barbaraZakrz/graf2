using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;

namespace Graf
{
    public class Wezel
    {
        //suma punktów na dany moment gry 
        public int suma;

        //lista, w której są dzieci danego węzła
        public List<Wezel> dzieci = new List<Wezel>();

        //informacja czy to ruch protagonisty czy antagonisty 1 dla prot 0 dla ant
        public bool czyjRuch;

        public Wezel(int suma2, bool czyjRuch2)
        {

            suma = suma2;
            czyjRuch = czyjRuch2;

        }
    }

    internal class Program
    {
        
        static void gen(Wezel wierz, List<Wezel> lista)
        {
            //mozliwe zetony
            int[] zetony = new int[] {4,5,6};
            if (wierz.suma > 21)
            {
                return;
            }

            foreach (int i in zetony)
            {
                Wezel dziecko = new Wezel(wierz.suma + i, !wierz.czyjRuch);
                gen(dziecko, lista);
                lista.Add(dziecko);
                wierz.dzieci.Add(dziecko);
            }
        }
        
        



        public static void Main(string[] args)
        {
            
            //pierwszy wezel 
            List<Wezel> lista = new List<Wezel>();
            Wezel wierz = new Wezel(0,true);
            lista.Add(wierz);
            gen(wierz, lista);
            Console.WriteLine(lista.Count);
        }
    }



}

