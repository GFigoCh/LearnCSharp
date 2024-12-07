namespace ProcessArrayData_Challenge;

class Program
{
    static void Main(string[] args)
    {
        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
        int assignmentCount = 5;

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

        Console.Clear();
        Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");
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

            decimal scoreSum = 0;
            decimal scoreBonusSum = 0;

            int assignmentBonusCount = 0;
            int assignmentIndex = 0;
            foreach (int score in studentScores)
            {
                if (assignmentIndex < assignmentCount)
                {
                    scoreSum += score;
                }
                else
                {
                    scoreBonusSum += score;
                    assignmentBonusCount++;
                }

                assignmentIndex++;
            }

            decimal studentGrade = (scoreSum + scoreBonusSum * 0.1M) / assignmentCount;
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

            decimal studentNonBonusGrade = scoreSum / assignmentCount;
            decimal gradeDifference = studentGrade - studentNonBonusGrade;
            decimal scoreBonusAverage = scoreBonusSum / assignmentBonusCount;
            Console.WriteLine($"{name}\t\t{studentNonBonusGrade}\t\t{studentGrade}\t{letterGrade}\t{scoreBonusAverage} ({gradeDifference} pts)");
        }

        Console.WriteLine("\nPress the Enter key to continue...");
        Console.ReadLine();
    }
}
