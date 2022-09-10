// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 string title = "MadLibs";

      Console.WriteLine(title);
      // Define user input and variables:


      // The template for the story:
Console.WriteLine("MadLibs is starting");
      
Console.Write("Enter a name:");
string name = Console.ReadLine();

Console.Write("Input 3 adjectives:");
string adjectives = Console.ReadLine(); 

Console.Write("Write 1 verb:");
string verb = Console.ReadLine();

Console.Write("Write 2 nouns:");
string nouns = Console.ReadLine();

Console.Write("input animal name:");
string animal = Console.ReadLine();

Console.Write("input food name:");
string food = Console.ReadLine();

Console.Write("input fruit name:");
string fruit = Console.ReadLine();

Console.Write("input superhero name:");
string superhero = Console.ReadLine();

Console.Write("input country name:");
string country = Console.ReadLine();

Console.Write("input dessert name:");
string dessert = Console.ReadLine();

Console.Write("input year name:");
string year = Console.ReadLine();

      string story = $"This morning {name} woke up feeling {adjectives}. 'It is going to be a {adjectives} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nouns}, which made all the {fruit}s very {adjectives}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nouns}s ruled the world.";


      // Print the story:
Console.WriteLine(story);