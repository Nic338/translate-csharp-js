using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public class Guests
    {
        public string? Name {get; set;}
        public string? Occupation {get; set;}
        public string? Bio {get; set;}
    }
    public static void Main()
    {
        List<Guests> guests = new List<Guests>() {
            new Guests(){ Name="Marilyn Monroe", Occupation="entertainer", Bio="(1926 - 1962) American actress, singer, model"},
            new Guests(){ Name="Abraham Lincoln", Occupation="politician", Bio="(1809 - 1865) US President during American civil war"},
            new Guests(){ Name="Martin Luther King", Occupation="activist", Bio="(1929 - 1968)  American civil rights campaigner"},
            new Guests(){ Name="Rosa Parks", Occupation="activist", Bio="(1913 - 2005)  American civil rights activist"},
            new Guests(){ Name="Peter Sellers", Occupation="entertainer", Bio="(1925 - 1980) British actor and comedian"},
            new Guests(){ Name="Alan Turing", Occupation="computer scientist", Bio="(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"},
            new Guests(){ Name="Admiral Grace Hopper", Occupation="computer scientist", Bio="(1906-1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"},
            new Guests(){ Name="Indira Gandhi", Occupation="politician", Bio="(1917 - 1984) Prime Minister of India 1966 - 1977"}
        };

        var Table1 = new List<Guests>();
        var Table2 = new List<Guests>();
        var table1Occupations = new List<String>();

        foreach(Guests guest in guests)
        {
            if (table1Occupations.Contains(guest.Occupation))
            {
                Table2.Add(guest);
            }
            else
            {
                Table1.Add(guest);
                table1Occupations.Add(guest.Occupation);
            }
        }
        Console.WriteLine("Table 1 Guests:");
        
        foreach(Guests guest in Table1)
        {
            Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
        }

        Console.WriteLine("Table 2 Guests:");

        foreach(Guests guest in Table2)
        {
            Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");

        }
    }
}
