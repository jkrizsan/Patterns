using System;

namespace Command
{
    /// <summary>
    /// Command Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);
            user.Redo(3);

            Console.ReadKey();
        }
    }
}
