// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.

Console.WriteLine("Введите число N");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("|{0,5}|{1,9}|", "Число", "Куб числа");
for (int i = 1; i <= length; i++) 
Console.WriteLine("|{0,5}|{1,9}|", i, i*i*i);   
