using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using myapidemo;

public class Pet
{
    public string PetName { get; set; }
}

[ApiController]
[ResponseCache(NoStore = true, Duration = 0)]
public class PetController(PetService service) : ControllerBase
{

    [HttpGet(nameof(GetAllPets))] 
    public List<Pet> GetAllPets() => service.MyPets;

    

    [HttpPost]
    [Route(nameof(CreatePet))]
    public Pet CreatePet([FromBody]Pet pet)
    {
        return service.CreatePet(pet);
    }

    [HttpPut]
    [Route("/api/pets/{id}")]
    public Pet UpdatePet([FromBody]Pet pet, [FromRoute]int id)
    {
        Console.WriteLine(id);
        return pet;
    }
    
    
}