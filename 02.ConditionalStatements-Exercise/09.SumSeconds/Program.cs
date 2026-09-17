
int firstAthleteTime = int.Parse(Console.ReadLine());
int secondAthleteTime = int.Parse(Console.ReadLine());
int thirdAthleteTime = int.Parse(Console.ReadLine());

int sumSeconds = firstAthleteTime + secondAthleteTime + thirdAthleteTime;

int minutes = sumSeconds / 60;
int seconds = sumSeconds % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}
