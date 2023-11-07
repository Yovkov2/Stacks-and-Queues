int quantity = int.Parse(Console.ReadLine());
Queue<int> queue = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Console.WriteLine(queue.Max());
while (queue.Count > 0)
{
    quantity -= queue.Peek();
    if (quantity < 0)
    {
        break;
    }
    queue.Dequeue();
}

if (queue.Any())
{
    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
}
else
{
    Console.WriteLine("Orders complete");
}