// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите любое число:");
int number = Convert.ToInt32(Console.ReadLine());
var str = number.ToString();

if (str.Length >= 3) {
    Console.WriteLine("Вторая цифра: {0}", str[2]);
} else {
    Console.WriteLine("Третьей цифры нет");
}
