namespace WorkWithVariableData;

class Program
{
    static void Main(string[] args)
    {
        int maxPets = 8;
        string[,] ourAnimals = new string[maxPets, 7];

        for (int i = 0; i < maxPets; i++)
        {
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonality = "";
            string animalNickname = "";
            string suggestedDonation = "";

            // the course instruct to change this If Statements to Switch Statements for improved readibility
            // but for me, it's doesn't really make any difference
            if (i == 0)
            {
                animalSpecies = "dog";
                animalID = "d1";
                animalAge = "2";
                animalPhysicalDescription = "medium sized cream colored female golden retriever, weighting about 45 pounds, housebroken.";
                animalPersonality = "loves to have her belly rubbed, likes to chase her tail and gives lots of kisses.";
                animalNickname = "lola";
                suggestedDonation = "85.00";
            }
            else if (i == 1)
            {
                animalSpecies = "dog";
                animalID = "d2";
                animalAge = "9";
                animalPhysicalDescription = "large reddish-brown male golden retriever, weighting about 85 pounds, housebroken.";
                animalPersonality = "loves to have his ears rubbed especially when he greets you at the door, loves to lean-in and give doggy hugs.";
                animalNickname = "gus";
                suggestedDonation = "49.99";
            }
            else if (i == 2)
            {
                animalSpecies = "cat";
                animalID = "c3";
                animalAge = "1";
                animalPhysicalDescription = "small white female domestic cat, weighting about 8 pounds, litter box trained.";
                animalPersonality = "friendly";
                animalNickname = "snow";
                suggestedDonation = "40.00";
            }
            else if (i == 3)
            {
                animalSpecies = "cat";
                animalID = "c4";
                animalAge = "3";
                animalPhysicalDescription = "medium sized long hair yellow female domestic cat, weighting about 10 pounds, litter box trained.";
                animalPersonality = "a people loving cat that likes to sit on your lap.";
                animalNickname = "lion";
                suggestedDonation = "";
            }

            decimal suggestedDonationNumber;
            if (!decimal.TryParse(suggestedDonation, out suggestedDonationNumber))
            {
                suggestedDonationNumber = 45.00m;
            }

            ourAnimals[i, 0] = "ID #" + animalID;
            ourAnimals[i, 1] = "Species: " + animalSpecies;
            ourAnimals[i, 2] = "Age: " + animalAge;
            ourAnimals[i, 3] = "Nickname: " + animalNickname;
            ourAnimals[i, 4] = "Physical Desc.: " + animalPhysicalDescription;
            ourAnimals[i, 5] = "Personality: " + animalPersonality;
            ourAnimals[i, 6] = $"Suggested Donation: {suggestedDonationNumber:C2}";
        }

        string? selection;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine("1. List all pet and their information");
            Console.WriteLine("2. Display all dogs with a specified characteristic");
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
                            for (int j = 1; j < 7; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                        }
                    }
                    break;

                case "2":
                    string? dogCharacteristic;
                    do
                    {
                        Console.WriteLine("Enter one desired dog characteristic to search for:");
                        dogCharacteristic = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(dogCharacteristic));

                    dogCharacteristic = dogCharacteristic.Trim().ToLower();
                    bool dogFound = false;

                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 1].Contains("dog"))
                        {
                            string dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];

                            if (dogDescription.Contains(dogCharacteristic))
                            {
                                Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                                Console.WriteLine(dogDescription);
                                dogFound = true;
                            }
                        }
                    }

                    if (!dogFound)
                    {
                        Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
                    }
                    break;

                default:
                    Console.WriteLine("Your selection is not in menu options!");
                    break;
            }

            Console.ReadLine();
        } while (selection != "exit");
    }
}
