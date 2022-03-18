using System;
using System.Collections.Generic;

namespace Strategy.ConcreteStrategies
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("MergeSorted list ");
        }
    }
}
