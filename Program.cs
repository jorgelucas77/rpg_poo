using rpg_poo.src.Entities;

namespace rpg_poo.src
{
    class Program
    {

        static void Main(string[] args)
        {

            Knight luke = new Knight("Luke Skywalker", 12, "Jedi");
           // Hero yoda = new Hero("Yoda", 20, "Mestre Jedi");
            Bad vader = new Bad("Vader", 18, "Darkside General");

            Console.WriteLine(luke);
           // Console.WriteLine(yoda);
          //  Console.WriteLine(yoda.Attack());
            Console.WriteLine(vader.Attack());
            Console.WriteLine(vader.Attack(1));
            Console.WriteLine(vader.Attack(7));
        }
    }


}



