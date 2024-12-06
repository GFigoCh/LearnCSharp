namespace ProcessArrayData;

class Program
{
    static void Main(string[] args)
    {
        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
        int assignmentCount = 5;

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
        int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
        int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

        Console.WriteLine("Student\t\tGrade\n");
        foreach (string name in studentNames)
        {
            int[] studentScores = Array.Empty<int>();
            if (name == "Sophia")
            {
                studentScores = sophiaScores;
            }
            else if (name == "Andrew")
            {
                studentScores = andrewScores;
            }
            else if (name == "Emma")
            {
                studentScores = emmaScores;
            }
            else if (name == "Logan")
            {
                studentScores = loganScores;
            }
            else if (name == "Becky")
            {
                studentScores = beckyScores;
            }
            else if (name == "Chris")
            {
                studentScores = chrisScores;
            }
            else if (name == "Eric")
            {
                studentScores = ericScores;
            }
            else if (name == "Gregor")
            {
                studentScores = gregorScores;
            }

            int scoreSum = 0;
            int assignmentIndex = 0;
            foreach (int score in studentScores)
            {
                if (assignmentIndex < assignmentCount)
                {
                    scoreSum += score;
                }
                else
                {
                    scoreSum += score / 10;
                }

                assignmentIndex++;
            }

            decimal studentGrade = (decimal)scoreSum / assignmentCount;
            string letterGrade = "F";
            if (studentGrade >= 97)
            {
                letterGrade = "A+";
            }
            else if (studentGrade >= 93)
            {
                letterGrade = "A";
            }
            else if (studentGrade >= 90)
            {
                letterGrade = "A-";
            }
            else if (studentGrade >= 87)
            {
                letterGrade = "B+";
            }
            else if (studentGrade >= 83)
            {
                letterGrade = "B";
            }
            else if (studentGrade >= 80)
            {
                letterGrade = "B-";
            }
            else if (studentGrade >= 77)
            {
                letterGrade = "C+";
            }
            else if (studentGrade >= 73)
            {
                letterGrade = "C";
            }
            else if (studentGrade >= 70)
            {
                letterGrade = "C-";
            }
            else if (studentGrade >= 67)
            {
                letterGrade = "D+";
            }
            else if (studentGrade >= 63)
            {
                letterGrade = "D";
            }
            else if (studentGrade >= 60)
            {
                letterGrade = "D-";
            }

            Console.WriteLine(name + "\t\t" + studentGrade + "\t" + letterGrade);
        }

        Console.WriteLine("\nPress the Enter key to continue...");
        Console.ReadLine();
    }
}
