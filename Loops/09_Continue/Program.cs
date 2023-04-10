//1-dən 10-a kimi cüt ədədlərin ekrana çıxarılması
int counter = 0;

while (counter <= 10)
{
    counter++;
    if (counter % 2 == 1)
    {
        continue;
    }
    Console.WriteLine(counter);
}