namespace Administration.Models;

public class Cat : IAnimal
{
    public Cat(string name)
    {
        Animal = "Cat";
        Name = name;
        Voice = "meow-meow";
    }

    public string Animal { get; set; }
    public string Name { get; set; }

    public string Voice { get; set; }
}