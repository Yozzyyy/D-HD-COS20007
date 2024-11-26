using CustomProject.Items;
using System;
using System.Collections.Generic;

namespace CustomProject
{
    public class Stage2 : Game
    {
        public Stage2(Player player) : base(player) { }

        public override void Play()
        {
            Console.WriteLine("You are in the Second Stage Room. There are 3 rooms here.");

            // Define the rooms with chests and riddles
            var roomOptions = new List<Room>
            {
                new Room("Mysterious Tree", new List<Chest>
                {
                    new LootChest("Chest Covered in leaves", new CrownVine()),
                    new TrapChest("A nicely wrapped Chest"),
                    new LootChest("Bottle stuck in tree", new TreeBottle())
                }, "What has a face and two hands but no arms or legs?", "clock"),

                new Room("Abandoned House", new List<Chest>
                {
                    new LootChest("A Slightly Open Vault", new BookOfKnowledge()),
                    new TrapChest("Chest in Attic"),
                    new LootChest("Handheld Box", new Note())
                }, "What comes once in a minute, twice in a moment, but never in a thousand years?", "m"),

                new Room("Very Dim Walkway", new List<Chest>
                {
                    new LootChest("Trashcan", new TrashCan()),
                    new TrapChest("Under the Seat"),
                    new LootChest("A Weird Looking Leaf??", new HealingLeaf())
                }, "What has roots that nobody sees, is taller than trees, up, up it goes, and yet never grows?", "mountain")
            };

            int roomChoice = -1;
            while (roomChoice < 1 || roomChoice > 3)
            {
                Console.WriteLine("1. Mysterious Tree");
                Console.WriteLine("2. Abandoned House");
                Console.WriteLine("3. Very Dim Walkway");
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
                    if ((roomChoice == 1 && answer == "clock") ||
                        (roomChoice == 2 && answer == "m") ||
                        (roomChoice == 3 && answer == "mountain"))
                    {
                        Console.WriteLine("Correct! You may proceed.");
                        roomComplete = true;

                        // Transition directly to Stage 3
                        Console.WriteLine("You have successfully completed this stage. Proceeding to Stage 3...");
                        var stage3 = new Stage3(Player);
                        stage3.Start();
                        return; // Exit Stage 2
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

            // Transition to Stage 3 or end the game
            if (Player.IsAlive())
            {
                Console.WriteLine("You survived Stage 2! Moving to Stage 3...");
                Console.WriteLine("      ______\r\n   ,-' ;  ! `-.\r\n  / :  !  :  . \\\r\n |_ ;   __:  ;  |\r\n )| .  :)(.  !  |\r\n |\"    (##)  _  |\r\n |  :  ;`'  (_) (\r\n |  :  :  .     |\r\n )_ !  ,  ;  ;  |\r\n || .  .  :  :  |\r\n |\" .  |  :  .  |\r\n |mt-2_;----.___|");
                var stage3 = new Stage3(Player); // Correct transition to Stage 3
                stage3.Start();  // Start Stage 3
            }
            else
            {
                EndGame();
            }
        }
    }
}
