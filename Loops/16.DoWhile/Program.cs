int counter = 0;

do
{
    counter++;
    Console.WriteLine("Counter {0}", counter);

    continue;

    Console.WriteLine("Bu setir icra olunmayacaqdir.");
}
while (counter < 3);

Console.WriteLine("{0} sayda iterasiya bas vermisdir.", counter);
