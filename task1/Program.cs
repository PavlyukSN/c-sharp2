//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int numb;

Console.WriteLine("Введите трёхначное число");
numb= int.Parse(Console.ReadLine());

string numbstr = numb.ToString();

if (numbstr.Length != 3){
    Console.WriteLine($"это не трёхзначное число");
}
else{
    numb = numb /10;
    Console.WriteLine($"Вторая цифра - {numb % 10}");
}
