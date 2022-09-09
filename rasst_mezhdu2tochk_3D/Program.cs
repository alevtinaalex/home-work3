//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}

int Sqr(int n)
{
    return n * n;
}

int[] InputCoords(int n)
{
    int[] coord = new int[3];
    coord[0] = Prompt($"Введите x{n} первой координаты");
    coord[1] = Prompt($"Введите y{n} первой координаты");
    coord[2] = Prompt($"Введите z{n} первой координаты");
    return coord;
}

int[]coord1 = InputCoords(1);
int[]coord2 = InputCoords(2);

double length = Math.Sqrt(Sqr(coord2[0] - coord1[0]) + Sqr(coord2[1] - coord1[1]) + Sqr(coord2[2] - coord1[2]));
System.Console.WriteLine(length);

