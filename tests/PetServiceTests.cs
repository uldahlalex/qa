using System.ComponentModel.DataAnnotations;
using myapidemo;

namespace tests;

public class PetServiceTests
{

    [Fact]
    public void CreatePet_Should_Succeed_WhenThereAreNoValidationExceptions()
    {
        //Arrange  /Given
        var pet = new Pet()
        {
            PetName = "Bob"
        };
        var service = new PetService();

        //Act
        var result = service.CreatePet(pet);
        
        //Assert
        Assert.Equal(result, pet);
    }
    
    //Test that is covering the "unhappy path"
    [Fact]
    public void CreatePet_Should_ThrowExceptionWhenValidationErrorsOccur()
    {
        //Arrange  /Given
        var pet = new Pet()
        {
            PetName = "b"
        };
        var service = new PetService();
        
     
        //Assert    
        Assert.Throws<ValidationException>(
            //Act
            () => service.CreatePet(pet));
    }
}
