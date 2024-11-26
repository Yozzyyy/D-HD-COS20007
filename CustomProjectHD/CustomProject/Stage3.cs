using CustomProject;
using CustomProject.Items;

public class Stage3 : Game
{
    public Stage3(Player player) : base(player) { }

    public override void Play()
    {
        Console.WriteLine("You are in the Third Stage Room. There are 3 rooms here.");

        // Define the rooms with chests and riddles
        var roomOptions = new List<Room>
            {
                new Room("Abandoned Mansion", new List<Chest>
                {
                    new LootChest("Chest with Stacks of books on top", new Pendent()),
                    new TrapChest("Dusty Chest"),
                    new LootChest("Mysterious Chest", new Poison())
                }, "What comes down but never goes up?", "rain"),

                new Room("Dimly lit Church", new List<Chest>
                {
                    new LootChest("Church Chest", new Cross()),
                    new TrapChest("Cursed Chest"),
                    new LootChest("Prayer Chest", new Key2())
                }, "I am not alive, but I grow. I do not have lungs, but I need air. What am I?", "fire"),

                new Room("Empty Dog House", new List<Chest>
                {
                    new LootChest("Dog Bowl", new Bone()),
                    new TrapChest("A half-eaten bone"),
                    new LootChest("Artifact Chest", new GlowingOrb())
                }, "What has cities, but no houses? Forests, but no trees? And rivers, but no water?", "map")
            };

        int roomChoice = -1;
        while (roomChoice < 1 || roomChoice > 3)
        {
            Console.WriteLine("1. Abandoned Mansion");
            Console.WriteLine("2. Dimly lit Church");
            Console.WriteLine("3. Empty Dog House");
            Console.Write("Please enter a number (1-3) to choose a room: ");

            if (int.TryParse(Console.ReadLine(), out roomChoice))
            {
                if (roomChoice < 1 || roomChoice > 3)
                {
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 3.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        // Choose the selected room
        var selectedRoom = roomOptions[roomChoice - 1];

        // Allow the player to interact with the chests and solve riddles
        bool roomComplete = false;

        // Print the room state once at the start
        Console.WriteLine($"You are now in the {selectedRoom.Name}. Here are the chests in this room:");
        for (int i = 0; i < selectedRoom.Chests.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {selectedRoom.Chests[i].Name}");
        }

        while (!roomComplete && Player.IsAlive())
        {
            Console.WriteLine("\nAvailable actions:");
            Console.WriteLine("- Enter a chest number to open it.");
            Console.WriteLine("- Type 'riddle' to solve the room's riddle.");
            Console.WriteLine("- Type 'look' to check your inventory.");

            string input = Console.ReadLine().ToLower();

            if (input == "riddle")
            {
                Console.WriteLine($"Solve this riddle: {selectedRoom.Riddle}");
                string answer = Console.ReadLine().ToLower();

                // Validate the answer based on the selected room
                if ((roomChoice == 1 && answer == "rain") ||
                    (roomChoice == 2 && answer == "fire") ||
                    (roomChoice == 3 && answer == "map"))
                {
                    Console.WriteLine("Correct! You may proceed.");
                    roomComplete = true;

                    // Transition directly to Stage 4
                    Console.WriteLine("You have successfully completed this stage. Proceeding to Stage 4...");
                    var stage4 = new Stage4(Player);
                    stage4.Start();
                    return; // Exit Stage 3
                }
                else
                {
                    Console.WriteLine("Wrong answer! Try again.");
                }
            }
            else if (input == "look")
            {
                Console.WriteLine("\nYour Inventory:");
                Player.ShowInventory();

                Console.WriteLine("Would you like to use an item? (yes/no):");
                string useItemInput = Console.ReadLine().ToLower();

                if (useItemInput == "yes")
                {
                    Console.WriteLine("Enter the name of the item you wish to use:");
                    string itemName = Console.ReadLine();
                    Player.UseItem(itemName); // Pass the item name
                }
                else
                {
                    Console.WriteLine("You chose not to use an item.");
                }
            }
            else if (int.TryParse(input, out int chestNumber) && chestNumber >= 1 && chestNumber <= selectedRoom.Chests.Count)
            {
                // Open the selected chest
                selectedRoom.Chests[chestNumber - 1].Open(Player);
            }
            else
            {
                Console.WriteLine("Invalid choice! Try again.");
            }
        }

        // Transition to Stage 4 or end the game
        if (Player.IsAlive())
        {
            Console.WriteLine("You survived Stage 3! Moving to Stage 4...");
            Console.WriteLine("      ______\r\n   ,-' ;  ! `-.\r\n  / :  !  :  . \\\r\n |_ ;   __:  ;  |\r\n )| .  :)(.  !  |\r\n |\"    (##)  _  |\r\n |  :  ;`'  (_) (\r\n |  :  :  .     |\r\n )_ !  ,  ;  ;  |\r\n || .  .  :  :  |\r\n |\" .  |  :  .  |\r\n |mt-2_;----.___|");
            var stage4 = new Stage4(Player); // Correct transition to Stage 4
            stage4.Start();  // Start Stage 4
        }
        else
        {
            EndGame();
        }
    }
}
