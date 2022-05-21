// Напишите программу, которая принимает на
// вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// Решение задачи без использования массива

Console.Write("Введите координату х точки A = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y точки A = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату z точки A= ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату х точки B = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y точки B = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату z точки B= ");
int z2 = int.Parse(Console.ReadLine());

int res1 = x1 - x2;
int res2 = y1 - y2;
int res3 = z1 - z2;

int result1 = res1 * res1 + res2 * res2 + res3 * res3;
double result = Math.Sqrt(result1);
Console.WriteLine("{0: 0.00}" ,result);
