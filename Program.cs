string[] lines = File.ReadAllLines(@"C:\Users\wande\source\repos\word_adventure\story_files\Story.txt");

foreach (string line in lines)
    Console.WriteLine(line);

string answer_1 = Console.ReadLine();

switch (answer_1) 
{
    case "A" or "a":
        Console.WriteLine("You tripped");
        break;
    case "B" or "b":
        Console.WriteLine("A light flickers under the door");
        break;
    case "C" or "c":
        Console.WriteLine("You nudge something and hear a growl");
        break;
    case "":
        Console.WriteLine("Type A,B, or C and press Enter to continue...");
        break ;
       
}

