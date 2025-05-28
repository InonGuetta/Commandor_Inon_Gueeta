using System;
using System.Xml.Linq;

public class Weapon
{

    // fields
    public string Name;
    public string Refactor;
    public int Ammo;

    //--------------------------------------------------------------------------------------------
    // constractor
    public Weapon(string name,string refactor, int ammo){
        this.Name = name;
        this.Refactor = refactor;
        this.Ammo = ammo;
    }

    //--------------------------------------------------------------------------------------------
    public void Shoot()
    {
        if (Ammo > 0)
        {
        Ammo -= 1;
        Console.WriteLine($"The amount of weapons you have left is {Ammo}");
        }
        else
        {
            Console.WriteLine("the ammo finish");
        }
    }
    //--------------------------------------------------------------------------------------------

    public void printInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Refactor: {Refactor}");
        Console.WriteLine($"Ammo: {Ammo}");
    }




}