// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, 
// является ли оно палиндромом


int num = new Random().Next(10000, 100000);                     //рандомное число
Console.WriteLine("Случайное пятизначное число = " + num );
string text = num.ToString();
if (text[0] == text[4] && text[1] == text[3]) Console.WriteLine("Число " + num + " является палиндромом" );
else Console.WriteLine("Число " + num + " не является палиндромом" );

Console.Write("Введите пятизначное число = ");
int num1 = int.Parse(Console.ReadLine());                        //ввод числа с клавиатуры
Console.WriteLine("Число = " + num1 );
string text1 = num1.ToString();
if (text1[0] == text1[4] && text1[1] == text1[3] && num1 < 100000) Console.WriteLine("Число " + num1 + " является палиндромом" );
else Console.WriteLine("Число " + num1 + " не является палиндромом" );
