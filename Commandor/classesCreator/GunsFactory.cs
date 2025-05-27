using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using Microsoft.SqlServer.Server;

public class GunsFactory
{
    // שדות 
    List<Weapon> guns = new List<Weapon>();
    string[] guns_list = new string[]
    {
        "AK-47",
        "M-16",
        "RPG",
        "GLOCK",
        "MAG"
    };
    string[] refacto_list = new string[]
    {
      "Russia",
      "Usa",
      "Israel"
    };

    int[] ammo_bulls = new int[]
    {
        30,
        50,
        10

    };



    // קונסטרקטור 
    public GunsFactory(){

        Random rand = new Random();
        for (int i = 0; i<10;i++)
        {
            guns.Add(new Weapon(guns_list[rand.Next(0, guns_list.Length)], 
            refacto_list[rand.Next(0, refacto_list.Length)], ammo_bulls[rand.Next(0, ammo_bulls.Length)]));
        }
    }





}