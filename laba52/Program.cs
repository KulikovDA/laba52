//средний 19
Console.WriteLine("Введите строку символов:");
string inputString = Console.ReadLine();
string resultString = string.Join(" ", inputString.ToCharArray());
Console.WriteLine("Результат:");
Console.WriteLine(resultString);