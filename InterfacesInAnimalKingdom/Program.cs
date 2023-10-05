var genericAnimal = new Animal { Name = "Whiskers", Age = 5 };

var animalToMammalProcessor = new AnimalToMammalProcessor();
var mammal = animalToMammalProcessor.Process(genericAnimal);
mammal.FeedMilk();

var mammalToCatProcessor = new MammalToCatProcessor();
var cat = mammalToCatProcessor.Process(mammal);
cat.Speak();
cat.Purr();
