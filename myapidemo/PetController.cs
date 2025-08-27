using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using myapidemo;

public class Pet
{
    public string PetName { get; set; }
}

[ApiController]
[ResponseCache(NoStore = true, Duration = 0)]
public class PetController(MyFakeDb db) : ControllerBase
{

    [HttpGet(nameof(GetAllPets))] 
    public List<Pet> GetAllPets() => db.MyPets;

    

    [HttpPost]
    [Route(nameof(CreatePet))]
    public ActionResult<Pet> CreatePet([FromBody]Pet pet)
    {
        if (pet.PetName.Length < 2)
            return BadRequest("That was a bad request due to pet name length");
        
        return pet;
    }

    [HttpPut]
    [Route("/api/pets/{id}")]
    public Pet UpdatePet([FromBody]Pet pet, [FromRoute]int id)
    {
        Console.WriteLine(id);
        return pet;
    }
    
    
}