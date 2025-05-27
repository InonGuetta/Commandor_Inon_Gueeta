using System;

public class Commando
{
    public string Name;
    public string CodeName;
    public string[] Tools = { "hammer", "rope", "chisel", "bag", "water buttle'" };
    public string Status;


    // עכשיו בכל יצירת instance הוא יהיה חייב להיות מאותחל כמו כאן ב 
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