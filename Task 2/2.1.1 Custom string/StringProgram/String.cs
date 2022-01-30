using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProgram
{
    public class String
    {
        private char[] _symbols;

        public String(char[] symbols)
        {
            _symbols = new char[symbols.Length];

            for (int i = 0; i < symbols.Length; i++)
            {
                _symbols[i] = symbols[i];
            }
        }

        public int Length => _symbols.Length;

        public char this[int index] => _symbols[index];

        public override bool Equals(object obj)
        {
            String str = obj as String;
            if (str == null)
                throw new ArgumentException(nameof(obj));

            if (Length != str.Length)
                return false;

            for (int i = 0; i < Length; i++)
            {
                if (_symbols[i] != str._symbols[i])
                {
                    return false;
                }
            }
                
            return true;
        }

        public override int GetHashCode()
        {
            return _symbols.GetHashCode();
        }

        public void Show()
        {
            Console.WriteLine(new string(_symbols));
        }

        public String Concatenate(String other)
        {
            char[] symbols = new char[Length + other.Length];

            for (int i = 0; i < Length; i++)
            {
                symbols[i] = _symbols[i];
            }

            for (int i = 0; i < other.Length; i++)
            {
                symbols[i + Length] = other._symbols[i];
            }

            return new String(symbols);
        }

        public char[] ToArray()
        {
            char[] symbols = new char[Length];

            for (int i = 0; i < Length; i++)
            {
                symbols[i] = _symbols[i];
            }

            return symbols;
        }

        public String ToUpper()
        {
            return Apply(char.ToUpper);
        }

        public String ToLower()
        {
            return Apply(char.ToLower);
        }

        public String Apply(Func<char, char> function)
        {
            char[] symbols = new char[_symbols.Length];
            for (int i = 0; i < Length; i++)
            {
                symbols[i] = function(_symbols[i]);
            }

            return new String(symbols);
        }
    }
}
