Console.WriteLine("You wake up and there are no lights on in the room, do you:\n" +
    "A: Get up and turn on a light?\n" +
    "B: Lay there and hope the lights come on themselves?\n" +
    "C: Reach under the bed and feel around for a flashlight?\n" +
    "\nType A,B, or C and press Enter to continue...\n");

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

