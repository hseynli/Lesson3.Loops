int i = 1, j = 1;

while (i <= 10)
{
    while (j <= 10)
    {
        Console.WriteLine($"{i}*{j}={i * j}");
        j++;
    }
    i++;
    j = 1;
}