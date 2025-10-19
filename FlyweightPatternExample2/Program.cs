using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternExample2
{
    internal class Program
    {

        // Flyweight: shared character data

        class Character
        {
            private char symbol;
            private string font;
            private int size;
            public Character(char symbol, string font, int size)
            {
                this.symbol = symbol;
                this.font = font;
                this.size = size;
            }
            public void Display(int x, int y)
            {
                Console.WriteLine($"Character: {symbol}, Font: {font}, Size: {size}, Position: ({x},{y})");
            }
        }

        // Flyweight Factory

        class CharacterFactory
        {
            private Dictionary<string, Character> characters = new Dictionary<string, Character>();
            public Character GetCharacter(char symbol, string font, int size)
            {
                string key = $"{symbol}_{font}_{size}";
                if (!characters.ContainsKey(key))
                {
                    characters[key] = new Character(symbol, font, size);
                }
                return characters[key];
            }
        }

        // Context: stores unique data (position)
        class TextEditor
        {
            private CharacterFactory factory = new CharacterFactory();
            private List<(Character, int, int)> characters = new List<(Character, int, int)>();
            public void AddCharacter(char symbol, string font, int size, int x, int y)
            {
                Character character = factory.GetCharacter(symbol, font, size);
                characters.Add((character, x, y));
            }
            public void Display()
            {
                foreach (var (character, x, y) in characters)
                {
                    character.Display(x, y);
                }
            }
        }

        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            editor.AddCharacter('A', "Arial", 12, 10, 20);
            editor.AddCharacter('B', "Arial", 12, 15, 25);
            editor.AddCharacter('C', "Times New Roman", 14, 30, 40);
            editor.Display();
        }
    }
}
