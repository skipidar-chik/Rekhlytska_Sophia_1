/*Дано словник. Вивести лише ті ключі, які менше або дорівнюють заданому ключу.
 Створити новий словник з двох елементів. В значення ключа першого елементу
 занести знайдені значенні. В другий записати значення, які не підпали під 
 критерій пошуку.*/
using System.Text.Json;

var dictionary = new Dictionary<int, string>()
{
    { 6, "S"},
    { 3, "O"},
    { 1, "L"},
    { 5, "I"},
    { 11, "D"}
};
Console.WriteLine("Dictionary: ");
foreach (var e in dictionary)
    Console.WriteLine(e);

Console.Write("\nChoose key: ");
int enterKey = Convert.ToInt32(Console.ReadLine());

List<int> fitKeys = new();
List<int> elseKeys = new();
foreach (var e in dictionary)
{
    if (e.Key <= enterKey)
    {
        fitKeys.Add(e.Key);
    }
    else elseKeys.Add(e.Key);
}
var result = new Dictionary<List<int>, int>()
{
    { fitKeys, 1},
    { elseKeys, 2}
};

Console.WriteLine("");
foreach (var e in result)
    Console.WriteLine("[{" + String.Join(", ", e.Key) + "}, " + e.Value + "]");

//string json = JsonSerializer.Serialize(result);
//Console.WriteLine(json);