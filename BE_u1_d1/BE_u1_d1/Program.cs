using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_u1_d1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Atleta atleta1 = new Atleta();
            Atleta atleta2 = new Atleta();
            atleta1.Name = "Mario";
            atleta1.Surname = "rossi";
            string message = atleta1.etaRitiro(32);

            atleta2.Name = "giuseppe";
            atleta2.Surname = "verdi";
            string message2 = atleta2.etaRitiro(36);

            Console.WriteLine("Atleti:" +"\n");

            Console.WriteLine("nome: " +atleta1.Name);
            Console.WriteLine("Cognome: " +atleta1.Surname);
            Console.WriteLine(message);
            Console.WriteLine("\n");
            Console.WriteLine("nome: " + atleta2.Name);
            Console.WriteLine("Cognome: " + atleta2.Surname);
            Console.WriteLine(message2);
            Console.WriteLine("\n");


            Dipendente dipendente1 = new Dipendente();
            Dipendente dipendente2 = new Dipendente();
            dipendente1.Name = "Mario";
            dipendente1.Surname = "rossi";
            string message3 = dipendente1.oreLavorate(32);

            dipendente2.Name = "giuseppe";
            dipendente2.Surname = "verdi";
            string message4 = dipendente2.oreLavorate(51);

            Console.WriteLine("Dipendenti:" + "\n");

            Console.WriteLine("nome: " + dipendente1.Name);
            Console.WriteLine("Cognome: " + dipendente1.Surname);
            Console.WriteLine(message3);
            Console.WriteLine("\n");
            Console.WriteLine("nome: " + dipendente2.Name);
            Console.WriteLine("Cognome: " + dipendente2.Surname);
            Console.WriteLine(message4);
            Console.WriteLine("\n");

            Animale animale1 = new Animale();
            Animale animale2 = new Animale();
            animale1.Breed = "Labrador";
            animale1.Name = "charlie";
            animale2.Breed = "pitbull";
            animale2.Name = "luna";
            Console.WriteLine("animali: " +"\n");
            Console.WriteLine("razza: " + animale1.Breed);
            Console.WriteLine("nome: " +animale1.Name);
            Console.WriteLine("razza: " + animale2.Breed);
            Console.WriteLine("nome: " + animale2.Name);
            Console.WriteLine("\n");

            Veicolo auto1 = new Veicolo();
            auto1.Marca = "BMW"; 
            Veicolo auto2 = new Veicolo();
            auto2.Marca = "Ford";

            Console.WriteLine("Veicoli: " + "\n");
            Console.WriteLine("Auto1: " + auto1.Marca); 
            Console.WriteLine("Auto2: " + auto2.Marca);
            string messaggio5 = auto1.kmTagliando(500);
            Console.WriteLine(messaggio5);

            Console.ReadLine();
        }
    }
}
