int Num = new Random().Next(100,999);
Console.WriteLine(Num);
int NewNum = ((Num / 10)% 10);

Console.WriteLine(NewNum);