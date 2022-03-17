using Flyweight.Abstracts;
using Flyweight.ConcreteFlyweights;
using System.Collections.Generic;

namespace Flyweight
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    public class CharacterFactory
    {
        private Dictionary<char, Character> _characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            // Uses "lazy initialization"
            Character character = null;

            if (_characters.ContainsKey(key))
            {
                character = _characters[key];
            }
            else
            {
                character = insertNewCharacter(key);
            }
            return character;
        }

        private Character insertNewCharacter(char key)
        {
            Character character = key switch
            {
                'A' => new CharacterA(),
                'B' => new CharacterB(),
                //...
                'Z' => new CharacterZ(),
                _ => throw new System.NotImplementedException(),
            };

            _characters.Add(key, character);

            return character;
        }
    }
}
