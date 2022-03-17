namespace Adapter
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class ChemicalDatabank
    {
        // The databank 'legacy API'
        public float GetCriticalPoint(string compound, string point)
        {
            var com = compound.ToLowerInvariant();

            if (point == "M")
            {
                return com switch
                {
                    "water" => 0.0f,
                    "benzene" => 5.5f,
                    "ethanol" => -114.1f,
                    _ => 0f,
                };
            }
            
            return com switch
            {
                "water" => 100.0f,
                "benzene" => 80.1f,
                "ethanol" => 78.3f,
                _ => 0f,
            };
        }
        public string GetMolecularStructure(string compound)
            => compound.ToLowerInvariant() switch
            {
                "water" => "H20",
                "benzene" => "C6H6",
                "ethanol" => "C2H5OH",
                _ => string.Empty,
            };

        public double GetMolecularWeight(string compound)
            => compound.ToLowerInvariant() switch
            {
                "water" => 15,
                "benzene" => 78.1134,
                "ethanol" => 46.0688,
                _ => 0d,
            };
    }
}
