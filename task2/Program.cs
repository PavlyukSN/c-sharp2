// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 2679 -> 6

void trinumb(int numb, int i ){
    while (i > 3){
    numb = numb /10;
    i = i-1;
}
Console.WriteLine(numb % 10);
}

//-------------------------------------

int numb, i;

Console.WriteLine("Введите число");
numb= int.Parse(Console.ReadLine());

string numbstr = numb.ToString();
i = numbstr.Length;
if (i < 3){
    Console.WriteLine("третьей цифры нет");
}
else{
trinumb(numb, i);
}
 