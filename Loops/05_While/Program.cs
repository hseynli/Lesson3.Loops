//Yuxarıda qeyd edilən problemi while dövrü ilə aşağıdakı kimi həll edə bilərik:

int sum = 0;
int counter = 1;

while (counter <= 5)
{
    sum += counter;
    Console.WriteLine("Counter {0}", counter);
    counter++;    
}

Console.WriteLine($"The result of 1-5 is {sum}.");