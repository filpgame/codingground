using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static List<Navio> createList(){
        List<Navio> navios = new List<Navio>();
        Random rnd = new Random();
        for(int i=0;i<10;i++){
            int pe = rnd.Next(1, 100);
            navios.Add(new Navio{massa = pe});
        }
        return navios;
    }
    static Navio smallest(List<Navio> navios)
    {
            return null;
    }
    
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
