namespace SimpleDependencyInjectionConsole
{
    public class SimpleMessageValidator
    {
        public bool IsValid(string message)
        {
            return !string.IsNullOrWhiteSpace(message);
        }
    }
}