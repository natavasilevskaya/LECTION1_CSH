// Программа вычисляет сумму двух чисел

int numA = 3; // задаем переменну - обозначаем тип и присваиваем значение
//можно также переменную получить от пользователя или воспользоваться генератором
//псевдослучайных чисел
int numB = 9;

Console.WriteLine("Сумма чисел " + numA  + " и " + numB + " pавна " + numA+numB);
//Можно и через промежуточную переменную:

int result = numA + numB;
Console.WriteLine(result);

// int numberA = new Random ().Next(1,10);  //1,2...9
// Console.WriteLine(numberA);
// int numberB = new Random ().Next(1,10);
// Console.WriteLine(numberB);
// int  result = numberA + numberB;
// Console.WriteLine(result);