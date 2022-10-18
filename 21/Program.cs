// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
System.Console.WriteLine("Введите координаты первой точки:x, y, z");
int [] p1 = new int[3];
p1[0] = Convert.ToInt32(System.Console.ReadLine());
p1[1] = Convert.ToInt32(System.Console.ReadLine());
p1[2] = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите координаты второй точки:x, y, z");
int [] p2 = new int[3];
p2[0] = Convert.ToInt32(System.Console.ReadLine());
p2[1] = Convert.ToInt32(System.Console.ReadLine());
p2[2] = Convert.ToInt32(System.Console.ReadLine());

double sum = 0;

for (int i = 0; i < p1.Length; i++)
{
    for (i = 0; i < p2.Length; i++)
    {
        double sum1 = Math.Pow(p1[i] - p2[i], 2);
        sum = sum + sum1;
    }
}
System.Console.WriteLine(sum);
double distance = Math.Round(Math.Sqrt(sum), 2);
System.Console.WriteLine($"Расстояние между точками равно {distance}");