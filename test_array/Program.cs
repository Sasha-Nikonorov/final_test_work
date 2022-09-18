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
            Console.Write($"{stringarray[i]}");
        }
    }
}