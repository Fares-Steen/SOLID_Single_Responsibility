namespace After;

public static class StandardMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to my application");
    }
    
    public static void EndApplication()
    {
        Console.WriteLine("press enter to close");
        Console.ReadLine();
    }

    public static void DisplayValidationError(string fieldName)
    {
        Console.WriteLine($"you did not give us a valid {fieldName}");
    }
}