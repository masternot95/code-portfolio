// Задание 1. Калькулятор оценок

int[] ocenki = { 5, 4, 3, 5, 2, 5, 4 };

int summa = 0;
int pyaterki = 0;
int dvoiki = 0;

for (int i = 0; i < ocenki.Length; i++)
{
    summa = summa + ocenki[i];

    if (ocenki[i] == 5)
    {
        pyaterki++;
    }

    if (ocenki[i] == 2)
    {
        dvoiki++;
    }
}

double srednee = (double)summa / ocenki.Length;

Console.WriteLine("Средний балл: " + srednee);
Console.WriteLine("Количество пятёрок: " + pyaterki);
Console.WriteLine("Количество двоек: " + dvoiki);


// Задание 2. Переворот массива

int[] numbers = { 1, 2, 3, 4, 5 };

Console.WriteLine("Массив в прямом порядке:");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine();

Console.WriteLine("Массив в обратном порядке:");

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine();


// Задание 3. Вывод чётных чисел

for (int i = 1; i <= 20; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }

    Console.Write(i + " ");
}

Console.WriteLine();


// Задание 4. Ввод пароля с ограничением по попыткам

int password = 1234;
int attempts = 0;

while (attempts < 3)
{
    Console.Write("Введите пароль: ");
    int userPassword = Convert.ToInt32(Console.ReadLine());

    attempts++;

    if (userPassword == password)
    {
        Console.WriteLine("Доступ разрешен");
        break;
    }
    else
    {
        Console.WriteLine("Неверный пароль");
    }
}

if (attempts == 3)
{
    Console.WriteLine("Доступ запрещён");
}
