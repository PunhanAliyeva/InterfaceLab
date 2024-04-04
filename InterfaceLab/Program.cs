namespace InterfaceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("_punhan","punhan@gmail.com","156KHH1E");
            Console.WriteLine(user.PasswordChecker(user.Password));
            user.ShowInfo();
        }
    }
}