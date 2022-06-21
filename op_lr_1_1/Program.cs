
/*У вхідному файлі розташовані два набори додатніх чисел; між наборами 
є від’ємне число. Побудувати два списки C1 і С2, елементи яких містять 
числа 1-го і 2-го набору таким чином, щоб відповідно всередині одного 
списку числа були впорядковані по зростанню. Потім об'єднати списки 
C1 і С2 в один впорядкований список.*/

//числа из файла в список
var reader = new StreamReader(@"1.txt");
var line = reader.ReadLine();
if (line == null)
    throw new Exception("Empty line!");
Console.WriteLine($"Numbers from the file: {line}") ;
var list = line.Split(" ").Select(Int32.Parse).ToList();

//разделитель (отрицательное число)
int separatorIndex = list.IndexOf(list.Min());

//список 1
List<int> C1 = list.GetRange(0, separatorIndex); 
C1.Sort();
Console.WriteLine("\nC1: ");
PrintList(C1);

//список 2
List<int> C2 = list.GetRange(separatorIndex+1, list.Count- separatorIndex-1);
Console.WriteLine("\n\nC2: ");
PrintList(C2);

//список 3
List<int> C3 = new();
C3.AddRange(C1);
C3.AddRange(C2);
C3.Sort();
Console.WriteLine("\n\nC3: ");
PrintList(C3);

static void PrintList(List<int> list)
{
    foreach(int item in list) 
        Console.Write($"{item} ");
}