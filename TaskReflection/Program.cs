namespace TaskReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            var prop = user.GetType().GetField("age", System.Reflection.BindingFlags.NonPublic
    | System.Reflection.BindingFlags.Instance);
            prop.SetValue(user,21);
            Console.WriteLine(prop.GetValue(user));

        }
    }
}