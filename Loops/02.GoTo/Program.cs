﻿int counter = 0;

Label:
counter++;
Console.WriteLine("Counter = {0}", counter);

if (counter < 3)
{
    goto Label;
}

Console.WriteLine("End");