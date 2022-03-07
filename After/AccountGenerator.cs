namespace After;

public static class AccountGenerator
{
    public static void CreateAccount(Person user)
    {
        Console.WriteLine($"Your new username is {user.FirstName[..1]}{user.LastName}");
    }
}