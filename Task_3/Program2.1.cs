// Напишите программу, которая принимает на
// вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// Решение задачи с использованием массива

Console.WriteLine("Введите последовательно координаты X, Y, Z для первой точки");
int count;

double [] pointA = new double [3];
for (count = 0; count < 3; count ++)
{
pointA[count] = Convert.ToDouble(Console.ReadLine());

}

Console.WriteLine("Введите последовательно координаты X, Y, Z для второй точки");
double [] pointB = new double [3];
for (count = 0; count < 3; count ++) {
    pointB[count] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Ваши точки: А (" + pointA[0] + "; " + pointA[1] + "; " + pointA[2] + "), B(" + pointB[0] + "; " + pointB[1] + "; " + pointB[2] + " )");

double result;
double Distance(double[] pointA, double[] pointB)
{
    result = Math.Sqrt((pointB[0] - pointA[0]) * (pointB[0] - pointA[0]) + (pointB[1] - pointA[1]) * (pointB[1] - pointA[1]) + (pointB[2] - pointA[2]) * (pointB[2] - pointA[2]));
    return result;
}

double dist = Distance(pointA, pointB);
Console.WriteLine("Расстояние между двумя точками равно " + "{0: 0.00}" ,dist);

