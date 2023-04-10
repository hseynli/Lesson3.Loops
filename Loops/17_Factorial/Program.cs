int counter = 4;
int factorial = 1;

Console.Write("{0} ededinin faktoriali ", counter);

do
{
    // Birinci vurma əməli, daha sonra dekrement. 
    factorial *= counter--;

    // Yuxarıdakı sətir aşağıdakı şərtə ekvivalentdir:

    //factorial = factorial * counter;
    //counter = counter - 1;
}
while (counter > 0);

Console.WriteLine("{0}", factorial);