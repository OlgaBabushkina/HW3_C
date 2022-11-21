/*Задача 19: Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли 
оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n = number;
string inverted = "";
if (number > 9999 && number < 100000)
{while (n > 0)
{
inverted = inverted + n%10;
n = n / 10;
}
if (Convert.ToInt32(inverted) == number)
{
    Console.WriteLine("да");
}
else Console.WriteLine("нет");
}
else Console.WriteLine("Введенное число должно быть пятизначным"); 

 
/*Задача 21: Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int xA = ReadInt("Введите координату X точки A: ");
int yA = ReadInt("Введите координату Y точки A: ");
int zA = ReadInt("Введите координату Z точки A: ");
int xB = ReadInt("Введите координату X точки B: ");
int yB = ReadInt("Введите координату Y точки B: ");
int zB = ReadInt("Введите координату Z точки B: ");
double distance = Math.Sqrt(square(xA-xB)+square(yA-yB)+square(zA-zB));
int square (int number)
{
    int result = number * number;
    return result;
}
Console.WriteLine($"Расстояние между точками равно: {distance}");


 
/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
int cube (int num)
{
int result = num * num * num;
return result;
}
while (i <= number)
{
    Console.Write($"{cube(i++)} ");
}
