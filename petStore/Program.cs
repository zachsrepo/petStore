


using petStore;

IPet[] animals = new IPet[]
{
    new Dog(){Name = "Rex", AnimalType = "Dog"},
    new Cat(){ Name = "Felix", AnimalType ="Cat" },
    new Duck(){Name = "Donald", AnimalType= "Duck"},
    new Cow(){Name = "Daisy", AnimalType = "Cow"},
    new Cow(){Name = "John", AnimalType = "Cow"},
    new Lizard(){Name = "Slimy", AnimalType = "Lizzard"},
    new Lizard(){Name = "Jack", AnimalType = "Lizzard"}
    

    
};

foreach(var animal in animals)
{
   
    Console.WriteLine($"The {animal.AnimalType}, {animal.Name} says {animal.Speak()}");
    
}
