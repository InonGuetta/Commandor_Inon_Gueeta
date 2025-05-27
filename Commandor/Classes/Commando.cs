using System;
using System.Globalization;

public class Commando
{
    private string Name;
    private string CodeName;
    public string[] Tools = { "hammer", "rope", "chisel", "bag", "water buttle'" };
    public string Status;



    public void Properties()
    {
        Console.WriteLine(this.Name);
    }

    public void SayName(string commanderRank)
    {
        //commanderRank.ToUpper();
        if (commanderRank == "GENERAL")
        {
            Console.WriteLine($"the real name is {Name}");
        }
        else if(commanderRank == "COLONEL")
        {
            Console.WriteLine($"the real name is {CodeName}");
        }
        else
        {
            Console.WriteLine("soory but you not confirm to access");
        }
    }





    public Commando(string name, string codeName, string status)
    {
        this.Name = name;
        this.CodeName = codeName;
        this.Status = status;
    }

    public void Walk()
    {
        Status = "Walk";
    }
      public void Hide()
    {
        Status = "Hide";
    }
      
    public void Attack()
    {
        Console.WriteLine($"the soldier {CodeName} is attack");
    }


}