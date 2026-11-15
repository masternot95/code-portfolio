// Задание 1. Конвертер температуры

Console.Write("Введите температуру в Цельсиях: ");
double c = Convert.ToDouble(Console.ReadLine());

double f = c * 9 / 5 + 32;

Console.WriteLine("Температура в Фаренгейтах: " + f);


// Задание 2. Среднее арифметическое трёх чисел

Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите третье число: ");
double d = Convert.ToDouble(Console.ReadLine());

double result = (a + b + d) / 3;

Console.WriteLine("Среднее арифметическое: " + result);


// Задание 3. Калькулятор

Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Сумма: " + (num1 + num2));
Console.WriteLine("Разность: " + (num1 - num2));
Console.WriteLine("Произведение: " + (num1 * num2));

if (num2 != 0)
{
    Console.WriteLine("Частное: " + (num1 / num2));
}
else
{
    Console.WriteLine("На ноль делить нельзя!");
}
