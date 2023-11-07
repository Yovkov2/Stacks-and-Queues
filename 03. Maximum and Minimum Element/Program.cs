int countOperations = int.Parse(Console.ReadLine());
Stack<int> stack = new();

for (int i = 0; i < countOperations; i++)
{
    int[] operations = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    if (operations[0] == 1)
    {
        int numberToPop = operations[1];
        stack.Push(numberToPop);
    }
    else if (operations[0] == 2)
    {
        if (stack.Count > 0)
        {
            stack.Pop();
        }
    }
    else if (operations[0] == 3)
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Max());
        }
    }
    else if (operations[0] == 4)
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Min());
        }
    }
}
Console.WriteLine(string.Join(", ", stack));