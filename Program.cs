Console.Clear();
string[] array = { "Hello", "2", "world", ":-)" };
string[] newArray = new string[array.Length];
int elementLength = 3;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= elementLength) newArray[i] = array[i];
}
Console.Write($"[" + String.Join(", ", array) + "] -> ");
Console.WriteLine($"[" + String.Join(" ", newArray) + "]");