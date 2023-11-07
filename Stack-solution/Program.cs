int[] tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int elementsToPop = tokens[1];
int specialNumber = tokens[2];

for (int i = 0; i < elementsToPop; i++)
{
    stack.Pop();
}

if (stack.Contains(specialNumber))
{
    if (stack.Count > 0)
    {
        Console.WriteLine("true");
    }
}
else
{
    if (stack.Any())
    {
        Console.Write(stack.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}