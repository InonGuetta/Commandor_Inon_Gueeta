public class Enemy
{

    public string name { get; set; }
    public int live { get; set; } = 100;
    public bool status { get; set; } = true;
    public string shout { get; set; } = "I Enemy";

    public Enemy(string name)
    {
        this.name = name;
    }

}