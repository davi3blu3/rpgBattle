using System;

namespace rpgBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Hero
            Console.WriteLine("Create a new hero to save the kingdom!");
            Hero hero = new Hero();

            // Set Hero's Name
            Console.WriteLine("Choose a name:");
            hero.Name = Console.ReadLine();
            
            // Set Hero's Weapon
            Console.WriteLine("Choose a Weapon: BroadSword, BattleAxe, Spear)");
            hero.Weapon = Console.ReadLine();
            
            // Set Hero's Hit Points
            Random rand = new Random();
            hero.HitPoints = rand.Next(12, 18);
            
            hero.introduce();

        }
    }
}
