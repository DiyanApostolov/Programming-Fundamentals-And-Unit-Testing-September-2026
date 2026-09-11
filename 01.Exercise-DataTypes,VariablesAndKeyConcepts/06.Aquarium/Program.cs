
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentOccupied = double.Parse(Console.ReadLine());

double volumeInLiters = length * width * height * 0.001; // divide by 1000.0

double occupiedVolume = volumeInLiters * percentOccupied / 100;

double neededLiters = volumeInLiters - occupiedVolume;

Console.WriteLine($"{neededLiters:F2}");

