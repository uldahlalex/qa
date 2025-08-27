namespace myapidemo;

public class MyFakeDb
{
    public List<Pet> MyPets { get; set; } = new List<Pet>()
    {
        new Pet()
        {
            PetName = "bob"
        }
    };
}