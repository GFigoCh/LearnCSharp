namespace BranchingAndLooping;

class Program
{
    static void Main(string[] args)
    {
        int maxPets = 8;
        string[,] ourAnimals = new string[maxPets, 6];

        for (int i = 0; i < maxPets; i++)
        {
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonality = "";
            string animalNickname = "";

            // the course instruct to change this If Statements to Switch Statements for improved readibility
            // but for me, it's doesn't really make any difference
            if (i == 0)
            {
                animalSpecies = "dog";
                animalID = "d1";
                animalAge = "2";
                animalPhysicalDescription = "medium sized cream colored female golden retriever, weighting about 65 pounds, housebroken.";
                animalPersonality = "loves to have her belly rubbed, likes to chase her tail and gives lots of kisses.";
                animalNickname = "lola";
            }
            else if (i == 1)
            {
                animalSpecies = "dog";
                animalID = "d2";
                animalAge = "9";
                animalPhysicalDescription = "large reddish-brown male golden retriever, weighting about 85 pounds, housebroken.";
                animalPersonality = "loves to have his ears rubbed especially when he greets you at the door, loves to lean-in and give doggy hugs.";
                animalNickname = "loki";
            }
            else if (i == 2)
            {
                animalSpecies = "cat";
                animalID = "c3";
                animalAge = "1";
                animalPhysicalDescription = "small white female domestic cat, weighting about 8 pounds, litter box trained.";
                animalPersonality = "friendly";
                animalNickname = "puss";
            }
            else if (i == 3)
            {
                animalSpecies = "cat";
                animalID = "c4";
                animalAge = "?";
                animalPhysicalDescription = "tbd.";
                animalPersonality = "tbd.";
                animalNickname = "tbd.";
            }

            ourAnimals[i, 0] = "ID #" + animalID;
            ourAnimals[i, 1] = "Species: " + animalSpecies;
            ourAnimals[i, 2] = "Age: " + animalAge;
            ourAnimals[i, 3] = "Nickname: " + animalNickname;
            ourAnimals[i, 4] = "Physical Desc.: " + animalPhysicalDescription;
            ourAnimals[i, 5] = "Personality: " + animalPersonality;
        }

        string? selection;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine("1. List all pet and their information");
            Console.WriteLine("2. Add a new pet");
            Console.WriteLine("3. Ensure pet 'Age' and 'Physical Desc.' value are complete");
            Console.WriteLine("4. Ensure pet 'Nickname' and 'Personality' value are complete");
            Console.WriteLine("5. Edit an pet's age");
            Console.WriteLine("6. Edit an pet's personality");
            Console.WriteLine("7. Display all cat and their information");
            Console.WriteLine("8. Display all dog and their information");
            Console.Write("\nEnter your selection (type 'exit' to close the program): ");

            selection = Console.ReadLine();
            if (selection != null)
            {
                selection = selection.ToLower();
            }

            switch (selection)
            {
                case "exit":
                    Console.WriteLine("Thank you for using Contoso PetFriends app!\n");
                    continue;

                case "1":
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 0] != "ID #")
                        {
                            Console.WriteLine($"\n{ourAnimals[i, 0]}");
                            for (int j = 1; j < 6; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                        }
                    }
                    break;

                case "2":
                    string? anotherPet = "y";
                    int petCount = 0;

                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 0] != "ID #")
                        {
                            petCount++;
                        }
                    }

                    if (petCount < maxPets)
                    {
                        Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {maxPets - petCount} more.");
                    }

                    while (anotherPet == "y" && petCount < maxPets)
                    {
                        string? inputSpecies;
                        string? inputAge;
                        string? inputPhysicalDescription;
                        string? inputPersonality;
                        string? inputNickname;

                        Console.WriteLine("\nBegin a new entry...");
                        do
                        {
                            Console.Write("Pet species? [dog/cat] ");
                            inputSpecies = Console.ReadLine();
                            
                            if (inputSpecies != null)
                            {
                                inputSpecies = inputSpecies.ToLower();
                            }
                        } while (inputSpecies != "dog" && inputSpecies != "cat");

                        do
                        {
                            Console.Write("Pet age? [number/?] ");
                            inputAge = Console.ReadLine();

                            if (inputAge != null)
                            {
                                inputAge = inputAge.Trim();
                            }
                        } while (!int.TryParse(inputAge, out _) && inputAge != "?");

                        Console.WriteLine("Pet physical desc. (size, color, gender, weight, housebroken):");
                        inputPhysicalDescription = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(inputPhysicalDescription))
                        {
                            inputPhysicalDescription = "tbd.";
                        }
                        else
                        {
                            inputPhysicalDescription = inputPhysicalDescription.ToLower();
                        }

                        Console.WriteLine("Pet personality (likes/dislikes, tricks, energy level):");
                        inputPersonality = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(inputPersonality))
                        {
                            inputPersonality = "tbd.";
                        }
                        else
                        {
                            inputPersonality = inputPersonality.ToLower();
                        }

                        Console.Write("Pet nickname? ");
                        inputNickname = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(inputNickname))
                        {
                            inputNickname = "tbd.";
                        }
                        else
                        {
                            inputNickname = inputNickname.ToLower();
                        }
                        
                        string inputID = inputSpecies.Substring(0, 1) + (petCount + 1).ToString();
                        ourAnimals[petCount, 0] = "ID #" + inputID;
                        ourAnimals[petCount, 1] = "Species: " + inputSpecies;
                        ourAnimals[petCount, 2] = "Age: " + inputAge;
                        ourAnimals[petCount, 3] = "Nickname: " + inputNickname;
                        ourAnimals[petCount, 4] = "Physical Desc.: " + inputPhysicalDescription;
                        ourAnimals[petCount, 5] = "Personality: " + inputPersonality;

                        petCount++;
                        if (petCount < maxPets)
                        {
                            do
                            {
                                Console.Write("Do you want to add another pet? [y/n] ");
                                anotherPet = Console.ReadLine();
                                
                                if (anotherPet != null)
                                {
                                    anotherPet = anotherPet.ToLower();
                                }
                            } while (anotherPet != "y" && anotherPet != "n");
                        }
                    }

                    if (petCount >= maxPets)
                    {
                        Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Menu {selection} is under development.");
                    break;

                case "4":
                    Console.WriteLine($"Menu {selection} is under development.");
                    break;

                case "5":
                    Console.WriteLine($"Menu {selection} is under development.");
                    break;

                case "6":
                    Console.WriteLine($"Menu {selection} is under development.");
                    break;

                case "7":
                    Console.WriteLine($"Menu {selection} is under development.");
                    break;

                case "8":
                    Console.WriteLine($"Menu {selection} is under development.");
                    break;

                default:
                    Console.WriteLine("Your selection is not in menu options!");
                    break;
            }

            Console.ReadLine();
        } while (selection != "exit");
    }
}
