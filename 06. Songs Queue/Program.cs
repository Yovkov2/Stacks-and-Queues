Queue<string> queue = new(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries));

while (queue.Count > 0)
{
    string[] command = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "Play")
    {
        queue.Dequeue();
    }
    else if (command[0] == "Add")
    {
        string song = string.Join(" ", command.Skip(1));
        if (queue.Contains(song))
        {
            Console.WriteLine($"{song} is already contained!");
        }
        else
        {
            queue.Enqueue(song);
        }
    }
    else if (command[0] == "Show")
    {
        Console.WriteLine($"{string.Join(", ", queue)}");
    }
}
Console.WriteLine("No more songs!");