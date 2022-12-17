Console.WriteLine("Для определения большего числа.");
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine() ?? "Неверное значение");
Console.Write("Введите число В: ");
int numberB = int.Parse(Console.ReadLine() ?? "Неверное значение");
if (numberA > numberB){
    Console.WriteLine($"Большее число А: {numberA}");
    Console.WriteLine($"Меньшее число В: {numberB}");
}
else  
    Console.WriteLine($"Большее число В: {numberB}");
    Console.WriteLine($"Меньшее число А: {numberA}");
