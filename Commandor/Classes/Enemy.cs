﻿using System;

public class Enemy
{

    public string name { get; set; }
    public int live { get; set; } = 100;
    public bool status { get; set; } = true;
    public string shout { get; set; } = "I Enemy";
    //----------------------------------------------
    // הקונסטרקטור 
    public Enemy(string name)
    {
        this.name = name;
    }
    //----------------------------------------------
    public void printInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Life: {live}");
        Console.WriteLine($"Status: {(status ? "Alive" : "Dead")}");
        Console.WriteLine($"Shout: {shout}");
    }


}