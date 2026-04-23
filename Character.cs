namespace battle;

public class Character : Entity
{
    public string Name { get; set; }

    public Character(string name) : base(maxHealth: 100) 
    {
        Name = name;
    
    }
}