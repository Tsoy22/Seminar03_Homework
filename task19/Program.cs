// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
string? digit = Convert.ToString(Console.ReadLine());
if (digit[0] == digit[4] || digit[1] == digit[3])
{
  Console.WriteLine($"Число: {digit} - ДА ");
}
else Console.WriteLine($"Число: {digit} - НЕТ ");

