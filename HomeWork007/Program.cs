Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if ((day <= 7) & (day > 0))
{
    if((day == 6) || (day == 7))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}
else
{
    Console.WriteLine("Неверное число!");
}