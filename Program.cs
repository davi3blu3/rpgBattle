using System;

namespace rpgBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            Console.WriteLine("Create a new hero. Name?");
            hero.Name = Console.ReadLine();
            Console.WriteLine("Choose a Weapon - (Sword, Axe, or Mace)");
            hero.Weapon = Console.ReadLine();
            Random rand = new Random();
            hero.HitPoints = rand.Next(12, 18);
            hero.introduce();
        }
    }
}
