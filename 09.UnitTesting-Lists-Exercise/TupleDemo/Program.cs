// regular variables
int num = 5;
string text = "blabla";

// Student - tuple
(string name, int age, string homeTown) student = ("Pesho", 21, "Burgas");

Console.WriteLine($"{student.name} is {student.age} years old from {student.homeTown}.");

// Point - tuple
(int x, int y) pointA = (2, -3);

Console.WriteLine(pointA.x);
Console.WriteLine(pointA.Item1);

// Matrix
List<List<int>> matrix = new List<List<int>>();

