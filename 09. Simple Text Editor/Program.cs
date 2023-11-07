int count = int.Parse(Console.ReadLine());
Stack<string> stack = new();
stack.Push("");

for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int command = int.Parse(tokens[0]);
    string number = stack.Peek();
    if (command == 1)
    {
        number += tokens[1];
        stack.Push(number);
    }
    else if (command == 2)
    {
        int counts = int.Parse(tokens[1]);
        stack.Push(number.Substring(0, number.Length - counts));
    }
    else if (command == 3)
    {
        int index = int.Parse(tokens[1]) - 1;
        Console.WriteLine(number.Substring(index, 1));
    }
    else if (command == 4)
    {
        stack.Pop();
    }
}