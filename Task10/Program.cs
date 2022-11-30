// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
var str = number.ToString();
Console.WriteLine("Вторая цифра: {0}", str[1]);