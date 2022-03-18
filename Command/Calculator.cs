using System;

namespace Command
{
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    public class Calculator
    {
        int curr = 0;

        public void Operation(char @operator, int operand)
        {
            _ = @operator switch
            {
                '+' => curr += operand,
                '-' => curr -= operand,
                '*' => curr *= operand,
                '/' => curr /= operand,
                 _  => throw new InvalidOperationException(nameof(Operation)),
            };

            Console.WriteLine(
                "Current value = {0,3} (following {1} {2})",
                curr, @operator, operand);
        }
    }
}
