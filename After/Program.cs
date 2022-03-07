namespace After;

internal static class Program
{
    private static void Main(string[] args)
    {
        StandardMessages.WelcomeMessage();

        var user=PersonDataCapture.Capture();

        var isUserValid = PersonValidator.Validate(user);

        if (!isUserValid)
        {
            StandardMessages.EndApplication();
            return;
        }
       
        AccountGenerator.CreateAccount(user);
        StandardMessages.EndApplication();
    }
}