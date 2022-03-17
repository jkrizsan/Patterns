using System;

namespace Adapter
{
    /// <summary>
    /// Adapter Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound();
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();
            Compound benzene = new RichCompound("Benzene");
            benzene.Display();
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            Console.ReadKey();
        }
    }
}
