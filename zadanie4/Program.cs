// Задание 4
Console.Write("Введите число = ");
int a = Convert.ToInt32(Console.ReadLine());
int OstDel = a%2;
if (OstDel == 0)
{
    Console.WriteLine("Введенное число является четным ");
}
else
{
    Console.WriteLine("Введенное число является нечетным ");
}