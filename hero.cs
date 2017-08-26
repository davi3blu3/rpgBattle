using System;

public class Hero
{
    public string Name;
    public string Weapon;
    public int HitPoints;
    public void introduce()
    {
        Console.WriteLine("Our Hero " + Name + " carries a deadly " + Weapon + " and has " + HitPoints + " HP.");
    }
}