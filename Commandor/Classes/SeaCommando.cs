using System;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

public class SeaCommando : Commando
{
    public string TypeComander = "can swin";

    public SeaCommando(string name, string codeName, string status) : base(name, codeName, status)
    {
        // תבין מה עושים כאן
    }

    //--------------------------------------------------------------------------------------------
    public override void Attack()
    {
        Console.WriteLine($"the soldier {CodeName} from SeaCommando");
    }

    //--------------------------------------------------------------------------------------------
    public void print()
    {
        Console.WriteLine(TypeComander);
    }

}