int counter = 0;

while (counter < 3)
{
    counter++;
    Console.WriteLine("Counter {0}", counter);

    continue;

    Console.WriteLine("Bu setir icra olunmayacaqdir.");
}

Console.WriteLine("{0} sayda itersiya icra olunmusdur.", counter);