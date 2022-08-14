int a = new Random().Next(10,9999);
Console.WriteLine("Начальное число: " + a);

if(a / 1000 != 0)
 {
     Console.WriteLine("Третья цияра цисла: " + (a % 100)/10);
 }
else if (a / 100 != 0)
 {
     Console.WriteLine("Третья цияра цисла: " + a % 10);
 }
else
{
    Console.WriteLine("Нет третьей цифры");
}