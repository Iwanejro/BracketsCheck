using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BracketsCheck
{
    public class BracketsChecker
    {
        private Stack<char> _chars = new Stack<char>();
        private Dictionary<char, char> _brackets = new Dictionary<char, char>()
        {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'},
        };

        public string CheckExpression(string expression)
        {
            foreach (char c in expression)
            {
                if (_brackets.ContainsKey(c))
                {
                    _chars.Push(c);
                }

                if (_brackets.ContainsValue(c))
                {
                    if (_chars.Count == 0)
                    {
                        return string.Format("Napotkano nawias zamykający {0} bez wcześniejszego nawiasu otwierającego", c.ToString());
                    }

                    var lastBracketInStack = _chars.Peek();
                    var lastKey = _brackets.Keys.Last();

                    foreach (char openingBracket in _brackets.Keys)
                    {
                        if (lastBracketInStack == openingBracket && c == _brackets[openingBracket])
                        {
                            _chars.Pop();
                            break;
                        }
                        else if (lastKey == openingBracket)
                        {
                            return string.Format("Nawias zamykający {0} nie pasuje do otwierającego {1}", c.ToString(), lastBracketInStack.ToString());
                        }
                    }
                }
            }

            if (_chars.Count != 0)
            {
                foreach(char openingBracket in _brackets.Keys)
                {
                    if (openingBracket == _chars.Peek())
                    {
                        return "Brakuje nawiasu zamykającego " + _brackets[openingBracket].ToString();
                    }
                }
            }
            
            return Messages.Correct;
        }



    }
}
