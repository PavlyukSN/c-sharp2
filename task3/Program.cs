// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int day;

Console.WriteLine("проверка дня на выходной");
day= int.Parse(Console.ReadLine());

if (day <= 5){
    Console.WriteLine("нет");
}
else{
Console.WriteLine("да");
}


