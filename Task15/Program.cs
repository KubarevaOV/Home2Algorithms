// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите номер дня на неделе:");
int number = Convert.ToInt32(Console.ReadLine());

switch (number) {
    case 1: case 2: case 3: case 4: case 5:
        Console.WriteLine("Это не выходной. Работай");
        break;
    case 6: case 7:
        Console.WriteLine("Выходной! Гуляем");
        break;
    default:
        Console.WriteLine("Таких дней не бывает");
        break;
}