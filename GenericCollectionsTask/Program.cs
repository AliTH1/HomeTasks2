using GenericCollectionsTask.Models;
using GenericCollectionsTask.Utilities.Exceptions;

CustomList<int> customList = new CustomList<int>();
customList.Add(5);
customList.Add(6);

for (int i = 0; i < customList.arr.Length; i++)
{
    Console.WriteLine($"Item {i + 1} array: {customList.arr[i]}");
}


Console.WriteLine("Count: " + customList.Count());
Console.WriteLine(customList.Contains(5));
//customList.Clear();


try
{
    customList.Remove(4);
}
catch (NotFoundException ex)
{
    Console.WriteLine(ex.Message);
}


for (int i = 0; i < customList.arr.Length; i++)
{
    Console.WriteLine($"Item {i + 1} array: {customList.arr[i]}");
}