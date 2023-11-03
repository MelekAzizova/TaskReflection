namespace TaskReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            var prop = user.GetType().GetField("age", BindingFlags.NonPublic
    | BindingFlags.Static);
            prop.SetValue(user,21);
            Console.WriteLine(prop.GetValue(user));

        }
    }
}
