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
            
            while (hero.HitPoints > 0 && enemy.HitPoints > 0)
            {
                // blank space between cycles
                Console.WriteLine();
                
                A_Attacks_B(hero, enemy);
                
                //check if enemy is dead
                if (enemy.HitPoints <= 0)
                {
                    Console.WriteLine("The vile " + enemy.Name + " has been vanquished!");
                    break;
                }

                A_Attacks_B(enemy, hero);

                //check if hero is dead
                if (enemy.HitPoints <= 0)
                {
                    Console.WriteLine("Oh no! " + hero.Name + " has suffered a fatal blow!");
                    Console.WriteLine("** YOU HAVE DIED AND THE KINGDOM IS LOST! **");
                    break;
                }
            }
        }

        static void A_Attacks_B(dynamic A, dynamic B)
        {
            // Calculate Attack Damage
            Random randDamage = new Random();
            int damage = randDamage.Next(0, 5);

            // handle miss vs. strike
            if (damage == 0) Console.WriteLine(A.Name + " swung at " + B.Name + " and missed!");
            else
            {
                Console.WriteLine(A.Name + " attacks " + B.Name + " for " + damage + " damage!");
                B.HitPoints -= damage;
            }  
        }
    }
}
