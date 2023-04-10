int counter = 0;

while (counter < 10)
{
    //Əgər counter 4-ə bərabər olarsa, onda dövrdən çıx
    if (counter == 4)
    {
        break;
    }
    Console.WriteLine(counter);
    counter++;
}