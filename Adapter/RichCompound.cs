using System;

namespace Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class RichCompound : Compound
    {
        private string _chemical;
        private ChemicalDatabank _bank;

        public RichCompound(string chemical)
        {
            _chemical = chemical;
        }

        public override void Display()
        {
            // The Adaptee
            _bank = new ChemicalDatabank();

            boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            molecularWeight = _bank.GetMolecularWeight(_chemical);
            molecularFormula = _bank.GetMolecularStructure(_chemical);

            Console.WriteLine("\nCompound: {0} ------ ", _chemical);
            Console.WriteLine(" Formula: {0}", molecularFormula);
            Console.WriteLine(" Weight : {0}", molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", boilingPoint);
        }
    }
}
