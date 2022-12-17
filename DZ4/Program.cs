Console.WriteLine("Для определения максимального числа.");
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine() ?? "Неверное значение");
Console.Write("Введите число В: ");
int numberB = int.Parse(Console.ReadLine() ?? "Неверное значение");
Console.Write("Введите число С: ");
int numberC = int.Parse(Console.ReadLine() ?? "Неверное значение");
if (numberA > numberB && numberA > numberC){
    Console.WriteLine($"Максимальное число из трех: {numberA}");
    }
else if (numberB > numberC){
    Console.WriteLine($"Максимальное число из трех: {numberB}");
}
else
    Console.WriteLine($"Максимальное число из трех: {numberC}");
    
