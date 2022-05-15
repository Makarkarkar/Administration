namespace Administration.Models;

public class Dog:IAnimal
{
    public Dog(string name)
    {
        Animal = "Dog";
        Name = name;
        Voice = "woof-woof";
    }

    public string Animal { get; set; }
    public string Name { get; set; }
    public string Voice { get; set; }
}