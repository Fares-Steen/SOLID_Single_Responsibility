using Before;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my application");

        Person user = new Person();

        Console.WriteLine("What is your first name");
        user.FirstName = Console.ReadLine();

        Console.WriteLine("What is your last name");
        user.LastName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(user.FirstName))
        {
            Console.WriteLine("you did not give us a valid first name");
            Console.ReadLine();
            return;
        }
        if (string.IsNullOrWhiteSpace(user.LastName))
        {
            Console.WriteLine("you did not give us a valid last name");
            Console.ReadLine();
            return;
        }

        Console.WriteLine($"Your new username is {user.FirstName.Substring(0,1)} {user.LastName}");
        Console.ReadLine();
    }
}