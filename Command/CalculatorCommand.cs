using System;

namespace Command
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    public class CalculatorCommand : Command
    {
        private readonly Calculator _calculator;

        public CalculatorCommand(Calculator calculator,
            char @operator, int operand)
        {
            _calculator = calculator;
            Operand = operand;
            Operator = @operator;
        }

        public char Operator { get; set; }

        public int Operand { get; set; }

        public override void Execute()
            => _calculator.Operation(Operator, Operand);

        public override void UnExecute()
            => _calculator.Operation(Undo(Operator), Operand);
        
        private char Undo(char @operator)
            => @operator switch
            {
                '+' => '-',
                '-' => '+',
                '*' => '/',
                '/' => '*',
                _ => throw new ArgumentException(nameof(@operator)),
            };
    }
}
