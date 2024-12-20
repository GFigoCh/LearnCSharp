namespace ZooVisitPlan;

class Program
{
    static string[] pettingZoo =
    {
        "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
        "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
        "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises"
    };

    static void Main(string[] args)
    {
        PlanSchoolVisit("School A");
        PlanSchoolVisit("\nSchool B", 3);
        PlanSchoolVisit("\nSchool C", 2);
    }

    static void PlanSchoolVisit(string schoolName, int groups = 6)
    {
        RandomizeAnimals();

        string[,] group = AssignGroup(groups);
        Console.WriteLine(schoolName);
        PrintGroup(group);
    }

    static void RandomizeAnimals()
    {
        Random randomizer = new Random();

        for (int i = 0; i < pettingZoo.Length; i++)
        {
            int r = randomizer.Next(i, pettingZoo.Length);

            string temp = pettingZoo[i];
            pettingZoo[i] = pettingZoo[r];
            pettingZoo[r] = temp;
        }
    }

    static string[,] AssignGroup(int groups)
    {
        int animalsPerGroup = pettingZoo.Length / groups;
        string[,] result = new string[groups, animalsPerGroup];

        int start = 0;
        for (int i = 0; i < groups; i++)
        {
            for (int j = 0; j < animalsPerGroup; j++)
            {
                result[i, j] = pettingZoo[start++];
            }
        }

        return result;
    }

    static void PrintGroup(string[,] group)
    {
        for (int i = 0; i < group.GetLength(0); i++)
        {
            Console.Write($"Group {i + 1}: ");

            for (int j = 0; j < group.GetLength(1); j++)
            {
                Console.Write($"{group[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}
