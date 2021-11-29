using System;

public class Animal
{
    private string name;
    public string color;

    private string alias;

    protected string Color { get; set; }

    public Animal() { }
    
    public Animal(string name)
    {
        this.name = name;
        this.color = "black";
    }
        
    public Animal(string name, string color)
    {
        this.name = name;
        this.color = color;
    }

    public string GetName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public virtual void AnimalSound()
    {
        Console.WriteLine("Animal sound");
    }

    public override string ToString()
    {
        return "Animal: " + name + " " + color;
    }

    public string Alias
    {
        get => alias;
        
        set
        {
            if (alias is not null)
            {
                return;
            }
            else
            {
                this.alias = value;
            }
        }
    }
        
    ~Animal()
    {
        Console.WriteLine("Destructor");
    }
}