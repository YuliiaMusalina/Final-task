string[] symbols = { "1234", "1567", "-2", "computer science" };
string[] newSymbols = new string[symbols.Length];
int count = 0;
for (int i = 0; i < symbols.Length; i++)
{
    if (symbols[i].Length <= 3)
    {
        newSymbols[count] = symbols[i];
        count++;

    }

}
PrintArray(newSymbols);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}