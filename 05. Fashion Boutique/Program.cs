Stack<int> stack = new(
    Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int racks = int.Parse(Console.ReadLine());

int currentRacks = racks;
int sumOfRacks = 1;

while (stack.Count > 0)
{
    currentRacks -= stack.Peek();
    if (currentRacks < 0)
    {
        currentRacks = racks;
        sumOfRacks++;
        continue;
    }
    stack.Pop();
}
Console.WriteLine(sumOfRacks);