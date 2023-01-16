// Программа вычисляет сумму двух случайных чисел

int numA = new Random() .Next(1,10);
// 1 2 3 ... 9 new Random () - записывает число
// .Next - задает диапозон генерируемых чисел(1,11)
Console.WriteLine(numA);
int numB = new Random() .Next(1,12);
Console.WriteLine(numB);
int result = numA + numB;
Console.WriteLine(result);