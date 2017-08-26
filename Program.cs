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

            // Create enemy!!
            string[] enemyType = new string[4]; 
            enemyType[0] = "Goblin";
            enemyType[1] = "Skeleton";
            enemyType[2] = "Orc";
            enemyType[3] = "Imp";

            string[] weaponType = new string[4]; 
            weaponType[0] = "Short Sword";
            weaponType[1] = "Mace";
            weaponType[2] = "Hammer";
            weaponType[3] = "Dagger";

            Enemy enemy = new Enemy();
            enemy.Name = enemyType[rand.Next(0, 3)];
            enemy.Weapon = weaponType[rand.Next(0, 3)];
            enemy.HitPoints = rand.Next(8, 14);
            enemy.introduce();
        }
    }
}
