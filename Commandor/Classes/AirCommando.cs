using System;
using System.Runtime.CompilerServices;

public class AirCommando : Commando
{

    public string TypeComander { get; set; } = "can fail";
   public AirCommando(string name, string codeName, string status) : base(name, codeName, status)
    {
    }

    public override void  Attack()
    {
        Console.WriteLine($"the soldier {codeName} from AirCommando");
    }

    public void print()
    {
        Console.WriteLine(TypeComander);
    }

}