using System;

namespace rpgBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            SpawnHero(hero);

            Console.WriteLine("Would you like to Do Battle? (Y/N)");
            string response = Console.ReadLine();
            if (response == "Y" || response == "y")
            {
                Battle(hero);
            }
            else
            {
                Console.WriteLine("Goodbye.");
            }


        }

        static void SpawnHero(Hero hero)
        {
            // Create a new Hero
            Console.WriteLine("** CREATE A NEW HERO TO SAVE THE KINGDOM! **");
            
            // Set Hero's Name
            Console.WriteLine("Choose a name:");
            hero.Name = Console.ReadLine();
            
            // Set Hero's Weapon
            Console.WriteLine("Choose a Weapon: BroadSword, BattleAxe, Spear)");
            hero.Weapon = Console.ReadLine();
            
            // Set Hero's Hit Points
            Random randHero = new Random();
            hero.HitPoints = randHero.Next(12, 18);
            
            hero.introduce();
        }

        static void SpawnEnemy(Enemy enemy)
        {
            // possible enemy types
            string[] enemyType = new string[4]; 
            enemyType[0] = "Goblin";
            enemyType[1] = "Skeleton";
            enemyType[2] = "Orc";
            enemyType[3] = "Imp";

            // possible enemy weapons
            string[] weaponType = new string[4]; 
            weaponType[0] = "Short Sword";
            weaponType[1] = "Mace";
            weaponType[2] = "Hammer";
            weaponType[3] = "Dagger";

            // Create enemy!!
    
            Random rand = new Random();
            enemy.Name = enemyType[rand.Next(0, 3)];
            enemy.Weapon = weaponType[rand.Next(0, 3)];
            enemy.HitPoints = rand.Next(8, 15);

            enemy.introduce();
        }

        static void Battle(Hero hero)
        {
            Enemy enemy = new Enemy();
            SpawnEnemy(enemy);

            Console.WriteLine("The battle begins, " + hero.Name + " versus the " + enemy.Name + "!");

            // Battle loop while both warriors are alive
            Random randDamage = new Random();
            while (hero.HitPoints > 0 && enemy.HitPoints > 0)
            {
                // Hero Attacks
                int heroDamage = randDamage.Next(0, 5);
                Console.WriteLine();

                // handle miss vs. strike
                if (heroDamage == 0)
                {
                    Console.WriteLine(hero.Name + " swung at the " + enemy.Name + " and missed!");
                }
                else
                {
                    Console.WriteLine(hero.Name + " strikes the " + enemy.Name + " for " + heroDamage + " damage!");
                    enemy.HitPoints -= heroDamage;
                }

                //check if enemy is dead
                if (enemy.HitPoints <= 0)
                {
                    Console.WriteLine("The " + enemy.Name + " has been defeated!");
                    break;
                }

                // Enemy Attacks
                int enemyDamage = randDamage.Next(0, 5);

                // handle miss vs. strike
                if (enemyDamage == 0)
                {
                    Console.WriteLine(enemy.Name + " swung at " + hero.Name + " and missed!");
                }
                else
                {
                    Console.WriteLine(enemy.Name + " attacks " + hero.Name + " for " + enemyDamage + " damage!");
                    hero.HitPoints -= enemyDamage;
                }

                //check if hero is dead
                if (hero.HitPoints <= 0)
                {
                    Console.WriteLine("Oh no! Our hero, " + hero.Name + " has been defeated! The kingdom is lost!");
                    break;
                }
            }
        }
    }
}
