using System;

public class Enemy
{
    public string Name;
    public string Weapon;
    public int HitPoints;
    public void introduce()
    {
        Console.WriteLine("Our hero is attacked by a " + Name + " carrying a " + Weapon + ", with " + HitPoints + " HP.");
    }
}