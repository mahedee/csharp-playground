namespace Multicast
{
    public delegate void GreetingDelegate(string name);

    public class Greeting
    {
        public static void SayHello(string name)
        {
            Console.WriteLine("Hello " +  name + "!");
        }

        public static void SayBye(string name)
        {
            Console.WriteLine($"Bye {name} !");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            GreetingDelegate greetingDelegate = new GreetingDelegate(Greeting.SayHello);
            greetingDelegate += new GreetingDelegate(Greeting.SayBye);
            greetingDelegate("John"); // Output: "Hello, John!" "Goodbye, John!"
        }
    }
}