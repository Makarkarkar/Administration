using Administration.Models;

namespace Administration.Services
{
    public class AnimalService
    {
        public string Voice(IAnimal animal)
        {
            string message = ($"{animal.Animal} {animal.Name} said {animal.Voice}!");;
            return message;
        }
    }    
}

