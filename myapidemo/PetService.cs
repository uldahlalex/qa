using System.ComponentModel.DataAnnotations;

namespace myapidemo;

public class PetService
{
    
    public List<Pet> MyPets { get; set; } = new List<Pet>()
    {
        new Pet()
        {
            PetName = "bob"
        }
    };

    public Pet CreatePet(Pet pet)
    {
        if (pet.PetName.Length < 2)
            throw new ValidationException("name should not be shorter than 2 chars");
            
        return pet;
    }
}