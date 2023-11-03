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
            var prop2=user.GetType().GetField("name", BindingFlags.NonPublic
    | BindingFlags.Instance);
            prop.SetValue(user,"Melek");
            Console.WriteLine(prop.GetValue(user));

        }
    }
}
