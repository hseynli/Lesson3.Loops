Console.WriteLine("Dusunulmus rengi 5 cehd erzinde tapin.");
Console.WriteLine("Proqramdan cixmaq ucun 'exit' daxil edin.");

const int maxAttempt = 5; // İcazə verilən maksimal cəhd.
int attempt = 0;          // Cari cəhdlərin sayı.
string color = "red";     // Düşünülmüş rəng.

while (attempt < maxAttempt)
{
    attempt++;
    Console.WriteLine("Cehd {0}:", attempt);

    string value = Console.ReadLine();

    if (value == "exit")
    {
        break;
    }

    if (value != color)
    {
        continue;
    }

    Console.WriteLine("Tebrik edirik, {0} cehdden sonra rengi tapdiniz!", attempt);
    break;
}

Console.WriteLine("Oyunun sonu!");