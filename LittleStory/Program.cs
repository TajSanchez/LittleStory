namespace LittleStory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me an adjective!");
            string? adjective1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me another adjective");
            string? adjective2 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me a location");
            string? location = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me a noun");
            string? noun = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me a character name");
            string? characterName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me yet another adjective");
            string? adjective3 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me a forest type");
            string? forestType = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me an animal");
            string? animal = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me a type of vehicle");
            string? vehicle = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me a verb doing something");
            string? verbing = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me a nautral feature");
            string? naturalFeature = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me a verb in past tense");
            string? verbed = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me a mysterious object");
            string? mysteriousObject = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me a type of vegetation");
            string? vegetation = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me a verb");
            string? verb1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me another verb ");
            string? verb2 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me an animal in plural form");
            string? animalPlural = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Give me another noun");
            string? noun2 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Now let's make a story!");
            Console.WriteLine();

            string title = ($"Title: \"The {adjective1} Fox Adventure\"\r\n\r\n");
            Console.WriteLine(title);

            
         string story = $"Once upon a time in a {adjective2} {location}, there lived a clever {noun} named {characterName}. {characterName} was known throughout the forest for being the most {adjective3} fox around. One day, {characterName} decided to go on an exciting adventure.\r\n\r\nWith a {adjective1} {vehicle} in hand, {characterName} set off into the {adjective2} {forestType}. Along the way, {characterName} encountered a friendly {animal}, who offered to join the adventure. Together, they ventured deeper into the forest, {verbing} through the {naturalFeature}.\r\n\r\nAs they {verbed} deeper into the forest, {characterName} and their new friend stumbled upon a {mysteriousObject} hidden beneath a {adjective3} {vegetation}. It was said that whoever possessed this {mysteriousObject} would gain the power to {verb1} anything they desired.\r\n\r\nExcitement filled the air as {characterName} and their friend decided to {verb2} the {mysteriousObject}. Little did they know that their actions would set off a series of {adjective1} events that would change the fate of all the {animalPlural} in the forest.\r\n\r\nNow, it's up to {characterName} and their friend to {verb2} the forest and restore {noun2}'s balance. Will they succeed, or will the forest remain forever {adjective2}? Only time will tell in this {adjective1} fox adventure!\r\n";

            Console.WriteLine(story);
        }






    }
}