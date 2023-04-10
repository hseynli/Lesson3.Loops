int counter = 0;

while (counter < 3)
{
    counter++;
    Console.WriteLine("Counter {0}", counter);

    break;

    Console.WriteLine("Bu setir icra olunmayacaqdir.");
}

Console.WriteLine("{0} sayda iterasiya bas vermisdir.", counter);