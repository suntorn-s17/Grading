using System.Windows.Input;
namespace Grading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nEnter your score(0-100) : ");
                Console.WriteLine("Type(00) to exit program.");
                Console.Write("Enter your score : ");
                string number = Console.ReadLine();
                int score;
                if (!string.IsNullOrWhiteSpace(number))
                {
                    if (number.Equals("00"))
                    {
                        break;
                    }
                    else if (!int.TryParse(number, out score) || score < 0 || score > 100)
                    {
                        Console.WriteLine("Invarid number. Please enter 0 - 100.");
                        continue;
                    }

                    if (score >= 80)
                    {
                        Console.WriteLine("Grade A.");
                    }
                    else if (score >= 75 || score <= 79)
                    {
                        Console.WriteLine("Grade B+.");
                    }
                    else if (score >= 70 || score <= 74)
                    {
                        Console.WriteLine("Grade B.");
                    }
                    else if (score >= 65 || score <= 69)
                    {
                        Console.WriteLine("Grade C+.");
                    }
                    else if (score >= 60 || score <= 64)
                    {
                        Console.WriteLine("Grade C.");
                    }
                    else if (score >= 55 || score <= 59)
                    {
                        Console.WriteLine("Grade D+.");
                    }
                    else if (score >= 50 || score <= 54)
                    {
                        Console.WriteLine("Grade D.");
                    }
                    else if (score >= 0 || score <= 49)
                    {
                        Console.WriteLine("Grade F.");
                    }
                }
                else
                {
                    Console.WriteLine("Score cannot be empty.");
                }
            }
        }
    }
}
