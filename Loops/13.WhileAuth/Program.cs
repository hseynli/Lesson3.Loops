//Əvvəlcədən təyin olunmuş loqin və parol
string login = "admin";
string password = "admin";
int maxAttemt = 5;

Console.WriteLine("Please enter your login: ");
string userLogin = Console.ReadLine();
string userPassword;

if (login == userLogin)
{
    while (true)
    {
        Console.WriteLine("Please enter your password");
        userPassword = Console.ReadLine();
        if (password == userPassword)
        {
            Console.WriteLine("You successfully entered to system.");
            break;
        }
        else
        {
            maxAttemt--;
            Console.WriteLine("You entered wrong password. Your attemtd count: {0}", maxAttemt);
        }
        if (maxAttemt == 0)
            break;
    }    
}
else
{
    Console.WriteLine("You entered wrong login. End of program.");
}