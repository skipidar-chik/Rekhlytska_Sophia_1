/*Дана послідовність цілих чисел. Витягти з неї всі додатні двозначні числа, 
  відсортувавши їх по зростанню.*/

List<int> sequence = new() { 10, -6, 3, -4, 15, 0, -12, 16, 3, -14 };

Console.WriteLine("Sequence: ");
foreach (int s in sequence)
    Console.Write($"{s} ");

var selectedNums = sequence.Where(p => p >= 10 & p <= 99).OrderBy(p => p);

Console.WriteLine("\n\nTwo - digit positive numbers: ");
foreach (int s in selectedNums)
    Console.Write($"{s} ");