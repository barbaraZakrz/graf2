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
        List<Wezel> Dzieci = new List<Wezel>();

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



        public static void Main(string[] args)
        {

        }
    }



}

