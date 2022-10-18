// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и
//  проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.WriteLine("Введите пятизнач число");
Console.ResetColor(); // возврат к белому цвету

string number = Console.ReadLine(); //Вводим число в строку, чтобы проверить его длину
int dlina = number.Length;          // Проверяем длину
if (dlina == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine($"{number} - Палиндром");
    }
    else 
    {
     System.Console.WriteLine($"{number} - не палиндром");
    }
}
else 
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"Attention: {number} - некорректно введено число"); // ошибка
    Console.ResetColor();
}