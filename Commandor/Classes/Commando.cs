using System;
using System.Globalization;
using System.Xml.Linq;

public class Commando
{
    public string name;
    public string codeName { get; set; }
    public string[] tools = { "hammer", "rope", "chisel", "bag", "water buttle'" };
    public string status;


    //----------------------------------------------------------------------------------
    public void Properties()
    {
        Console.WriteLine(this.name);
    }

    // המתודה הזאת משמשת כ getter
    public void Sayname(string commanderRank)
    {
        //commanderRank.ToUpper();
        if (commanderRank == "GENERAL")
        {
            Console.WriteLine($"the real name is {name}");
        }
        else if(commanderRank == "COLONEL")
        {
            Console.WriteLine($"the real name is {codeName}");
        }
        else
        {
            Console.WriteLine("soory but you not confirm to access");
        }
    }

    
    //----------------------------------------------------------------------------------

    public Commando(string name, string codeName, string status)
    {
        this.name = name;
        this.codeName = codeName;
        this.status = status;
    }

    public void Walk()
    {
        status = "Walk";
    }
      public void Hide()
    {
        status = "Hide";
    }
      
    public virtual void Attack()
    {
        Console.WriteLine($"the soldier {codeName} is attack");
    }
  
    //----------------------------------------------------------------------------------
    public void printInfo()
    {
        Console.WriteLine("---- Commando Information ----");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Code Name: {codeName}");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine("Tools:");
        foreach (string tool in tools)
        {
            Console.WriteLine($"- {tool}");
        }
        Console.WriteLine("--------------------------------");
    }


}