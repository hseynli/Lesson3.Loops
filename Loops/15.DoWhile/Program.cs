int counter = 0;

do
{
    counter++;
    Console.WriteLine("Counter {0}", counter);

    break;

    Console.WriteLine("Bu setir icra olunmayacaqdir.");
}
while (counter < 3);

Console.WriteLine("{0} saytda iterasiya bas vermisdir.", counter);