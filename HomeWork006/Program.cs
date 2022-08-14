int a = new Random().Next(10,999);
Console.WriteLine("Начальное число: " + a);

if(a / 100 != 0)
 {
     Console.WriteLine("Третья цияра цисла: " + (a % 10));
 }

else
{
    Console.WriteLine("Нет третьей цифры");
}