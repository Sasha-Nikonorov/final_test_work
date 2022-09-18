void PrintArray(string[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine();
}
void ThreeSymbolArray(string[] array)
{
    string[] stringarray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            stringarray[i] = array[i];
            Console.Write($"{stringarray[i]} ");
        }
    }
}
string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan", "GG", "11", "(_)" };
PrintArray(array);
Console.WriteLine();
ThreeSymbolArray(array);