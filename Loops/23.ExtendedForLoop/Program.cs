int counter = 0;
for (; ; )
{
    if (counter == 10)
    {
        break;
    }
    Console.WriteLine(counter);
    counter++;    
}

counter = 0;
Console.WriteLine(new string('-', 120));

for (; counter < 10; counter++)
{
    Console.WriteLine(counter);
}

counter = 0;
Console.WriteLine(new string('-', 120));

for (; counter < 10;)
{
    Console.WriteLine(counter);
    counter++;
}