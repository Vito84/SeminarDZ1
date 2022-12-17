Console.WriteLine("Введите число для определения является ли оно чётным.");
int number = int.Parse(Console.ReadLine() ?? "Неверное значение");
int remnant = number % 2;
if (remnant == 0 ){
    Console.WriteLine($"число {number} чётное");
} 
else  
    Console.WriteLine($"число {number} НЕ чётное");
    