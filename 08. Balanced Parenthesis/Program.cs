string brackets = Console.ReadLine();

Stack<char> stack = new();
foreach (var item in brackets)
{
    if (item == '[' || item == '(' || item == '{')
    {
        stack.Push(item);
    }
    else if (item == ')')
    {
        if (stack.Count == 0 || stack.Pop() != '(')
        {
            Console.WriteLine("NO");
            return;
        }

    }
    else if (item == '}')
    {
        if (stack.Count == 0 || stack.Pop() != '{')
        {
            Console.WriteLine("NO");
            return;
        }
    }
    else if (item == ']')
    {
        if (stack.Count == 0 || stack.Pop() != '[')
        {
            Console.WriteLine("NO");
            return;
        }
    }
}
Console.WriteLine("YES");