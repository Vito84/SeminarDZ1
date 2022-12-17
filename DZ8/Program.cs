Console.WriteLine("Введите число N.");
int number = int.Parse(Console.ReadLine() ?? "Неверное значение");
Console.WriteLine("Все чётные числа в заданном N");
int counter = 1;
while (counter <= number ){
    int remnant = counter % 2;
if (remnant == 0 ){
    Console.Write($"{counter}, ");
    counter ++;
}
else
    counter ++;
}
